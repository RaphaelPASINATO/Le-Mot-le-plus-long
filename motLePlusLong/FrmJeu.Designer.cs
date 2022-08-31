
namespace motLePlusLong
{
    partial class FrmJeu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSoumettre = new System.Windows.Forms.Button();
            this.BtnAbandon = new System.Windows.Forms.Button();
            this.txtBoxPropostion = new System.Windows.Forms.TextBox();
            this.LblPartie = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.LblDifficulté = new System.Windows.Forms.Label();
            this.Lbl4 = new System.Windows.Forms.Label();
            this.labelDico = new System.Windows.Forms.Label();
            this.labelMot = new System.Windows.Forms.Label();
            this.LblEtatPartie = new System.Windows.Forms.Label();
            this.lblNbreEssaisRestants = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSoumettre
            // 
            this.BtnSoumettre.Location = new System.Drawing.Point(193, 321);
            this.BtnSoumettre.Name = "BtnSoumettre";
            this.BtnSoumettre.Size = new System.Drawing.Size(134, 45);
            this.BtnSoumettre.TabIndex = 9;
            this.BtnSoumettre.Text = "Soumettre";
            this.BtnSoumettre.UseVisualStyleBackColor = true;
            this.BtnSoumettre.Click += new System.EventHandler(this.BtnSoumettre_Click);
            // 
            // BtnAbandon
            // 
            this.BtnAbandon.Location = new System.Drawing.Point(465, 321);
            this.BtnAbandon.Name = "BtnAbandon";
            this.BtnAbandon.Size = new System.Drawing.Size(134, 45);
            this.BtnAbandon.TabIndex = 10;
            this.BtnAbandon.Text = "Abandonner";
            this.BtnAbandon.UseVisualStyleBackColor = true;
            this.BtnAbandon.Click += new System.EventHandler(this.BtnAbandon_Click);
            // 
            // txtBoxPropostion
            // 
            this.txtBoxPropostion.Location = new System.Drawing.Point(277, 265);
            this.txtBoxPropostion.Name = "txtBoxPropostion";
            this.txtBoxPropostion.Size = new System.Drawing.Size(252, 22);
            this.txtBoxPropostion.TabIndex = 11;
            // 
            // LblPartie
            // 
            this.LblPartie.AutoSize = true;
            this.LblPartie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPartie.Location = new System.Drawing.Point(311, 141);
            this.LblPartie.Name = "LblPartie";
            this.LblPartie.Size = new System.Drawing.Size(178, 25);
            this.LblPartie.TabIndex = 12;
            this.LblPartie.Text = "Lettres à utiliser :";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.Location = new System.Drawing.Point(574, 9);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(184, 20);
            this.Lbl2.TabIndex = 13;
            this.Lbl2.Text = "Paramètres de la partie";
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl3.Location = new System.Drawing.Point(573, 57);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(86, 20);
            this.Lbl3.TabIndex = 14;
            this.Lbl3.Text = "Difficulté :";
            // 
            // LblDifficulté
            // 
            this.LblDifficulté.AutoSize = true;
            this.LblDifficulté.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDifficulté.Location = new System.Drawing.Point(708, 57);
            this.LblDifficulté.Name = "LblDifficulté";
            this.LblDifficulté.Size = new System.Drawing.Size(63, 20);
            this.LblDifficulté.TabIndex = 15;
            this.LblDifficulté.Text = "Normal";
            // 
            // Lbl4
            // 
            this.Lbl4.AutoSize = true;
            this.Lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl4.Location = new System.Drawing.Point(574, 105);
            this.Lbl4.Name = "Lbl4";
            this.Lbl4.Size = new System.Drawing.Size(99, 20);
            this.Lbl4.TabIndex = 16;
            this.Lbl4.Text = "Dictionnaire";
            // 
            // labelDico
            // 
            this.labelDico.AutoSize = true;
            this.labelDico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDico.Location = new System.Drawing.Point(708, 105);
            this.labelDico.Name = "labelDico";
            this.labelDico.Size = new System.Drawing.Size(44, 20);
            this.labelDico.TabIndex = 17;
            this.labelDico.Text = "pays";
            // 
            // labelMot
            // 
            this.labelMot.AutoSize = true;
            this.labelMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMot.Location = new System.Drawing.Point(272, 213);
            this.labelMot.Name = "labelMot";
            this.labelMot.Size = new System.Drawing.Size(257, 25);
            this.labelMot.TabIndex = 19;
            this.labelMot.Text = "N - F - E - N - A - I - L - D";
            // 
            // LblEtatPartie
            // 
            this.LblEtatPartie.AutoSize = true;
            this.LblEtatPartie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEtatPartie.ForeColor = System.Drawing.Color.Red;
            this.LblEtatPartie.Location = new System.Drawing.Point(262, 141);
            this.LblEtatPartie.Name = "LblEtatPartie";
            this.LblEtatPartie.Size = new System.Drawing.Size(269, 25);
            this.LblEtatPartie.TabIndex = 20;
            this.LblEtatPartie.Text = "Perdu le mot était Finlande";
            this.LblEtatPartie.Visible = false;
            // 
            // lblNbreEssaisRestants
            // 
            this.lblNbreEssaisRestants.AutoSize = true;
            this.lblNbreEssaisRestants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbreEssaisRestants.Location = new System.Drawing.Point(46, 100);
            this.lblNbreEssaisRestants.Name = "lblNbreEssaisRestants";
            this.lblNbreEssaisRestants.Size = new System.Drawing.Size(0, 25);
            this.lblNbreEssaisRestants.TabIndex = 21;
            // 
            // FrmJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNbreEssaisRestants);
            this.Controls.Add(this.LblEtatPartie);
            this.Controls.Add(this.labelMot);
            this.Controls.Add(this.labelDico);
            this.Controls.Add(this.Lbl4);
            this.Controls.Add(this.LblDifficulté);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.LblPartie);
            this.Controls.Add(this.txtBoxPropostion);
            this.Controls.Add(this.BtnAbandon);
            this.Controls.Add(this.BtnSoumettre);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "FrmJeu";
            this.Text = "Partie en cours...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSoumettre;
        private System.Windows.Forms.Button BtnAbandon;
        private System.Windows.Forms.TextBox txtBoxPropostion;
        private System.Windows.Forms.Label LblPartie;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Label LblDifficulté;
        private System.Windows.Forms.Label Lbl4;
        private System.Windows.Forms.Label labelDico;
        private System.Windows.Forms.Label labelMot;
        private System.Windows.Forms.Label LblEtatPartie;
        private System.Windows.Forms.Label lblNbreEssaisRestants;
    }
}