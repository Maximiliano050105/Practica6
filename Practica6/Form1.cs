using System.Diagnostics.Eventing.Reader;

namespace Practica6
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

        private void button1_Click(object sender, EventArgs e)
        {
           A=int.Parse(textbox1.Text);
            B = int.Parse(textbox2.Text);
            C = int.Parse(textbox3.Text);
            if (A > B)
                if (B > C)
                    if (B > C)
                    {
                        textBox4.Text = A.ToString();
                        textBox5.Text = B.ToString();
                        textBox6.Text = C.ToString();
                    }
            else { textBox4.Text = A.ToString();
                        textBox5.Text = C.ToString();
                        textBox6.Text = B.ToString();
                           }
            else
                    if (B>C)
                    if (A>C)
                    { textBox4.Text=B.ToString();
                    textBox5.Text=A.ToString();
                    textBox6.Text=C.ToString();
                    }
            else
                    { textBox4.Text = B.ToString();
                        textBox5.Text = C.ToString();
                        textBox6.Text = A.ToString();
                    }
            else
                { textBox4.Text = C.ToString();
                    textBox5.Text = B.ToString();
                    textBox6.Text = A.ToString();
                }
                            

            

                    }

        }
        }
}
