
namespace kostroEugenFiltriranjeXML
{
    partial class prikazForma
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
            this.comboBoxRazred2 = new System.Windows.Forms.ComboBox();
            this.textBoxEmail2 = new System.Windows.Forms.TextBox();
            this.textBoxPrezime2 = new System.Windows.Forms.TextBox();
            this.textBoxIme2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxRazred2
            // 
            this.comboBoxRazred2.FormattingEnabled = true;
            this.comboBoxRazred2.Items.AddRange(new object[] {
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
            this.comboBoxRazred2.Location = new System.Drawing.Point(22, 234);
            this.comboBoxRazred2.Name = "comboBoxRazred2";
            this.comboBoxRazred2.Size = new System.Drawing.Size(121, 23);
            this.comboBoxRazred2.TabIndex = 20;
            // 
            // textBoxEmail2
            // 
            this.textBoxEmail2.Location = new System.Drawing.Point(22, 172);
            this.textBoxEmail2.Name = "textBoxEmail2";
            this.textBoxEmail2.Size = new System.Drawing.Size(267, 23);
            this.textBoxEmail2.TabIndex = 19;
            // 
            // textBoxPrezime2
            // 
            this.textBoxPrezime2.Location = new System.Drawing.Point(22, 108);
            this.textBoxPrezime2.Name = "textBoxPrezime2";
            this.textBoxPrezime2.Size = new System.Drawing.Size(176, 23);
            this.textBoxPrezime2.TabIndex = 18;
            // 
            // textBoxIme2
            // 
            this.textBoxIme2.Location = new System.Drawing.Point(22, 52);
            this.textBoxIme2.Name = "textBoxIme2";
            this.textBoxIme2.Size = new System.Drawing.Size(176, 23);
            this.textBoxIme2.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Razred:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ime:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(86, 386);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(194, 41);
            this.btnOdustani.TabIndex = 12;
            this.btnOdustani.Text = "ODUSTANI";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(86, 323);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(194, 41);
            this.btnFiltriraj.TabIndex = 11;
            this.btnFiltriraj.Text = "FILTRIRAJ";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // prikazForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 450);
            this.Controls.Add(this.comboBoxRazred2);
            this.Controls.Add(this.textBoxEmail2);
            this.Controls.Add(this.textBoxPrezime2);
            this.Controls.Add(this.textBoxIme2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnFiltriraj);
            this.Name = "prikazForma";
            this.Text = "Filtriranje podataka";
            this.Load += new System.EventHandler(this.prikazForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRazred2;
        private System.Windows.Forms.TextBox textBoxEmail2;
        private System.Windows.Forms.TextBox textBoxPrezime2;
        private System.Windows.Forms.TextBox textBoxIme2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnFiltriraj;
    }
}