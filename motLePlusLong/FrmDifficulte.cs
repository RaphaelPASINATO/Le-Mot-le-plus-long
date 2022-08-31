using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace motLePlusLong
{
    public partial class FrmDifficulte : Form
    {
        string difficulte;
        string dictionnaireChoisi;
        public FrmDifficulte(string diff, string dico)
        {
            InitializeComponent();
            difficulte = diff;
            dictionnaireChoisi = dico;
          
        }

        private void BtnValide_Click(object sender, EventArgs e)
        {
            System.Threading.Thread threadMenu = new System.Threading.Thread(new System.Threading.ThreadStart(openFormMenu));
            threadMenu.Start();
            this.Close();
        }

        public void openFormMenu()
        {
            //(new FrmDifficulte()).ShowDialog();
            Application.Run(new FrmMenu(difficulte,dictionnaireChoisi));
        }

        private void BtnFacile_Click(object sender, EventArgs e)
        {
            difficulte = BtnFacile.Text;
        }

        private void BtnNormal_Click(object sender, EventArgs e)
        {
            difficulte = BtnNormal.Text;
        }

        private void BtnDifficile_Click(object sender, EventArgs e)
        {
            difficulte = BtnDifficile.Text;
        }
    }
}
