
namespace transformator2.Properties
{
    partial class Pocetna
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
            this.btnUnosTansformer = new System.Windows.Forms.Button();
            this.btnPregledTansformer = new System.Windows.Forms.Button();
            this.pictureBoxtTansformer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxtTansformer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnosTansformer
            // 
            this.btnUnosTansformer.Location = new System.Drawing.Point(26, 316);
            this.btnUnosTansformer.Name = "btnUnosTansformer";
            this.btnUnosTansformer.Size = new System.Drawing.Size(337, 47);
            this.btnUnosTansformer.TabIndex = 0;
            this.btnUnosTansformer.Text = "Unos";
            this.btnUnosTansformer.UseVisualStyleBackColor = true;
            this.btnUnosTansformer.Click += new System.EventHandler(this.btnUnosTansformer_Click);
            // 
            // btnPregledTansformer
            // 
            this.btnPregledTansformer.Location = new System.Drawing.Point(26, 369);
            this.btnPregledTansformer.Name = "btnPregledTansformer";
            this.btnPregledTansformer.Size = new System.Drawing.Size(337, 47);
            this.btnPregledTansformer.TabIndex = 1;
            this.btnPregledTansformer.Text = "Pregled";
            this.btnPregledTansformer.UseVisualStyleBackColor = true;
            this.btnPregledTansformer.Click += new System.EventHandler(this.btnPregledTansformer_Click);
            // 
            // pictureBoxtTansformer
            // 
            this.pictureBoxtTansformer.BackgroundImage = global::transformator2.Properties.Resources.CSV_Transformer_logo;
            this.pictureBoxtTansformer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxtTansformer.Location = new System.Drawing.Point(26, 37);
            this.pictureBoxtTansformer.Name = "pictureBoxtTansformer";
            this.pictureBoxtTansformer.Size = new System.Drawing.Size(337, 238);
            this.pictureBoxtTansformer.TabIndex = 2;
            this.pictureBoxtTansformer.TabStop = false;
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.pictureBoxtTansformer);
            this.Controls.Add(this.btnPregledTansformer);
            this.Controls.Add(this.btnUnosTansformer);
            this.Name = "Pocetna";
            this.Text = "CSV transformer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxtTansformer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnosTansformer;
        private System.Windows.Forms.Button btnPregledTansformer;
        private System.Windows.Forms.PictureBox pictureBoxtTansformer;
    }
}