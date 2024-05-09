using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2018_pokusaj_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            // n mora biti 6 (kao u primeru na sajtu) jer ne znam sta bih stavio da oni unesu vise vrednosti u jednom elementu stoga sam stavio 6 textboxa
            int N = int.Parse(textBox7.Text);
            if (N>=5 && N<50)
            {
                int[] a = new int[N];
                // pokusavao sam da namestim da se automatski stavljaju brojevi u niz ali nisam uspeo, a i na google-u pokazuju nesto sto mi je nepoznato. sa obzirom da mislim da mi
                // radimo u konzolnim aplikacijama na takmicenju nisam hteo vise da gubim vreme na textbox pa sam samo manuelno postavio
                a[0] = int.Parse(textBox1.Text);
                a[1] = int.Parse(textBox2.Text);
                a[2] = int.Parse(textBox3.Text);
                a[3] = int.Parse(textBox4.Text);
                a[4] = int.Parse(textBox5.Text);
                a[5] = int.Parse(textBox6.Text);

                int x = int.Parse(textBox8.Text);
                int y = int.Parse(textBox9.Text);
                int z = int.Parse(textBox10.Text);

                if ((x > -50 && x < 50) && (y >= 1 && y <= 10))
                {

                    // 1.1
                    int[] b = new int[N + 1];
                    for(int i=0; i<a.Length; i++)
                    {
                        b[i] = a[i];
                    }
                    b[N] = x;
                    int prethodnavrednost;
                    for (int i = 1; i < b.Length; i++)
                    {
                        if (b[i - 1] > b[i])
                        {
                            prethodnavrednost = b[i - 1];
                            b[i - 1] = b[i];
                            b[i] = prethodnavrednost;
                            i = 1;
                        }
                    }
                    for (int i = 0; i < b.Length; i++)
                    {
                        label7.Text = label7.Text + " " + b[i];
                    }


                    // 1.2
                    int[] c = a;
                    int srednjaVredonst = 0;
                    for(int i=0; i< c.Length; i++)
                    {
                        if (i % 2 == 0)
                        {
                            if (c[i] % 2 != 0)
                            {
                                c[i] = c[i] ^ i;
                            }
                        }
                        srednjaVredonst = srednjaVredonst + c[i];
                    }
                    srednjaVredonst = srednjaVredonst / c.Length;
                    
                    foreach (var number in c)
                    {
                        label8.Text = label8.Text + " " + number; 
                    }
                }
                else
                {
                    label1.Text = "opseg nije dobar";
                }

            }
            else
            {
                label1.Text = "n mora imati vrednost od 5 do 49";
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
