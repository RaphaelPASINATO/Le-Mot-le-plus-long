
namespace motLePlusLong
{
    partial class FrmDifficulte
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
            this.BtnFacile = new System.Windows.Forms.Button();
            this.BtnNormal = new System.Windows.Forms.Button();
            this.BtnValide = new System.Windows.Forms.Button();
            this.BtnDifficile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnFacile
            // 
            this.BtnFacile.Location = new System.Drawing.Point(309, 43);
            this.BtnFacile.Name = "BtnFacile";
            this.BtnFacile.Size = new System.Drawing.Size(183, 73);
            this.BtnFacile.TabIndex = 6;
            this.BtnFacile.Text = "Facile";
            this.BtnFacile.UseVisualStyleBackColor = true;
            this.BtnFacile.Click += new System.EventHandler(this.BtnFacile_Click);
            // 
            // BtnNormal
            // 
            this.BtnNormal.Location = new System.Drawing.Point(309, 153);
            this.BtnNormal.Name = "BtnNormal";
            this.BtnNormal.Size = new System.Drawing.Size(183, 73);
            this.BtnNormal.TabIndex = 7;
            this.BtnNormal.Text = "Normal";
            this.BtnNormal.UseVisualStyleBackColor = true;
            this.BtnNormal.Click += new System.EventHandler(this.BtnNormal_Click);
            // 
            // BtnValide
            // 
            this.BtnValide.Location = new System.Drawing.Point(333, 362);
            this.BtnValide.Name = "BtnValide";
            this.BtnValide.Size = new System.Drawing.Size(134, 45);
            this.BtnValide.TabIndex = 8;
            this.BtnValide.Text = "Valider";
            this.BtnValide.UseVisualStyleBackColor = true;
            this.BtnValide.Click += new System.EventHandler(this.BtnValide_Click);
            // 
            // BtnDifficile
            // 
            this.BtnDifficile.Location = new System.Drawing.Point(309, 259);
            this.BtnDifficile.Name = "BtnDifficile";
            this.BtnDifficile.Size = new System.Drawing.Size(183, 73);
            this.BtnDifficile.TabIndex = 9;
            this.BtnDifficile.Text = "Difficile";
            this.BtnDifficile.UseVisualStyleBackColor = true;
            this.BtnDifficile.Click += new System.EventHandler(this.BtnDifficile_Click);
            // 
            // FrmDifficulte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDifficile);
            this.Controls.Add(this.BtnValide);
            this.Controls.Add(this.BtnNormal);
            this.Controls.Add(this.BtnFacile);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "FrmDifficulte";
            this.Text = "Choix de la difficulté";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnFacile;
        private System.Windows.Forms.Button BtnNormal;
        private System.Windows.Forms.Button BtnValide;
        private System.Windows.Forms.Button BtnDifficile;
    }
}