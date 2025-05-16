namespace HastaRandevuSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBrans = new Label();
            cmbBranslar = new ComboBox();
            lblDoktor = new Label();
            cmbDoktorlar = new ComboBox();
            lblTarih = new Label();
            dtpTarih = new DateTimePicker();
            lblSaat = new Label();
            cmbSaatler = new ComboBox();
            lblHastaAdi = new Label();
            txtHastaAdi = new TextBox();
            lblHastaSoyadi = new Label();
            txtHastaSoyadi = new TextBox();
            btnRandevuOlustur = new Button();
            SuspendLayout();
            // 
            // lblBrans
            // 
            lblBrans.AutoSize = true;
            lblBrans.Location = new Point(34, 40);
            lblBrans.Name = "lblBrans";
            lblBrans.Size = new Size(48, 20);
            lblBrans.TabIndex = 12;
            lblBrans.Text = "Branş:";
            // 
            // cmbBranslar
            // 
            cmbBranslar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBranslar.FormattingEnabled = true;
            cmbBranslar.Location = new Point(171, 36);
            cmbBranslar.Margin = new Padding(3, 4, 3, 4);
            cmbBranslar.Name = "cmbBranslar";
            cmbBranslar.Size = new Size(228, 28);
            cmbBranslar.TabIndex = 11;
            // 
            // lblDoktor
            // 
            lblDoktor.AutoSize = true;
            lblDoktor.Location = new Point(34, 93);
            lblDoktor.Name = "lblDoktor";
            lblDoktor.Size = new Size(58, 20);
            lblDoktor.TabIndex = 10;
            lblDoktor.Text = "Doktor:";
            // 
            // cmbDoktorlar
            // 
            cmbDoktorlar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDoktorlar.FormattingEnabled = true;
            cmbDoktorlar.Location = new Point(171, 89);
            cmbDoktorlar.Margin = new Padding(3, 4, 3, 4);
            cmbDoktorlar.Name = "cmbDoktorlar";
            cmbDoktorlar.Size = new Size(228, 28);
            cmbDoktorlar.TabIndex = 9;
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Location = new Point(34, 147);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(43, 20);
            lblTarih.TabIndex = 8;
            lblTarih.Text = "Tarih:";
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(171, 143);
            dtpTarih.Margin = new Padding(3, 4, 3, 4);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(228, 27);
            dtpTarih.TabIndex = 7;
            // 
            // lblSaat
            // 
            lblSaat.AutoSize = true;
            lblSaat.Location = new Point(34, 200);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(41, 20);
            lblSaat.TabIndex = 6;
            lblSaat.Text = "Saat:";
            // 
            // cmbSaatler
            // 
            cmbSaatler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSaatler.FormattingEnabled = true;
            cmbSaatler.Location = new Point(171, 196);
            cmbSaatler.Margin = new Padding(3, 4, 3, 4);
            cmbSaatler.Name = "cmbSaatler";
            cmbSaatler.Size = new Size(228, 28);
            cmbSaatler.TabIndex = 5;
            // 
            // lblHastaAdi
            // 
            lblHastaAdi.AutoSize = true;
            lblHastaAdi.Location = new Point(34, 253);
            lblHastaAdi.Name = "lblHastaAdi";
            lblHastaAdi.Size = new Size(77, 20);
            lblHastaAdi.TabIndex = 4;
            lblHastaAdi.Text = "Hasta Adı:";
            // 
            // txtHastaAdi
            // 
            txtHastaAdi.Location = new Point(171, 249);
            txtHastaAdi.Margin = new Padding(3, 4, 3, 4);
            txtHastaAdi.Name = "txtHastaAdi";
            txtHastaAdi.Size = new Size(228, 27);
            txtHastaAdi.TabIndex = 3;
            // 
            // lblHastaSoyadi
            // 
            lblHastaSoyadi.AutoSize = true;
            lblHastaSoyadi.Location = new Point(34, 307);
            lblHastaSoyadi.Name = "lblHastaSoyadi";
            lblHastaSoyadi.Size = new Size(99, 20);
            lblHastaSoyadi.TabIndex = 2;
            lblHastaSoyadi.Text = "Hasta Soyadı:";
            // 
            // txtHastaSoyadi
            // 
            txtHastaSoyadi.Location = new Point(171, 303);
            txtHastaSoyadi.Margin = new Padding(3, 4, 3, 4);
            txtHastaSoyadi.Name = "txtHastaSoyadi";
            txtHastaSoyadi.Size = new Size(228, 27);
            txtHastaSoyadi.TabIndex = 1;
            // 
            // btnRandevuOlustur
            // 
            btnRandevuOlustur.Location = new Point(171, 360);
            btnRandevuOlustur.Margin = new Padding(3, 4, 3, 4);
            btnRandevuOlustur.Name = "btnRandevuOlustur";
            btnRandevuOlustur.Size = new Size(229, 40);
            btnRandevuOlustur.TabIndex = 0;
            btnRandevuOlustur.Text = "Randevu Oluştur";
            btnRandevuOlustur.UseVisualStyleBackColor = true;
            btnRandevuOlustur.Click += btnRandevuOlustur_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 440);
            Controls.Add(btnRandevuOlustur);
            Controls.Add(txtHastaSoyadi);
            Controls.Add(lblHastaSoyadi);
            Controls.Add(txtHastaAdi);
            Controls.Add(lblHastaAdi);
            Controls.Add(cmbSaatler);
            Controls.Add(lblSaat);
            Controls.Add(dtpTarih);
            Controls.Add(lblTarih);
            Controls.Add(cmbDoktorlar);
            Controls.Add(lblDoktor);
            Controls.Add(cmbBranslar);
            Controls.Add(lblBrans);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Hasta Randevu Sistemi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBrans;
        private System.Windows.Forms.ComboBox cmbBranslar;
        private System.Windows.Forms.Label lblDoktor;
        private System.Windows.Forms.ComboBox cmbDoktorlar;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.ComboBox cmbSaatler;
        private System.Windows.Forms.Label lblHastaAdi;
        private System.Windows.Forms.TextBox txtHastaAdi;
        private System.Windows.Forms.Label lblHastaSoyadi;
        private System.Windows.Forms.TextBox txtHastaSoyadi;
        private System.Windows.Forms.Button btnRandevuOlustur;
    }
}
