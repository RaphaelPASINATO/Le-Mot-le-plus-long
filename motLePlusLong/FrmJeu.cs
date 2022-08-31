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
using Dictionnaire;
namespace motLePlusLong
{
    public partial class FrmJeu : Form
    {
        int cpt = 3;
        string difficulte;
        string dictionnaireChoisi;
        string leMotCorrect;
        string leMotEnMinuscules;
        Arbre unArbre;
        List<string> lesMotsPossibles;
        public FrmJeu(string diff, string dico)
        {
            InitializeComponent();
            difficulte = diff;
            LblDifficulté.Text = difficulte;
            setDifficulte();
            dictionnaireChoisi = dico;
            labelDico.Text = dictionnaireChoisi;
            lblNbreEssaisRestants.Text = "Nombre d'essais restants : " + cpt;


            int compteurMot = 0;
            var reader = new StreamReader(File.OpenRead("../../dictionnaire/pays.csv"));
            switch (dictionnaireChoisi) {
                case "Pokémon":
                    reader = new StreamReader(File.OpenRead("../../dictionnaire/pokemon.csv"));

                    break;
                case "Pays":
                    reader = new StreamReader(File.OpenRead("../../dictionnaire/pays.csv"));
                    break;
                case "Objets":
                    reader = new StreamReader(File.OpenRead("../../dictionnaire/objets.csv"));
                    break;
            }       
            string unMot;
            List<char> desLettres = new List<char>();
            unArbre = new Arbre();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var valeurs = line.Split(';');

                for (int j = 0; j < valeurs.Count(); j++)
                {
                    compteurMot++;
                    unMot = valeurs[j];
                    if (desLettres.Count() != 0)
                    {
                        desLettres.RemoveRange(0, desLettres.Count() - 1);
                    }
                    for (int k = 0; k < unMot.Length; k++)
                    {
                        desLettres.Add(unMot[k]);
                    }
                    unArbre.ajouterMot(desLettres);

                }
                List<char> lesLettres = new List<char>();
                leMotCorrect = unArbre.getMotAleatoire();
                string word = leMotCorrect;
                word = word.ToUpper();
                for (int i = 0; i < word.Length; i++)
                {
                    lesLettres.Add(word[i]);
                }

                var rnd = new Random();
                var randomized = lesLettres.OrderBy(item => rnd.Next());
                labelMot.Text = "";
                foreach (char c in randomized)
                {
                    
                    labelMot.Text += c + "- ";
                    //if(randomized.Last() == c)
                }

                lesMotsPossibles = unArbre.getLesMotsPossibles(leMotCorrect);
                lesMotsPossibles.Remove(leMotCorrect);


            }

        }

        private void BtnSoumettre_Click(object sender, EventArgs e)
        {
            if (BtnSoumettre.Text ==  "Rejouer une partie")
            {
                LblEtatPartie.Visible = false;
                labelMot.Visible = true;
                txtBoxPropostion.Visible = true;
                BtnAbandon.Text = "Abandonner";
                BtnSoumettre.Text = "Soumettre";
                setDifficulte();
                lblNbreEssaisRestants.Visible = true;
                lblNbreEssaisRestants.Text = "Nombre d'essais restants : " + cpt;
                this.Text = "Partie en cours...";
                List<char> lesLettres = new List<char>();
                leMotCorrect = unArbre.getMotAleatoire();
                string word = leMotCorrect;
                word = word.ToUpper();
                for (int i = 0; i < word.Length; i++)
                {
                    lesLettres.Add(word[i]);
                }

                var rnd = new Random();
                var randomized = lesLettres.OrderBy(item => rnd.Next());
                labelMot.Text = "";
                foreach (char c in randomized)
                {

                    labelMot.Text += c + "- ";
                    //if(randomized.Last() == c)
                }

                if (lesMotsPossibles.Count() != 0)
                {
                    lesMotsPossibles.RemoveRange(0, lesMotsPossibles.Count() - 1);
                }
                lesMotsPossibles = unArbre.getLesMotsPossibles(leMotCorrect);
                lesMotsPossibles.Remove(leMotCorrect);
            }
            else
            {
                cpt--;
                lblNbreEssaisRestants.Text = "Nombre d'essais restants : " + cpt;
                leMotEnMinuscules = txtBoxPropostion.Text.ToLower();
                foreach (string unMot in lesMotsPossibles)
                {
                    if ( unMot == leMotEnMinuscules)
                    {
                        if (unMot.Count() == leMotCorrect.Count())
                        {
                            setEcranVictoire(2);
                        }
                        else
                        {
                            setEcranVictoire(1);
                        }
                    }
                }
                if (leMotEnMinuscules == leMotCorrect)
                {
                    setEcranVictoire(2);
                }
                else
                {                  
                    if (cpt == 0)
                    {
                        setEcranVictoire(3);
                    }
                }
            }
           
        }

        private void BtnAbandon_Click(object sender, EventArgs e)
        {
            if (BtnAbandon.Text == "Retour au menu")
            {
                System.Threading.Thread threadMenu = new System.Threading.Thread(new System.Threading.ThreadStart(openFormMenu));
                threadMenu.Start();
                this.Close();
            }
            else
            {
                setEcranVictoire(3);

            }    
        }
        public void openFormMenu()
        {
            Application.Run(new FrmMenu(difficulte,dictionnaireChoisi));
        }
        public void setDifficulte()
        {
            switch (difficulte)
            {
                case "Facile":
                    cpt = 5;
                    break;
                case "Normal":
                    cpt = 3;
                    break;
                case "Difficile":
                    cpt = 1;
                    break;
                default:
                    cpt = 3;
                    break;
            }
        }
        public void setEcranVictoire(int  valeurVictoire)
        {
            LblEtatPartie.Visible = true;
            lblNbreEssaisRestants.Visible = false;

            labelMot.Visible = false;
            txtBoxPropostion.Visible = false;
            BtnAbandon.Text = "Retour au menu";
            BtnSoumettre.Text = "Rejouer une partie";
            switch (valeurVictoire)
            {
                case 1:
                    LblEtatPartie.Text = "Bravo ! Mais le mot le plus long est " + leMotCorrect + " !!!";
                    this.Text = "Victoire";
                    break;
                case 2:
                    LblEtatPartie.Text = "Bravo ! Le mot était bien " + txtBoxPropostion.Text.ToLower() + " !!!";
                    this.Text = "Victoire";
                    break;
                case 3:
                    LblEtatPartie.Text = "Perdu ! Le mot était " + leMotCorrect + " ...";
                    this.Text = "Défaite";
                    break;
            }

            txtBoxPropostion.Clear();



        }
    }
}
