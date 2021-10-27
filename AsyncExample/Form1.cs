using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int CountCharacters()
        {
            int count = 0;
            using(StreamReader reader = new StreamReader("C:\Users\mike\Desktop\data.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lblCount.Text = "processing file";

            int count = CountCharacters();
            lblCount.Text = count.ToString() + " characters in file";

            
        }
    }
}
