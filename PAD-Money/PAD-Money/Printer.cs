using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Drawing.Printing;

namespace PAD_Money
{

    //Récupéré de StackOverflow puis modifié par Alexandre Meyer
    public partial class Printer// : Form
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
                streamToPrint = new StreamReader(new MemoryStream(Encoding.ASCII.GetBytes(textToDisplay)));
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
            float leftMargin = ev.MarginBounds.Left;
            float rightMargin = ev.MarginBounds.Right;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            float charsPerLine = (rightMargin - leftMargin) / (printFont.GetHeight(ev.Graphics)*0.65f);

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


        public static Printer createReport(String mois, DataColumn[] transactions, Font ft){
            
            StringBuilder builder = new StringBuilder();
            builder.Append("Récapitulatif du mois : ").Append(mois)
            .Append("\n\n_____________________________________________\n\n")
            .Append("Dépenses : \n\n\n");
            
            //Here goes the transaction
            builder.Append("\n\n_____________________________________________\n\n")
            .Append("Recette :").Append("\n\n\n");

            return null;
        }


    }
}