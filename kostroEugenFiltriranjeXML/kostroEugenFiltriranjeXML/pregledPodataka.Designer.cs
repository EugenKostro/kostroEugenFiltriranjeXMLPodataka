
namespace kostroEugenFiltriranjeXML
{
    partial class pregledPodataka
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
            this.btnUcitajDokument = new System.Windows.Forms.Button();
            this.btnFiltriraj2 = new System.Windows.Forms.Button();
            this.btnOdustani2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnUcitajDokument
            // 
            this.btnUcitajDokument.Location = new System.Drawing.Point(12, 12);
            this.btnUcitajDokument.Name = "btnUcitajDokument";
            this.btnUcitajDokument.Size = new System.Drawing.Size(149, 41);
            this.btnUcitajDokument.TabIndex = 0;
            this.btnUcitajDokument.Text = "Učitaj dokument";
            this.btnUcitajDokument.UseVisualStyleBackColor = true;
            this.btnUcitajDokument.Click += new System.EventHandler(this.btnUcitajDokument_Click);
            // 
            // btnFiltriraj2
            // 
            this.btnFiltriraj2.Location = new System.Drawing.Point(199, 12);
            this.btnFiltriraj2.Name = "btnFiltriraj2";
            this.btnFiltriraj2.Size = new System.Drawing.Size(149, 39);
            this.btnFiltriraj2.TabIndex = 1;
            this.btnFiltriraj2.Text = "Filtriraj";
            this.btnFiltriraj2.UseVisualStyleBackColor = true;
            this.btnFiltriraj2.Click += new System.EventHandler(this.btnFiltriraj2_Click);
            // 
            // btnOdustani2
            // 
            this.btnOdustani2.Location = new System.Drawing.Point(386, 12);
            this.btnOdustani2.Name = "btnOdustani2";
            this.btnOdustani2.Size = new System.Drawing.Size(149, 41);
            this.btnOdustani2.TabIndex = 2;
            this.btnOdustani2.Text = "Odustani";
            this.btnOdustani2.UseVisualStyleBackColor = true;
            this.btnOdustani2.Click += new System.EventHandler(this.btnOdustani2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(523, 431);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // pregledPodataka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 503);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnOdustani2);
            this.Controls.Add(this.btnFiltriraj2);
            this.Controls.Add(this.btnUcitajDokument);
            this.Name = "pregledPodataka";
            this.Text = "pregledPodataka";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUcitajDokument;
        private System.Windows.Forms.Button btnFiltriraj2;
        private System.Windows.Forms.Button btnOdustani2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}