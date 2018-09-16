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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string file = System.IO.Path.GetDirectoryName(Application.ExecutablePath)
                + "\\test.ini";
            IniFile ini = new IniFile(file);
            ini.IniWriteValue("ayarlar", "baslangic", "form1");
            MessageBox.Show("Form1 uygulamanın başlangıç formu olarak ayarlandı");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
