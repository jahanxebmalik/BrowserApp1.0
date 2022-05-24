using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserApp1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This web browser was created by Jahanzeb Malik");
        }

        private void NavigateToPage()
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavigateToPage();
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)ConsoleKey.Enter)
            {
                NavigateToPage();
            }
        }

        
    }
}