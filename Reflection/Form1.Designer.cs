
namespace OdemeUygulamasi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button1;
        private Label label1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(30, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 28);
            comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(30, 110);
            button1.Name = "button1";
            button1.Size = new Size(200, 30);
            button1.TabIndex = 2;
            button1.Text = "Ödeme Yap";
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 160);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 3;
            label1.Text = "Sonuç:";
            // 
            // Form1
            // 
            ClientSize = new Size(350, 298);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ödeme Uygulaması";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

