namespace WindowsFormUygulamasıileArabaBilgiFormu_CM
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
            txtMarka = new TextBox();
            btnGoruntule = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtModel = new TextBox();
            txtRenk = new TextBox();
            TxtPencere = new TextBox();
            txtKapi = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(16, 180);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(125, 27);
            txtMarka.TabIndex = 0;
            // 
            // btnGoruntule
            // 
            btnGoruntule.BackColor = SystemColors.Info;
            btnGoruntule.FlatStyle = FlatStyle.Flat;
            btnGoruntule.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGoruntule.Location = new Point(286, 270);
            btnGoruntule.Name = "btnGoruntule";
            btnGoruntule.Size = new Size(152, 58);
            btnGoruntule.TabIndex = 2;
            btnGoruntule.Text = "Goruntule";
            btnGoruntule.UseVisualStyleBackColor = false;
            btnGoruntule.Click += btnGoruntule_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(168, 138);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 3;
            label2.Text = "Model";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 138);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 4;
            label1.Text = "Marka";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(320, 138);
            label3.Name = "label3";
            label3.Size = new Size(59, 28);
            label3.TabIndex = 5;
            label3.Text = "Renk";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(456, 138);
            label4.Name = "label4";
            label4.Size = new Size(148, 28);
            label4.TabIndex = 6;
            label4.Text = "Pencere Sayisi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(610, 138);
            label5.Name = "label5";
            label5.Size = new Size(116, 28);
            label5.TabIndex = 7;
            label5.Text = "Kapi Sayisi";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(168, 180);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(125, 27);
            txtModel.TabIndex = 8;
            // 
            // txtRenk
            // 
            txtRenk.Location = new Point(313, 180);
            txtRenk.Name = "txtRenk";
            txtRenk.Size = new Size(125, 27);
            txtRenk.TabIndex = 9;
            // 
            // TxtPencere
            // 
            TxtPencere.Location = new Point(465, 180);
            TxtPencere.Name = "TxtPencere";
            TxtPencere.Size = new Size(125, 27);
            TxtPencere.TabIndex = 10;
            // 
            // txtKapi
            // 
            txtKapi.Location = new Point(610, 180);
            txtKapi.Name = "txtKapi";
            txtKapi.Size = new Size(125, 27);
            txtKapi.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Tomato;
            label6.Font = new Font("Sitka Display", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = SystemColors.InactiveBorder;
            label6.Location = new Point(260, 32);
            label6.Name = "label6";
            label6.Size = new Size(205, 49);
            label6.TabIndex = 12;
            label6.Text = "ARABABİLGİ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(764, 437);
            Controls.Add(label6);
            Controls.Add(txtKapi);
            Controls.Add(TxtPencere);
            Controls.Add(txtRenk);
            Controls.Add(txtModel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnGoruntule);
            Controls.Add(txtMarka);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMarka;
        private Button btnGoruntule;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtModel;
        private TextBox txtRenk;
        private TextBox TxtPencere;
        private TextBox txtKapi;
        private Label label6;
    }
}
