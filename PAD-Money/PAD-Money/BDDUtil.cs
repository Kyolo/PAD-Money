using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        //L'objet connection permettant d'acceder à la bdd
        private static OleDbConnection connec = null;

        //La bdd locale
        private static DataSet ds = null;

        public static void init(OleDbConnection connec, DataSet ds){
            BDDUtil.connec = connec;
            BDDUtil.ds = ds;
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
                nrow.ItemArray[i] = data[i];

            }

            //Et on appel l'autre méthode pour faire le travail
            return addLine(table, nrow);
        }

        public static int addLine(String table, DataRow data){
            //On vérifie que la classe a été initialisée, cad que le DataSet et la Connection sont != null
            if(connec == null || ds == null)
                throw new InvalidOperationException("Classe BDDUtil incorrectement initialisée");
            
            int resLoc = addlineLoc(table, data);
            int resRem = addLineRem(table, data);

            //On "combine" les deux résultats, afin d'avoir toute les message en un
            return resLoc | resRem;
        }

        private static int addlineLoc(String table, DataRow data){
            DataTable tab = ds.Tables[table];

            try{
                tab.Rows.Add(data);
            } catch {
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
                    String d = "";
                    //On gère des types particuliers
                    if(rawdata[i] == null){
                        //Si la valeur est nulle, on le met comme tel
                        d = "NULL";
                    } else if(rawdata[i].GetType().Equals(typeof(DateTime))){
                        //La date parce qu'il faut rajouter des # avant et après
                        DateTime time = (DateTime)rawdata[i];
                        d = "#"+time.Day+"/"+time.Month+"/"+time.Year;
                    } else if(rawdata[i].GetType().Equals(typeof(String))){
                        //Les chaines de caractères car elles doivent êtres entre '
                        d = "'"+rawdata[i].ToString()+"'";
                    }else {
                        //Pour le reste des types disponibles (entiers, flottants, etc...)
                        //On les affiches de manière brute
                        d = rawdata[i].ToString();
                    }

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
            

            } catch (InvalidOperationException) {
                //Une InvalidOperationExcepeiton arrive quand il y a une erreur de connection à la base de donnée
                //Donc on renvoie le message d'ereur approrié
                resultat = REMOTE_CONN_ERROR;
            } catch (OleDbException) {

                resultat = REMOTE_SQL_ERROR;
            } finally {
                if(connec.State == ConnectionState.Open)
                    connec.Close();
            }

            return resultat;
        }


        public static int ajouterTransactionlong(DateTime dateTransac, String description, float montant, bool recette, bool percu, long codeType, long[] codeBeneficiaires){
            return ajouterTransaction(ds.Tables["Transaction"].Rows.Count+1, dateTransac,description, montant, recette, percu, codeType, codeBeneficiaires );
        }

        public static int ajouterTransaction(long codeTransaction, DateTime dateTransac, String description, float montant, bool recette, bool percu, long codeType, long[] codeBeneficiaires){

            int retval = addLine("Transaction",codeTransaction, dateTransac, description, montant, recette, percu);
            
            int retAddBenef = 0;
            foreach(long codeBenef in codeBeneficiaires){
                retAddBenef |= addLine("Beneficiaires", codeTransaction, codeBenef);
            }

            if((retAddBenef & LOCAL_ERROR) == LOCAL_ERROR ){
                retval |= LOCAL_ERROR;
            }
            if((retAddBenef & REMOTE_ERROR) == REMOTE_ERROR) {
                retval |= REMOTE_ERROR;
            }

            return retval;
        }

    }

}