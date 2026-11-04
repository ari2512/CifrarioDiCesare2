using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CifrarioDiCesare2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Stringa = textBox1.Text;
            string key = (textBox3.Text);
            if (string.IsNullOrWhiteSpace(Stringa) || (string.IsNullOrWhiteSpace(key)))
            {
                MessageBox.Show("Inserire i parametri necessari");
                return;
            }
            else
            {
                int[] lettere = new int[26]; 
            }


            }
        }
    }

