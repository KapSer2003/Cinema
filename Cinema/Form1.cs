using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Data.autoriz == false)
            {
                Autorization au = new Autorization();
                au.ShowDialog();
            }    
            else
                tabControl1.SelectTab(3);

        }

        public void AutorTrue()
        {
            tabControl1.SelectTab(3);
        }
    }
}
