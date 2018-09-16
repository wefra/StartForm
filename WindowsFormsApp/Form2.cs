using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string file = System.IO.Path.GetDirectoryName(Application.ExecutablePath)
                + "\\test.ini";
            IniFile ini = new IniFile(file);
            ini.IniWriteValue("ayarlar", "baslangic", "form2");
            MessageBox.Show("Form2 uygulamanın başlangıç formu olarak ayarlandı");
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
