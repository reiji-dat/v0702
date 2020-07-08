using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0702
{
    public partial class Form1 : Form
    {
        int muki = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            muki = 1;
            label1.Top = label1.Top - 10;
            label1.Text = "(      )";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            muki = 2;
            label1.Left = label1.Left + 10;
            label1.Text = "(     ^)";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            muki = 3;
            label1.Top = label1.Top + 10;
            label1.Text = "(^▽^)";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            muki = 4;
            label1.Left = label1.Left - 10;
            label1.Text = "(^     )";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // × MessageBox.Show(こんにちは);

            if (muki == 1)
            {
                muki = 3;
                label1.Text = "(^▽^)";
                MessageBox.Show("ん？あ！こんにちは");
            }
            else if (muki == 2 || muki == 4)
            {
                muki = 3;
                label1.Text = "(^▽^)";
                MessageBox.Show("あ！こんにちは");
            }
            else if (muki == 3)
            {
                muki = 3;
                label1.Text = "(^▽^)";
                MessageBox.Show("こんにちは");
            }
            else
            {
                muki = 3;
                label1.Text = "(^▽^)";
                MessageBox.Show("これは…バグですね");
            }

            /*
            // × MessageBox.Show(100);
            MessageBox.Show(100.ToString());
            MessageBox.Show("" + 100);

            MessageBox.Show(3.14f.ToString());
            MessageBox.Show("" + 3.14f);

            MessageBox.Show((1 + 1).ToString());
            MessageBox.Show("" + (1 + 1));

            MessageBox.Show("1"+"1");
            */
        }
    }
}
