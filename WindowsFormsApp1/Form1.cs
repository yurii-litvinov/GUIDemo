using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Color oldColor;

        public Form1()
        {
            InitializeComponent();
        }

        private void OnButton1Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            oldColor = button1.BackColor;
            button1.BackColor = Color.Yellow;
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = oldColor;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
        }
    }
}
