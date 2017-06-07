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
    public class PrelevementControl : FlowLayoutPanel {
        
        private DateTimePicker dtp;
        private int numEcheance;
        private Label lblEcheance;
        private TextBox txtValeur;

        public PrelevementControl(DateTime dt, int num, float moneydef) : base() {
            numEcheance = num;
            
            lblEcheance = new Label();
            lblEcheance.Text = "Échéance n°"+num;
            lblEcheance.Size = new Size(100,23);

            dtp = new DateTimePicker();
            dtp.Value = dt;
            dtp.Size = new Size(150,23);

            txtValeur = new TextBox();
            txtValeur.Text = moneydef.ToString();
            txtValeur.Size = new Size(50,23);
            txtValeur.KeyPress += new KeyPressEventHandler(this.txtKPress);
            
            this.FlowDirection = FlowDirection.LeftToRight;
            this.Controls.Add(lblEcheance);
            this.Controls.Add(dtp);
            this.Controls.Add(txtValeur);
            this.Size = new Size(350, 50);
        }

        public DateTime DateEcheance {
            get {
                return dtp.Value;
            }
        }

        public int NumeroEcheance {
            get {
                return numEcheance;
            }
        }

        public float SommePrelevee {
            get {
                return float.Parse(txtValeur.Text);
            }
        }

        private void txtKPress(object sender, KeyPressEventArgs args){
            TextBox txt = (TextBox)sender;

            if((!(txt.Text.Contains(",")) && args.KeyChar == ',') || char.IsDigit(args.KeyChar) || char.IsControl(args.KeyChar)){
                //S'il n'y a pas encore de ',' on n'empeche pas de le mettre
                //Si c'est un chiffre on le rajoute aussi
                txt.Text += args.KeyChar;
            }

            args.Handled = true;
        }


    }

}