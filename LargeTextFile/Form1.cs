using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace LargeTextFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (StreamReader sr = new StreamReader(@"C:\Users\Al-Amin\Desktop\try.txt"))
            {
                String line;
                // Read and display lines from the file until the end of 
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    var str = System.Text.RegularExpressions.Regex.Replace(line, "(" + Environment.NewLine + ")+", Environment.NewLine);
                    str = str.Substring(1);
                    Console.WriteLine(str);

                    string path = @"C:\Users\Al-Amin\Desktop\copy.txt";
                    var text = str + Environment.NewLine;
                    File.AppendAllText(path, text);
                    string readText = File.ReadAllText(path);
                    Console.WriteLine(readText);




                }
            }
        }
    }
}
