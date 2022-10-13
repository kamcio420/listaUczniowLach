using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listaUczniowLach
{
    public partial class Form1 : Form
    {

        string login, haslo, walidacja;

        string[] odpowiedzi =
                {
                 "mxyxw",
                 "b5nmm",
                 "74853",
                 "cg5dd",
                 "x3deb",
                 "befbd"
                };

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int losowa = r.Next(0, 5);
            pictureBox1.Image = imageList1.Images[losowa];
        }

        public bool sprawdzenieWalidacji(string input)
        {
            for(int i = 0; i < 6; i++)
            {
                if(input == odpowiedzi[i])
                {
                    return true;
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login = textBox1.Text;
            haslo = textBox2.Text;
            walidacja = textBox3.Text;

            bool sprWalidajca = sprawdzenieWalidacji(walidacja);

            if(login == "admin")
            {
                if (haslo == "Qwerty1@34")
                {
                    if (sprWalidajca == true)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Niepoprawna walidacja!");
                    }
                }
                else
                {
                    MessageBox.Show("Niepoprawne haslo!");
                }
            }
            else
            {
                MessageBox.Show("Niepoprawny login!");
            }
            
        }
    }
}
