
namespace transformator2
{
    partial class Pregled
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
            this.btnUcitajDokumentPregledUnosa = new System.Windows.Forms.Button();
            this.btnFiltrirajPregledUnosa = new System.Windows.Forms.Button();
            this.btnOdustaniPregledUnosa = new System.Windows.Forms.Button();
            this.txtUcitajDokumentPregledUnosa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUcitajDokumentPregledUnosa
            // 
            this.btnUcitajDokumentPregledUnosa.Location = new System.Drawing.Point(12, 12);
            this.btnUcitajDokumentPregledUnosa.Name = "btnUcitajDokumentPregledUnosa";
            this.btnUcitajDokumentPregledUnosa.Size = new System.Drawing.Size(118, 37);
            this.btnUcitajDokumentPregledUnosa.TabIndex = 0;
            this.btnUcitajDokumentPregledUnosa.Text = "Učitaj dokument";
            this.btnUcitajDokumentPregledUnosa.UseVisualStyleBackColor = true;
            // 
            // btnFiltrirajPregledUnosa
            // 
            this.btnFiltrirajPregledUnosa.Location = new System.Drawing.Point(136, 12);
            this.btnFiltrirajPregledUnosa.Name = "btnFiltrirajPregledUnosa";
            this.btnFiltrirajPregledUnosa.Size = new System.Drawing.Size(118, 37);
            this.btnFiltrirajPregledUnosa.TabIndex = 1;
            this.btnFiltrirajPregledUnosa.Text = "Filtriraj";
            this.btnFiltrirajPregledUnosa.UseVisualStyleBackColor = true;
            // 
            // btnOdustaniPregledUnosa
            // 
            this.btnOdustaniPregledUnosa.Location = new System.Drawing.Point(260, 12);
            this.btnOdustaniPregledUnosa.Name = "btnOdustaniPregledUnosa";
            this.btnOdustaniPregledUnosa.Size = new System.Drawing.Size(118, 37);
            this.btnOdustaniPregledUnosa.TabIndex = 2;
            this.btnOdustaniPregledUnosa.Text = "Odustani";
            this.btnOdustaniPregledUnosa.UseVisualStyleBackColor = true;
            // 
            // txtUcitajDokumentPregledUnosa
            // 
            this.txtUcitajDokumentPregledUnosa.Location = new System.Drawing.Point(12, 55);
            this.txtUcitajDokumentPregledUnosa.Multiline = true;
            this.txtUcitajDokumentPregledUnosa.Name = "txtUcitajDokumentPregledUnosa";
            this.txtUcitajDokumentPregledUnosa.Size = new System.Drawing.Size(366, 383);
            this.txtUcitajDokumentPregledUnosa.TabIndex = 3;
            // 
            // Pregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 450);
            this.Controls.Add(this.txtUcitajDokumentPregledUnosa);
            this.Controls.Add(this.btnOdustaniPregledUnosa);
            this.Controls.Add(this.btnFiltrirajPregledUnosa);
            this.Controls.Add(this.btnUcitajDokumentPregledUnosa);
            this.Name = "Pregled";
            this.Text = "Pregled unosa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUcitajDokumentPregledUnosa;
        private System.Windows.Forms.Button btnFiltrirajPregledUnosa;
        private System.Windows.Forms.Button btnOdustaniPregledUnosa;
        private System.Windows.Forms.TextBox txtUcitajDokumentPregledUnosa;
    }
}