using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAD_Money
{
    public partial class frmEcheance : Form
    {
        private DataRow r;
        private DataSet ds;
        public frmEcheance(DataRow row, DataSet d)
        {
            InitializeComponent();
            r = row;
            ds = d;
        }

        private void frmEcheance_Load(object sender, EventArgs e)
        {
            lblPoste.Text = "Numero du poste : " + r["Poste"];
            lblAchat.Text = "Achat : " + r["Description"];
            foreach(DataRow row in ds.Tables["Echeances"].Rows)
            {
                if(int.Parse(row["codePoste"].ToString()) == int.Parse(r["Poste"].ToString()))
                {
                    Label lbl = new Label();
                    lbl.Text = "Echeance prévue au : " + row["datePrelevt"] + " Montant : " + row["montantEcheance"] + "€";
                    lbl.AutoSize = true;
                    flpEcheance.Controls.Add(lbl);
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
