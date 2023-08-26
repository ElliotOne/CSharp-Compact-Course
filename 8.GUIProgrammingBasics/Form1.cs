using System;
using System.Windows.Forms;

namespace _8.GUIProgrammingBasics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int n = Convert.ToInt32(textBox1.Text);

                listBox1.Enabled = true;

                for (int i = 1; i <= n - 2; i++)
                {
                    for (int j = 1; j <= n - 2; j++)
                    {
                        for (int k = 1; k <= n - 2; k++)
                        {
                            if ((i + j + k) == n)
                                listBox1.Items.Add(i.ToString() + " , " + j.ToString() + " , " + k.ToString());
                        }
                    }
                }

                label1.Text = "Number of answers is " + listBox1.Items.Count.ToString() + " .";
            }
            else
            {
                MessageBox.Show("Please enter the number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.Opacity = 0.95;
            label1.Text = "";
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
            label1.Text = "";
        }

        private void pictureBox2_Click(object sender, System.EventArgs e)
        {
            var help = "This program goal is to solve the given equation.\n\n" + "This finds its natural solutions.";
            MessageBox.Show(help, "Help ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
