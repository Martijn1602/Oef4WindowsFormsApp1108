using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oef4WindowsFormsApp1108
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMaak_Click(object sender, EventArgs e)
        {
           
            lbNotities.Items.Add( "Notitie" + (lbNotities.Items.Count + 1));
            

        }

        private void btnSchrijfBij_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtbSchrijf.Text))
                return;
            lbNotities.Items[lbNotities.SelectedIndex] = rtbSchrijf.Text;
            rtbSchrijf.Clear();
            rtbSchrijf.Focus();
        }

        private void btnScheur_Click(object sender, EventArgs e)
        {
            if (lbNotities.Items.Count > 0)
                lbNotities.Items.RemoveAt(lbNotities.SelectedIndex);
        }

        private void lbNotities_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbLees.Text = lbNotities.Text;
        }

        private void rtbLees_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLamineer_Click(object sender, EventArgs e)

        {
           string saveText = lbNotities.GetItemText(lbNotities.SelectedItem);
            Lamineer ob = new Lamineer(saveText);
            


        }
    }
}
