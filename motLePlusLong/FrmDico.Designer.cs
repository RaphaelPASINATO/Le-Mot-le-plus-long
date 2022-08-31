
namespace motLePlusLong
{
    partial class FrmDico
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
            this.cboDico = new System.Windows.Forms.ComboBox();
            this.BtnValide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboDico
            // 
            this.cboDico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDico.FormattingEnabled = true;
            this.cboDico.IntegralHeight = false;
            this.cboDico.Location = new System.Drawing.Point(287, 153);
            this.cboDico.Name = "cboDico";
            this.cboDico.Size = new System.Drawing.Size(227, 24);
            this.cboDico.TabIndex = 4;
            // 
            // BtnValide
            // 
            this.BtnValide.Location = new System.Drawing.Point(333, 225);
            this.BtnValide.Name = "BtnValide";
            this.BtnValide.Size = new System.Drawing.Size(134, 45);
            this.BtnValide.TabIndex = 5;
            this.BtnValide.Text = "Valider";
            this.BtnValide.UseVisualStyleBackColor = true;
            this.BtnValide.Click += new System.EventHandler(this.BtnValide_Click);
            // 
            // FrmDico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnValide);
            this.Controls.Add(this.cboDico);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "FrmDico";
            this.Text = "Choix du dictionnaire";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboDico;
        private System.Windows.Forms.Button BtnValide;
    }
}