using System;
using System.Windows.Forms;

namespace wf_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text.Length.ToString();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                Clipboard.SetText(textBox1.Text);
                textBox1.Clear();
            }
            else
            {
                Clipboard.Clear();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                textBox1.Text = Clipboard.GetText();
            }
        }
    }
}
