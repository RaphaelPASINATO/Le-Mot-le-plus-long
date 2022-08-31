using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace motLePlusLong
{
    public partial class FrmMenu : Form
    {
        string difficulte;
        string dictionnaireChoisi;
        public FrmMenu()
        {
            InitializeComponent();
            difficulte = "Normal";
            dictionnaireChoisi = "Pays";
        }


        public FrmMenu(string diff, string dico)
        {
            InitializeComponent();
            difficulte = diff;           
            dictionnaireChoisi = dico;
        }



        private void btnDictionnaire_Click(object sender, EventArgs e)
        {
            //(new FrmDico(difficulte)).ShowDialog();
            System.Threading.Thread threadDiff = new System.Threading.Thread(new System.Threading.ThreadStart(openFormDico));
            threadDiff.Start();
            this.Close();
        }

        public void openFormDico()
        {
            Application.Run(new FrmDico(difficulte, dictionnaireChoisi));
        }

        private void BtnDifficulté_Click(object sender, EventArgs e)
        {

            System.Threading.Thread threadDiff = new System.Threading.Thread(new System.Threading.ThreadStart(openFormDifficulte));
            threadDiff.Start();
            this.Close();

        }

        public void openFormDifficulte()
        {
            //(new FrmDifficulte()).ShowDialog();
            Application.Run(new FrmDifficulte(difficulte, dictionnaireChoisi));
        }

        private void BtnPartie_Click(object sender, EventArgs e)
        {
            //(new FrmJeu(difficulte)).ShowDialog();
            System.Threading.Thread threadJeu = new System.Threading.Thread(new System.Threading.ThreadStart(openFormJeu));
            threadJeu.Start();
            this.Close();
        }

        public void openFormJeu()
        {
            Application.Run(new FrmJeu(difficulte, dictionnaireChoisi));
        }
    }
}
