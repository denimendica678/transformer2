
namespace transformator2
{
    partial class Unos
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
            this.btnUnosUnosPodataka = new System.Windows.Forms.Button();
            this.btnZavrsiUnosPodataka = new System.Windows.Forms.Button();
            this.txtImeUnosPodataka = new System.Windows.Forms.TextBox();
            this.txtPrezimeUnosPodataka = new System.Windows.Forms.TextBox();
            this.txtEmailUnosPodataka = new System.Windows.Forms.TextBox();
            this.cmbRazredUnosPodataka = new System.Windows.Forms.ComboBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUnosUnosPodataka
            // 
            this.btnUnosUnosPodataka.Location = new System.Drawing.Point(22, 320);
            this.btnUnosUnosPodataka.Name = "btnUnosUnosPodataka";
            this.btnUnosUnosPodataka.Size = new System.Drawing.Size(337, 47);
            this.btnUnosUnosPodataka.TabIndex = 1;
            this.btnUnosUnosPodataka.Text = "Unos";
            this.btnUnosUnosPodataka.UseVisualStyleBackColor = true;
            this.btnUnosUnosPodataka.Click += new System.EventHandler(this.btnUnosUnosPodataka_Click);
            // 
            // btnZavrsiUnosPodataka
            // 
            this.btnZavrsiUnosPodataka.Location = new System.Drawing.Point(22, 373);
            this.btnZavrsiUnosPodataka.Name = "btnZavrsiUnosPodataka";
            this.btnZavrsiUnosPodataka.Size = new System.Drawing.Size(337, 47);
            this.btnZavrsiUnosPodataka.TabIndex = 2;
            this.btnZavrsiUnosPodataka.Text = "Završi";
            this.btnZavrsiUnosPodataka.UseVisualStyleBackColor = true;
            this.btnZavrsiUnosPodataka.Click += new System.EventHandler(this.btnZavrsiUnosPodataka_Click);
            // 
            // txtImeUnosPodataka
            // 
            this.txtImeUnosPodataka.Location = new System.Drawing.Point(22, 67);
            this.txtImeUnosPodataka.Name = "txtImeUnosPodataka";
            this.txtImeUnosPodataka.Size = new System.Drawing.Size(336, 22);
            this.txtImeUnosPodataka.TabIndex = 3;
            // 
            // txtPrezimeUnosPodataka
            // 
            this.txtPrezimeUnosPodataka.Location = new System.Drawing.Point(22, 128);
            this.txtPrezimeUnosPodataka.Name = "txtPrezimeUnosPodataka";
            this.txtPrezimeUnosPodataka.Size = new System.Drawing.Size(336, 22);
            this.txtPrezimeUnosPodataka.TabIndex = 4;
            // 
            // txtEmailUnosPodataka
            // 
            this.txtEmailUnosPodataka.Location = new System.Drawing.Point(22, 190);
            this.txtEmailUnosPodataka.Name = "txtEmailUnosPodataka";
            this.txtEmailUnosPodataka.Size = new System.Drawing.Size(336, 22);
            this.txtEmailUnosPodataka.TabIndex = 5;
            // 
            // cmbRazredUnosPodataka
            // 
            this.cmbRazredUnosPodataka.FormattingEnabled = true;
            this.cmbRazredUnosPodataka.Items.AddRange(new object[] {
            "1.a",
            "1.b",
            "1.c",
            "1.d",
            "2.a",
            "2.b",
            "2.c",
            "2.d",
            "3.a",
            "3.b",
            "3.c",
            "3.d",
            "4.a",
            "4.b",
            "4.c",
            "4.d"});
            this.cmbRazredUnosPodataka.Location = new System.Drawing.Point(22, 252);
            this.cmbRazredUnosPodataka.Name = "cmbRazredUnosPodataka";
            this.cmbRazredUnosPodataka.Size = new System.Drawing.Size(336, 24);
            this.cmbRazredUnosPodataka.TabIndex = 6;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(22, 44);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(30, 17);
            this.lb1.TabIndex = 7;
            this.lb1.Text = "Ime";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(22, 108);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(59, 17);
            this.lb2.TabIndex = 8;
            this.lb2.Text = "Prezime";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(22, 170);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(47, 17);
            this.lb3.TabIndex = 9;
            this.lb3.Text = "E-mail";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(22, 232);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(54, 17);
            this.lb4.TabIndex = 10;
            this.lb4.Text = "Razred";
            // 
            // Unos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 450);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.cmbRazredUnosPodataka);
            this.Controls.Add(this.txtEmailUnosPodataka);
            this.Controls.Add(this.txtPrezimeUnosPodataka);
            this.Controls.Add(this.txtImeUnosPodataka);
            this.Controls.Add(this.btnZavrsiUnosPodataka);
            this.Controls.Add(this.btnUnosUnosPodataka);
            this.Name = "Unos";
            this.Text = "Unos podataka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnosUnosPodataka;
        private System.Windows.Forms.Button btnZavrsiUnosPodataka;
        private System.Windows.Forms.TextBox txtImeUnosPodataka;
        private System.Windows.Forms.TextBox txtPrezimeUnosPodataka;
        private System.Windows.Forms.TextBox txtEmailUnosPodataka;
        private System.Windows.Forms.ComboBox cmbRazredUnosPodataka;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb4;
    }
}