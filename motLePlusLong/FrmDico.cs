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
    public partial class FrmDico : Form
    {
        string difficulte;
        string dicoChoisi;
        public FrmDico(string diff, string dico)
        {
            InitializeComponent();
            difficulte = diff;
            cboDico.Items.Add("Pays");
            cboDico.Items.Add("Pokémon");
            cboDico.Items.Add("Objets");
            cboDico.SelectedIndex = 0;

            dicoChoisi = dico;
            for (int i = 0; i < cboDico.Items.Count; i++)
            {
                if (dico == cboDico.GetItemText(cboDico.Items[i]))
                {
                    cboDico.SelectedIndex = i;
                }
            }

        }

        private void BtnValide_Click(object sender, EventArgs e)
        {
            dicoChoisi = cboDico.SelectedItem.ToString();
            
            System.Threading.Thread threadMenu = new System.Threading.Thread(new System.Threading.ThreadStart(openFormMenu));
            threadMenu.Start();
            this.Close();
        }

        public void openFormMenu()
        {
            Application.Run(new FrmMenu(difficulte, dicoChoisi));
        }
    }
}
