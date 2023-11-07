namespace Kalkulator
{
    public partial class Kalkulator : Form
    {
        int nilai1;
        int nilai2;
        double hasil = 0;
        string tanda;
        public Kalkulator()
        {
            InitializeComponent();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
            label2.Text = label2.Text + "1";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
            label2.Text = label2.Text + "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
            label2.Text = label2.Text + "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
            label2.Text = label2.Text + "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
            label2.Text = label2.Text + "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
            label2.Text = label2.Text + "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
            label2.Text = label2.Text + "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
            label2.Text = label2.Text + "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
            label2.Text = label2.Text + "9";
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
            label2.Text = label2.Text + "0";
        }

        private void button_decimal_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
            label2.Text = label2.Text + ".";
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            label2.Text = "";
            hasil = 0;
        }

        private void button_divided_Click(object sender, EventArgs e)
        {
            nilai1 = Convert.ToInt32(label2.Text);
            if (hasil != 0)
            {
                if (tanda == "+")
                {
                    hasil = hasil + nilai1;
                }
                else if (tanda == "-")
                {
                    hasil = hasil - nilai1;
                }
                else if (tanda == "*")
                {
                    hasil = hasil * nilai1;
                }
                else if (tanda == "/")
                {
                    hasil = hasil / nilai1;
                }
            }
            else
            {
                hasil = nilai1;
            }
            tanda = "/";
            textBox1.Text = textBox1.Text + "/";
            //label1.Text = textBox1.Text + tanda;
            label2.Text = "";
        }

        private void button_multiplied_Click(object sender, EventArgs e)
        {
            nilai1 = Convert.ToInt32(label2.Text);
            if (hasil != 0)
            {
                if (tanda == "+")
                {
                    hasil = hasil + nilai1;
                }
                else if (tanda == "-")
                {
                    hasil = hasil - nilai1;
                }
                else if (tanda == "*")
                {
                    hasil = hasil * nilai1;
                }
                else if (tanda == "/")
                {
                    hasil = hasil / nilai1;
                }
            }
            else
            {
                hasil = nilai1;
            }
            tanda = "*";
            textBox1.Text = textBox1.Text + "*";
            //label1.Text = textBox1.Text + tanda;
            label2.Text = "";
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            nilai1 = Convert.ToInt32(label2.Text);
            if (hasil != 0)
            {
                if (tanda == "+")
                {
                    hasil = hasil + nilai1;
                }
                else if (tanda == "-")
                {
                    hasil = hasil - nilai1;
                }
                else if (tanda == "*")
                {
                    hasil = hasil * nilai1;
                }
                else if (tanda == "/")
                {
                    hasil = hasil / nilai1;
                }
            }
            else
            {
                hasil = nilai1;
            }
            tanda = "-";
            textBox1.Text = textBox1.Text + "-";
            //label1.Text = textBox1.Text + tanda;
            label2.Text = "";
        }
        private void button_added_Click(object sender, EventArgs e)
        {
            nilai1 = Convert.ToInt32(label2.Text);
            if (hasil != 0)
            {
                if (tanda == "+")
                {
                    hasil = hasil + nilai1; 
                }
                else if (tanda == "-")
                {
                    hasil = hasil - nilai1;
                }
                else if (tanda == "*")
                {
                    hasil = hasil * nilai1;
                }
                else if (tanda == "/")
                {
                    hasil = hasil / nilai1;
                }
            }
            else
            {
                hasil = nilai1;
            }
            tanda = "+";
            textBox1.Text = textBox1.Text + "+";
            //label1.Text = textBox1.Text + tanda;
            label2.Text = "";
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            nilai2 = Convert.ToInt32(label2.Text);
            label1.Text = textBox1.Text;
            if (tanda == "+")
            {
                hasil = hasil + nilai2;
                textBox1.Text = Convert.ToString(hasil);
            }
            else if (tanda == "-")
            {
                hasil = hasil - nilai2;
                textBox1.Text = Convert.ToString(hasil);
            }
            else if (tanda == "*")
            {
                hasil = hasil * nilai2;
                textBox1.Text = Convert.ToString(hasil);
            }
            else if (tanda == "/")
            {
                hasil = hasil / nilai2;
                textBox1.Text = Convert.ToString(hasil);
            }
            label2.Text = Convert.ToString(hasil);
            hasil = 0;
        }
    }
}