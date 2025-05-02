namespace KisiselBilgiDogrulama
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.Button btnDogrula;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblBolum;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtBolum = new TextBox();
            btnDogrula = new Button();
            lblSonuc = new Label();
            lblAd = new Label();
            lblSoyad = new Label();
            lblBolum = new Label();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(140, 17);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(200, 27);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(140, 57);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(200, 27);
            txtSoyad.TabIndex = 3;
            // 
            // txtBolum
            // 
            txtBolum.Location = new Point(140, 97);
            txtBolum.Name = "txtBolum";
            txtBolum.Size = new Size(200, 27);
            txtBolum.TabIndex = 5;
            // 
            // btnDogrula
            // 
            btnDogrula.Location = new Point(140, 140);
            btnDogrula.Name = "btnDogrula";
            btnDogrula.Size = new Size(174, 30);
            btnDogrula.TabIndex = 6;
            btnDogrula.Text = "Bilgileri Doğrula";
            btnDogrula.UseVisualStyleBackColor = true;
            btnDogrula.Click += btnDogrula_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblSonuc.Location = new Point(20, 190);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(0, 18);
            lblSonuc.TabIndex = 7;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(20, 20);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(91, 20);
            lblAd.TabIndex = 0;
            lblAd.Text = "Öğrenci Adı:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(20, 60);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(113, 20);
            lblSoyad.TabIndex = 2;
            lblSoyad.Text = "Öğrenci Soyadı:";
            // 
            // lblBolum
            // 
            lblBolum.AutoSize = true;
            lblBolum.Location = new Point(20, 100);
            lblBolum.Name = "lblBolum";
            lblBolum.Size = new Size(119, 20);
            lblBolum.TabIndex = 4;
            lblBolum.Text = "Öğrenci Bölümü:";
            // 
            // Form1
            // 
            ClientSize = new Size(384, 241);
            Controls.Add(lblSonuc);
            Controls.Add(btnDogrula);
            Controls.Add(txtBolum);
            Controls.Add(lblBolum);
            Controls.Add(txtSoyad);
            Controls.Add(lblSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblAd);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Öğrenci Bilgi Doğrulama";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
