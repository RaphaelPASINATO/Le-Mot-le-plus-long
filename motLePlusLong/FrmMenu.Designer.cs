
namespace motLePlusLong
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnPartie = new System.Windows.Forms.Button();
            this.btnDictionnaire = new System.Windows.Forms.Button();
            this.BtnDifficulté = new System.Windows.Forms.Button();
            this.LblMenu = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPartie
            // 
            this.BtnPartie.Location = new System.Drawing.Point(287, 333);
            this.BtnPartie.Name = "BtnPartie";
            this.BtnPartie.Size = new System.Drawing.Size(227, 83);
            this.BtnPartie.TabIndex = 0;
            this.BtnPartie.Text = "Lancer une partie";
            this.BtnPartie.UseVisualStyleBackColor = true;
            this.BtnPartie.Click += new System.EventHandler(this.BtnPartie_Click);
            // 
            // btnDictionnaire
            // 
            this.btnDictionnaire.Location = new System.Drawing.Point(287, 210);
            this.btnDictionnaire.Name = "btnDictionnaire";
            this.btnDictionnaire.Size = new System.Drawing.Size(227, 83);
            this.btnDictionnaire.TabIndex = 1;
            this.btnDictionnaire.Text = "Choisir le dictionnaire";
            this.btnDictionnaire.UseVisualStyleBackColor = true;
            this.btnDictionnaire.Click += new System.EventHandler(this.btnDictionnaire_Click);
            // 
            // BtnDifficulté
            // 
            this.BtnDifficulté.Location = new System.Drawing.Point(287, 88);
            this.BtnDifficulté.Name = "BtnDifficulté";
            this.BtnDifficulté.Size = new System.Drawing.Size(227, 83);
            this.BtnDifficulté.TabIndex = 2;
            this.BtnDifficulté.Text = "Choisir le mode de difficulté";
            this.BtnDifficulté.UseVisualStyleBackColor = true;
            this.BtnDifficulté.Click += new System.EventHandler(this.BtnDifficulté_Click);
            // 
            // LblMenu
            // 
            this.LblMenu.AutoSize = true;
            this.LblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMenu.ForeColor = System.Drawing.Color.Red;
            this.LblMenu.Location = new System.Drawing.Point(258, 30);
            this.LblMenu.Name = "LblMenu";
            this.LblMenu.Size = new System.Drawing.Size(284, 29);
            this.LblMenu.TabIndex = 3;
            this.LblMenu.Text = "Jeu du mot le plus long";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 83);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lancer une partie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnPartie_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(287, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 83);
            this.button3.TabIndex = 2;
            this.button3.Text = "Choisir le mode de difficulté";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnDifficulté_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblMenu);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnDifficulté);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDictionnaire);
            this.Controls.Add(this.BtnPartie);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "FrmMenu";
            this.Text = "Jeu du mot le plus long";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPartie;
        private System.Windows.Forms.Button btnDictionnaire;
        private System.Windows.Forms.Button BtnDifficulté;
        private System.Windows.Forms.Label LblMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

