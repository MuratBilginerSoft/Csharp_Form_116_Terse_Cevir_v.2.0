using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Terse_çevir_v2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        string kelime;
       
        

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
            label6.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            int b = 0;
            kelime = textBox1.Text;
            label4.Text = kelime;
            int a = kelime.Length;

            char[] kelime2 = new char[a];
            foreach (char klm in kelime)
            {
                kelime2[b] = klm;
                b++;

            }

            Array.Reverse(kelime2);

            foreach (char item in kelime2)
            {
                label6.Text = label6.Text+ item;
            }
        }
    }
}
