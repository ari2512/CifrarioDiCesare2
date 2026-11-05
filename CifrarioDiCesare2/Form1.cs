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
            string fraseChiaro = textBox1.Text;
            string fraseCifrata = "";
            string key =(textBox3.Text);
            if (string.IsNullOrWhiteSpace(fraseChiaro) || (string.IsNullOrWhiteSpace(key)))
            {
                MessageBox.Show("Inserire i parametri necessari");
                return;
            }
            else
            {
                int chiaveNumerica = int.Parse(key);
                for (int i = 0; i < fraseChiaro.Length; i++)
                {
                    char lettera = fraseChiaro[i];

                    char nuovaLettera =(char)(lettera + chiaveNumerica);

                          if ((nuovaLettera > 'Z') || (nuovaLettera >'z' ))
                    {
                        // ESEGUE L'OPERAZIONE SOTTRAENDO IL NUMERO DAL VALORE E NON DAL TESTO IN SE PER SE
                        nuovaLettera = (char)(nuovaLettera - 26);
                    }
                          fraseCifrata = fraseCifrata+(char)nuovaLettera;
                  
                }
                label5.Text = fraseCifrata;   
              


            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int chiaveNumerica = int.Parse(key);
            string fraseDecifrata = "";

            for (int i = 0; i < fraseCifrata.Length; i++)
            {
                char lettera = fraseCifrata[i];

                // 1. Sottrai la chiave invece di sommarla
                char nuovaLettera = (char)(lettera - chiaveNumerica);

                // 2. Se scende sotto la 'A', riportala dentro il range sommano 26
                if (nuovaLettera < 'A')
                {
                    nuovaLettera = (char)(nuovaLettera + 26);
                }

                fraseDecifrata = fraseDecifrata + nuovaLettera;
            }

            label5.Text = fraseDecifrata;
        }
    }
    }

