using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.IO;
using System.Drawing.Printing;

namespace PAD_Money
{

    //Récupéré de StackOverflow puis modifié par Alexandre Meyer
    public class Printer// : Form
    {
        ///Le texte à afficher
        private string textToDisplay;

        ///La police à utiliser
        private Font printFont;
        
        ///La flux de donné sur lequel on lit la chaine de caractère
        private StreamReader streamToPrint;
        
        ///On stock le document pour ne pas avoir à le régénérer à chaque fois
        private PrintDocument doc;
        
        ///mode 1 - Preview, 2 - Print
        private int mode;
       
        
        public Printer(string textToDisplay, Font ft)
        {
            this.printFont = ft;
            this.textToDisplay = textToDisplay;
            PreparePage();
        }

        internal void PreparePage()
        {
            try
            {
                //On crée le flux pour lire le texte
                streamToPrint = new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(textToDisplay)));
                //On crée le document 
                doc = new PrintDocument();
				//On lui passe la methode qui créera le document à proprement parlé
				doc.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);

            }
            catch
            {
                MessageBox.Show("Exception occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void showPreview(){
            var ppd = new PrintPreviewDialog();
            ppd.Document = doc;
            ppd.ShowDialog();
        }

        public void print(){
            doc.Print();
        }


        ///S'occupe de générer la page pour l'impression
        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left * 0.3f;
            float rightMargin = ev.MarginBounds.Right;
            float topMargin = ev.MarginBounds.Top * 0.4f;
            string line = null;

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            float charsPerLine = 1.50f * (rightMargin - leftMargin) / (printFont.GetHeight(ev.Graphics)*0.65f);

            // Print each line of the file.
            while (count < linesPerPage &&
               ((line = streamToPrint.ReadLine()) != null))
            {
                string newLine = null;
                int newLineCounter = 0;
                for (int i = 0; i < line.Length; i++)
                {
                    if (i % (int)charsPerLine == 0)
                    {
                        newLine = line.Substring((int)charsPerLine * newLineCounter, (int)charsPerLine > (line.Length - (int)charsPerLine * newLineCounter) ? (line.Length - (int)charsPerLine * newLineCounter) : (int)charsPerLine); 


                        yPos = topMargin + (count *
                           printFont.GetHeight(ev.Graphics));
                        ev.Graphics.DrawString(newLine, printFont, Brushes.Black,
                           leftMargin, yPos, new StringFormat());

                        count++;
                        newLineCounter++;
                    }

                }
                newLineCounter = 0;
            }

            // If more lines exist, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }

        ~Printer()
        {
            streamToPrint.Close();
        }


        public static Printer createReport(DateTime start, DateTime stop, DataRow[] transactions, Font ft){
            
            float depenses = 0, recettes = 0, aPercevoir = 0, sommeTotale = 0;
            int nbtransac;
            

            StringBuilder builder = new StringBuilder();
            builder.Append("Récapitulatif du ").Append(start).Append(" au ").Append(stop.ToString())
            .Append("\n\n_____________________________________________\n\n")
            .Append("Dépenses : \n\n\n")//En-tête du tableau
            .Append("┌─────────────┬───────────────────────────┬────────────┬────────────┬────────────┬─────────────────┐\n")
            .Append("│ Date de la  │ Description               │ Montant    │ Recette ?  │ Perçu ?    │ Type de dépense │\n")
            .Append("│ transaction │                           │            │            │            │                 │\n");
            
            //       │ dd/mm/yyyy  │ ddddddddddddddddddddddddd │ bbbbbbbbbb │ bbbbbbbbbb │ ccccccccccccccc │
            
            //taille de ligne totale = 82;

            for(nbtransac = 0;  nbtransac < transactions.Length; nbtransac++){
                DataRow row = transactions[nbtransac];
                if(!(bool)row["recetteON"]){
                    depenses += (float)row["montant"];
                } else if((bool)row["percuON"]){
                    recettes += (float)row["montant"];
                } else {
                    aPercevoir += (float)row["montant"];
                }
				DateTime dt = (DateTime)row["dateTransaction"];
                //séparateur + ligne d'information
                builder.Append("├─────────────┼───────────────────────────┼────────────┼────────────┼────────────┼─────────────────┤\n")
                .Append(String.Format("│ {0,2}/{1,2}/{2,4}  │ {3,25} │ {4,10} │ {5,10} │ {6,10} │ {7,15} │\n", dt.Day, dt.Month, dt.Year, row["description"], row["montant"], row["recetteON"], row["percuON"], row["libType"]));

            }

            sommeTotale = recettes - depenses;
            //pied du tableau
            builder.Append("└─────────────┴───────────────────────────┴────────────┴────────────┴────────────┴─────────────────┘\n");

            
            builder
            .Append("\n\n_____________________________________________\n\n")
            .Append("Recette : ").Append(recettes.ToString()).Append("\n\n\n")
            .Append("\n\n_____________________________________________\n\n")
            .Append("Dépenses : ").Append(depenses.ToString()).Append("\n\n\n")
            .Append("\n\n_____________________________________________\n\n")
            .Append("Reste à percevoir : ").Append(aPercevoir.ToString()).Append("\n\n\n")
            .Append("\n\n_____________________________________________\n\n")
            .Append("Somme totale dépensée : ").Append(sommeTotale.ToString()).Append("\n\n\n")
            .Append("\n\n_____________________________________________\n\n")
            .Append("Nombre de transaction : ").Append(nbtransac.ToString()).Append("\n\n\n")
            .Append("\n\n_____________________________________________\n\n");

            return new Printer(builder.ToString(), ft);
        }

        


    }
}