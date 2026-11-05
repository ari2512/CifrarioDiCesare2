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
            string fraseChiaro = textBox1.Text.ToUpper();
            string fraseCifrata = "";
            string key = (textBox3.Text);
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
                    if (lettera != ' ')
                    {
                        char nuovaLettera = (char)(lettera + chiaveNumerica);

                        if ((nuovaLettera > 'Z') || (nuovaLettera > 'z'))
                        {
                            // ESEGUE L'OPERAZIONE SOTTRAENDO IL NUMERO DAL VALORE E NON DAL TESTO IN SE PER SE
                            nuovaLettera = (char)(nuovaLettera - 26);
                        }
                        fraseCifrata = fraseCifrata + (char)nuovaLettera;
                    }
                    else
                    {
                        fraseCifrata = fraseCifrata + ' ';
                    }


                }
                label5.Text = fraseCifrata;



            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Inserire i parametri necessari");
                return;
            }
            string fraseChiaro = textBox1.Text.ToUpper();
            string fraseCifrata = textBox4.Text.ToUpper();
            string key = (textBox2.Text);
            string fraseDecifrata = "";
            int chiaveNumerica = int.Parse(key);
            
            for (int i = 0; i < fraseCifrata.Length; i++)
            {
                char lettera = fraseCifrata[i];
                if (lettera != ' ')
                {
                 

                    if (lettera >= 'A' && lettera <= 'Z')
                    {
                        char nuovaLettera = (char)(lettera - chiaveNumerica);

                        if (nuovaLettera < 'A')
                        {
                            nuovaLettera = (char)(nuovaLettera + 26);
                        }

                        fraseDecifrata = fraseDecifrata + (char)nuovaLettera;
                    }
                    else
                    {
                        fraseDecifrata = fraseDecifrata + (char)lettera;
                    }
                }
                else
                {
                    fraseDecifrata = fraseDecifrata + ' ';
                }

                label2.Text = fraseDecifrata;
            }

        }
    }
}
