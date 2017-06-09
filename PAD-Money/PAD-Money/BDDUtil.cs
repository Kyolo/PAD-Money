using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PAD_Money
{
    public class BDDUtil {

        //Les << sont utilisé puisque que C# ne supporte pas d'utiliser 0b...
        public const int LOCAL_ERROR =      1;//Erreur de l'ajout en local
        public const int LOCAL_SUCCES =     1 << 1;//Réussite lors de l'ajout en local

        public const int REMOTE_ERROR =     1 << 2;//Erreur générique lors de l'ajout à distance
        public const int REMOTE_SUCCES =    1 << 3;//Réussite lors de l'ajout à distance
        public const int REMOTE_CONN_ERROR= 1 << 4 | REMOTE_ERROR;//Problème de connexion à distance
        public const int REMOTE_SQL_ERROR = 1 << 5 | REMOTE_ERROR;//Problème avec la requète à distance

        private BDDUtil(){}//Classe utilitaire : on ne veut pas qu'elle puisse être instanciée

		public static Font defaultFont;

        //L'objet connection permettant d'acceder à la bdd
        private static OleDbConnection connec = null;

        //La bdd locale
        private static DataSet ds = null;

        public static void init(OleDbConnection connec, DataSet ds, Font ft){
			//On assigne pour l'initialisation
            BDDUtil.connec = connec;
            BDDUtil.ds = ds;
			BDDUtil.defaultFont = ft;
        }

        private static String objectToStringRep(object val){
            String d = "";

            //On gère des types particuliers
            if(val == null){
                //Si la valeur est nulle, on le met comme tel
                d = "NULL";
            } else if(val.GetType().Equals(typeof(DateTime))){
                //La date parce qu'il faut rajouter des # avant et après
                DateTime time = (DateTime)val;
                d = "#"+time.Day+"/"+time.Month+"/"+time.Year+"#";
            } else if(val.GetType().Equals(typeof(String))){
                //Les chaines de caractères car elles doivent êtres entre '
                d = "'"+val.ToString()+"'";
            }else {
                //Pour le reste des types disponibles (entiers, flottants, etc...)
                //On les affiches de manière brute
                d = val.ToString();
            }

            return d;
        }

        private static int maxCode(String table, String keyname){
            //On renvoie la valeur maximale de la table, pour pouvoir affecter une clef primaire non utilisée
            DataTable tab = ds.Tables[table];
            int max = 0;
            foreach(DataRow r in tab.Rows){
                if(((int)r[keyname]) > max){
                    max = (int)r[0];
                }
            }
           return max;
        }

        public static int addLine(String table, params object[] data){

            //Maintenant le but est de convertir la liste data en datarow
            //On commence par récupéré un DataRow du bon type
            DataRow nrow = ds.Tables[table].NewRow();
            
            //Si la taille de la ligne est != de celles des données(cad + ou - de données)
            //il y a donc un erreur et donc ce n'est pas la peine de continuer plus loin
            if(nrow.ItemArray.Length != data.Length)
                return LOCAL_ERROR | REMOTE_SQL_ERROR;

            //Puis on remplit (data.length = nrow.ItemArray.Length, voir plus gaut)
            for(int i = 0; i < data.Length; i++){
                nrow[i] = data[i];

            }

            //Et on appel l'autre méthode pour faire le travail
            return addLine(table, nrow);
        }

        public static int addLine(String table, DataRow data){
            //On vérifie que la classe a été initialisée, cad que le DataSet et la Connection sont != null
            if(connec == null || ds == null)
                throw new InvalidOperationException("Classe BDDUtil incorrectement initialisée");
            
            int resLoc = addlineLoc(table, data);//On ajoute la ligne en local
            int resRem = addLineRem(table, data);//Et dans le fichier

            //On "combine" les deux résultats, afin d'avoir toute les message en un
            return resLoc | resRem;
        }

        private static int addlineLoc(String table, DataRow data){
            DataTable tab = ds.Tables[table];//On récupère la table
            try{
                tab.Rows.Add(data);//On ajoute la ligne
            } catch(Exception e) {
				MessageBox.Show(e.GetType() + "\n" + e.Message);

				return LOCAL_ERROR;
            }

            return LOCAL_SUCCES;
        }

        private static int addLineRem(String table, DataRow data){
            //On utilise une variable pour ne pas quitter au beau milieu des blocs catch
            int resultat = REMOTE_SUCCES;

            try {
                connec.Open();

                OleDbCommand comm = connec.CreateCommand();
                //pas besoin d'indiquer le type par défaut puisque c'est text et c'est ce qu'on veut
                
                //On crée des StringBuilder pour travailler facilements sur la commande
                StringBuilder commLeft = new StringBuilder().Append("INSERT INTO ["+table+"] (");
                StringBuilder commRight = new StringBuilder().Append("VALUES (");

                //On récupère les colonnes pour avoir leurs noms
                DataColumnCollection col = data.Table.Columns;
                
                //On récupère les données
                object[] rawdata = data.ItemArray;

                for(int i = 0; i < col.Count; i++){
                    String name = "["+col[i].ColumnName+"], ";
                    String d = objectToStringRep(rawdata[i]);

                    commLeft.Append(name);
                    commRight.Append(d+", ");

                }

                //On vire la dernière virgule et on ferme les paranthèse
                commLeft.Remove(commLeft.Length -2, 2).Append(") ");
                commRight.Remove(commRight.Length -2, 2).Append(") ");

                //Et on stocke la commande dans le OleDbCommand
                comm.CommandText = commLeft.ToString() + commRight.ToString();

                //Et maintenant qu'on a notre commande on peut l'éxécuter !
                int reqRes = comm.ExecuteNonQuery();
                
                //En théorie une insertion ne modifie qu'une ligne, donc ça renvoie qqch de différent ssi il y a un problème
                if(reqRes != 1)
                    resultat = REMOTE_SQL_ERROR;
            

            } catch (InvalidOperationException e) {
				MessageBox.Show(table + " : " +e.GetType().ToString() + "\n" + e.Message);

				//Une InvalidOperationExcepeiton arrive quand il y a une erreur de connection à la base de donnée
				//Donc on renvoie le message d'ereur approrié
				resultat = REMOTE_CONN_ERROR;
                MessageBox.Show(table + " : " +"invalidopeexcep");
            } catch (OleDbException e) {
                MessageBox.Show(table + " : " +e.GetType().ToString() + "\n" + e.Message);
                resultat = REMOTE_SQL_ERROR;
            } finally {
                if(connec.State == ConnectionState.Open)
                    connec.Close();
            }

            return resultat;
        }


        //Methodes de suppression de lignes :

        public static int removeLine(String table, String kname1, object val1){
            return removeLine(table, kname1, null, val1, null);//Juste une simplicité d'écriture
        }

        public static int removeLine(String table, String kname1, String kname2, object val1, object val2){
            if(connec == null || ds == null)//on vérifie que le dataset et la connection sont initialisés
                throw new InvalidOperationException("Classe BDDUtil incorrectement initialisée");
            
            int retLoc = removeLineLoc(table, kname1, kname2, val1, val2);//Modification en local
            int remLoc = removeLineRem(table, kname1, kname2, val1, val2);//Modification à distance
            return retLoc | remLoc;
        }

        private static int removeLineLoc(String table, String kname1, String kname2, object val1, object val2){
            
            DataRowCollection rows = ds.Tables[table].Rows;

            try{
                for (int i = rows.Count - 1; i >= 0; i--){
                    //Si la première condition est vérifiée :
                    if(rows[i][kname1].Equals(val1)){
                        //On vérifie s'il y en a une 2ème
                        if(kname2 != null){
                            //Si c'est le cas on vérifie qu'elle est vraie
                            if(rows[i][kname2].Equals(val2)){
                                rows.RemoveAt(i);
                            }
                            
                        } else {//S'il n'y a qu'une seule condition, et qu'elle est vérifiée :
                            rows.RemoveAt(i);
                        }
                    }
                }

            } catch {
                return LOCAL_ERROR;
            }

            return LOCAL_SUCCES;

        }

        private static int removeLineRem(String table, String kname1, String kname2, object val1, object val2){
            //On utilise une variable pour ne pas quitter au beau milieu des blocs catch
            int resultat = REMOTE_SUCCES;

            try {
                connec.Open();

                OleDbCommand comm = connec.CreateCommand();
                //pas besoin d'indiquer le type par défaut puisque c'est text et c'est ce qu'on veut
                
                StringBuilder builder = new StringBuilder();
                builder
                .Append("DELETE FROM [").Append(table).Append("] WHERE ")//On prépare le debut de la commande
                .Append(kname1);
                
                if(val1 == null){
                        //Si la valeur est nulle, on le met comme tel
                    builder.Append(" IS NULL");
                } else if(val1.GetType().Equals(typeof(DateTime))){
                    //La date parce qu'il faut rajouter des # avant et après
                    DateTime time = (DateTime)val1;
                    builder.Append(" = #"+time.Day+"/"+time.Month+"/"+time.Year + "#");
                } else if(val1.GetType().Equals(typeof(String))){
                    //Les chaines de caractères car elles doivent êtres entre '
                    builder.Append(" = '"+val1.ToString()+"'");
                }else {
                    //Pour le reste des types disponibles (entiers, flottants, etc...)
                    //On les affiches de manière brute
                    builder.Append(" = "+val1.ToString());
                }

                //S'il y a une deuxième clé
                if(kname2 != null){
                    builder.Append(" AND ").Append(kname2);//On rajoute l'opérateur logique
                
                    if(val2 == null){
                        //Si la valeur est nulle, on le met comme tel
                        builder.Append(" IS NULL");
                    } else if(val2.GetType().Equals(typeof(DateTime))){
                        //La date parce qu'il faut rajouter des # avant et après
                        DateTime time = (DateTime)val1;
                        builder.Append(" = #"+time.Day+"/"+time.Month+"/"+time.Year + "#");
                    } else if(val2.GetType().Equals(typeof(String))){
                        //Les chaines de caractères car elles doivent êtres entre '
                        builder.Append(" = '"+val2.ToString()+"'");
                    }else {
                        //Pour le reste des types disponibles (entiers, flottants, etc...)
                        //On les affiches de manière brute
                        builder.Append(" = "+val2.ToString());
                    }
                }

                comm.CommandText = builder.ToString();

                int reqRes = comm.ExecuteNonQuery();
                
                if(reqRes < 0)//S'il y a moins de 0 lignes modifiée, il y a une erreur, si c'est possible
                    resultat = REMOTE_SQL_ERROR;

            } catch (InvalidOperationException e) {
				MessageBox.Show(table + " : " +e.GetType().ToString() + "\n" + e.Message);

				//Une InvalidOperationExcepeiton arrive quand il y a une erreur de connection à la base de donnée
				//Donc on renvoie le message d'ereur approrié
				resultat = REMOTE_CONN_ERROR;
            } catch (OleDbException e) {
				MessageBox.Show(table + " : " +e.GetType()+"\n"+e.Message);
                resultat = REMOTE_SQL_ERROR;
            } finally {
                if(connec.State == ConnectionState.Open)
                    connec.Close();
            }

            return resultat;
        }

        public static int modifyLine(String table, String keyname, object keyval, Dictionary<String, object> values){
			if (connec == null || ds == null)//on vérifie que le dataset et la connection sont initialisés
				throw new InvalidOperationException("Classe BDDUtil incorrectement initialisée");

			int modLoc = modifyLineLoc(table, keyname, keyval, values);//mofication locale
            return modLoc | modifyLineRem(table, keyname, keyval, values);//mofication a distance, code légèrement un peu plus compact que les précédents semblables
        }

        private static int modifyLineLoc(String table, String keyname, object keyval, Dictionary<String, object> values){
            DataRowCollection collec = ds.Tables[table].Rows;//on récupère la collection    
            try{
                foreach(DataRow row in collec){//Pour chaques lignes
                    if(row[keyname].Equals(keyval)){//Si la clé est bonne
                        foreach(KeyValuePair<String, object> kv in values){
                            row[kv.Key]=kv.Value;//on modifie tout ce qui a une clef dans le dictionnaire
                        }
                    }
                }
            } catch {
                return LOCAL_ERROR;
            }

            return LOCAL_SUCCES;
        }

        private static int modifyLineRem(String table, String keyname, object keyval, Dictionary<String, object> values){
            //On utilise une variable pour ne pas quitter au beau milieu des blocs catch
            int resultat = REMOTE_SUCCES;

            try {
                connec.Open();

                OleDbCommand comm = connec.CreateCommand();
                //pas besoin d'indiquer le type par défaut puisque c'est text et c'est ce qu'on veut
                
                //On crée des StringBuilder pour travailler facilements sur la commande
                StringBuilder commSet = new StringBuilder().Append("UPDATE ["+table+"] SET ");
                

                foreach(KeyValuePair<String, object> kv in values){
                    commSet.Append(kv.Key);
                    String v = objectToStringRep(kv.Value);
                    commSet.Append(v.Equals("NULL") ? " IS " : " = ").Append(v).Append(", ");
                }

                //On vire la dernière virgule et on ferme les paranthèse
                commSet.Remove(commSet.Length -2, 2);
                // commRight.Remove(commRight.Length -2, 2).Append(") ");

                //Et on stocke la commande dans le OleDbCommand
                String condVal = objectToStringRep(keyval);
                comm.CommandText = commSet.ToString() + " WHERE "+keyname+(condVal.Equals("NULL") ? " IS " : " = ")+condVal;

                //Et maintenant qu'on a notre commande on peut l'éxécuter !
                int reqRes = comm.ExecuteNonQuery();
                
                //En théorie une insertion ne modifie qu'une ligne, donc ça renvoie qqch de différent ssi il y a un problème
                if(reqRes != 1)
                    resultat = REMOTE_SQL_ERROR;
            

            } catch (InvalidOperationException e) {
				MessageBox.Show(table + " : " +e.GetType().ToString() + "\n" + e.Message);
				//Une InvalidOperationExcepeiton arrive quand il y a une erreur de connection à la base de donnée
				//Donc on renvoie le message d'ereur approrié
				resultat = REMOTE_CONN_ERROR;
            } catch (OleDbException e) {
				MessageBox.Show(table + " : " +e.GetType()+"\n"+e.Message);
                resultat = REMOTE_SQL_ERROR;
            } finally {
                if(connec.State == ConnectionState.Open)
                    connec.Close();
            }

            return resultat;

        }   


        //Methode utilitaires de gestion d'ajout :

        public static int ajouterTransaction(DateTime dateTransac, String description, float montant, bool recette, bool percu, int codeType, int[] codeBeneficiaires){
            return ajouterTransaction(maxCode("Transaction","codeTransaction")+1, dateTransac,description, montant, recette, percu, codeType, codeBeneficiaires );
        }

        public static int ajouterTransaction(int codeTransaction, DateTime dateTransac, String description,
         float montant, bool recette, bool percu, int codeType, int[] codeBeneficiaires){
			//On ajoute la ligne de la transaction
			MessageBox.Show(ds.Tables["Transaction"].Rows[0]["recetteON"].GetType().ToString());
            int retval = addLine("Transaction",codeTransaction, dateTransac, description, montant, recette, percu, codeType);

			int retAddBenef = 0;
            foreach(int codeBenef in codeBeneficiaires){//On ajoute les bénéficiares
                retAddBenef |= addLine("Beneficiaires", codeTransaction, codeBenef);
            }

			return retval;
        }

        public static int ajouterTypeTransaction(String libelle){
            return addLine("TypeTransaction",maxCode("TypeTransaction","codeType")+1, libelle);
        }

        public static int ajouterPostePonctuel(String libelle, String commentaire, PrelevementControl[] echeances){
            //int codePoste = ds.Tables["Poste"].Rows.Count + 1;
            int codePoste = maxCode("Poste","codePoste")+1;
            //On ajoute le poste
            int retAddPoste = addLine("Poste", codePoste, libelle);
            int retAddPostePonct = addLine("PostePonctuel", codePoste, commentaire);
            //On ajoute le poste ponctuel et les échéances
            int retAddEch = 0;
            foreach(PrelevementControl ctrl in echeances){
                retAddEch |= addLine("Echeances", codePoste, ctrl.DateEcheance, ctrl.SommePrelevee);
            }

            int retval = 0;
            //Si on a une erreur, on marque tout comme erreur pour les échéances
            if((retAddEch & LOCAL_ERROR) == LOCAL_ERROR ){
                retval |= LOCAL_ERROR;
            }
            if((retAddEch & REMOTE_ERROR) == REMOTE_ERROR) {
                retval |= REMOTE_ERROR;
            }
            
            return retAddPoste | retAddPostePonct | retval;
        }

        public static int ajouterPostePeriodique(String libelle, float montant, String codePeriode, int jourDuMois){
            return ajouterPostePeriodique(libelle, montant, (int)ds.Tables["Periodicite"].Select("libPer = '"+codePeriode+"'")[0]["codePer"], jourDuMois);
        }

        public static int ajouterPostePeriodique(String libelle, float montant, int codePeriode, int jourDuMois){
            int codePoste = maxCode("Poste","codePoste")+1;//récupération d'un identifiant
            
            int retAddPoste = addLine("Poste", codePoste, libelle);//Ajout local
            int retAddPostePer = addLine("PostePeriodique", codePoste, montant, codePeriode, jourDuMois);//Ajout distance

            return retAddPoste | retAddPostePer;
        }

        public static int ajouterPosteRevenu(String libelle, float montant, int personne,int date){
            int codePoste = maxCode("Poste","codePoste")+1;

            int retAddPoste = addLine("Poste", codePoste, libelle);
            int retAddPosteRev = addLine("PosteRevenu", codePoste, montant, personne,date);

            return retAddPoste | retAddPosteRev;
        }

        public static int ajouterPersonne(String nomPersonne, String pmPersonne){
			int res = addLine("Personne", maxCode("Personne", "codePersonne") + 1, nomPersonne, pmPersonne, "0000000000");
			MessageBox.Show(""+res+"\n");

			return res;
        }

        public static int supprimerTransaction(int codeTransaction){
            int remBenef = removeLine("Beneficiaires", "codeTransaction", codeTransaction);//On supprime d'abord les bénéficiaires pour ne pas briser les dépendances
            return remBenef | removeLine("Transaction", "codeTransaction", codeTransaction);
        }

        public static int supprimerPoste(int codePoste){
			//On retire dans toutes les tables afin de n'avoir qu'une seule méthode pour tout les types poste
            int remEchea = removeLine("Echeances", "codePoste", codePoste);
            int remPonct = removeLine("PostePonctuel", "codePoste", codePoste);
            int remPerio = removeLine("PostePeriodique", "codePoste", codePoste);
            int remReven = removeLine("PosteRevenu", "codePoste", codePoste);
            int remPoste = removeLine("Poste", "codePoste", codePoste);

            return remEchea | remPonct | remPerio | remReven | remPoste;
        }

        public static int[] getCodeFromNames(String[] nomPrenom){
            List<int> lg = new List<int>(nomPrenom.Length);//On prépare une liste

            foreach(DataRow dr in ds.Tables["Personne"].Rows){//Pour chaques lignes dans personne
                foreach(String nmpm in nomPrenom){//et chaques nomprenom
                    if((dr[1].ToString() + " " + dr[2].ToString()).Equals(nmpm)){
                        lg.Add((int)dr[0]);//on vérifie si ça coincide, si oui on ajoute
                    }
                }
            }

			return lg.ToArray();//et on l'envoie sous forme de tableau

        }

    }

}