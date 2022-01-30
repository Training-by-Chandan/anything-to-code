using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BtnTest.Click += BtnTest_Click;
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            //this.richTextBox1.SelectionFont = new Font(this.richTextBox1.Font, FontStyle.Bold | FontStyle.Italic);
            //this.openFileDialog1.ShowDialog();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}