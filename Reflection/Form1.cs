using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using OdemeUygulamasi.Reflection;

namespace OdemeUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var interfaceType = typeof(IOdemeYontemi);
            var types = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => interfaceType.IsAssignableFrom(t) && t.IsClass)
                .ToList();

            foreach (var type in types)
            {
                comboBox1.Items.Add(type.Name);
            }

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(textBox1.Text, out decimal tutar))
            {
                label1.Text = "Geçersiz tutar!";
                return;
            }

            var secilen = comboBox1.SelectedItem.ToString();
            var type = Assembly.GetExecutingAssembly().GetTypes()
                .FirstOrDefault(t => t.Name == secilen);

            if (type != null)
            {
                IOdemeYontemi odemeNesnesi = (IOdemeYontemi)Activator.CreateInstance(type);
                label1.Text = odemeNesnesi.Ode(tutar);
            }
        }
    }
}

