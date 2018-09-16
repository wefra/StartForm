using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParser;

namespace WindowsFormsApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string file = System.IO.Path.GetDirectoryName(Application.ExecutablePath)
                + "\\test.ini";
            IniFile ini = new IniFile(file);
            if (File.Exists(file))
            {
                string baslangicFormu = ini.IniReadValue("ayarlar", "baslangic");
                
                if (baslangicFormu == "form2")
                {
                    Application.Run(new Form2());
                }
                else
                {
                    Application.Run(new Form1());
                }
            }
            else
            {
                ini.IniWriteValue("ayarlar", "baslangic", "form1");
                Application.Run(new Form1());
            }
            



            
        }
    }
}
