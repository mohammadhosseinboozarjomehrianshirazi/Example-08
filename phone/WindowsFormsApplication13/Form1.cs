using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            phones ph = new phones();
            ph.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_phone ap = new add_phone();
            ap.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update_phone up = new update_phone();
            up.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            delet_phone dp = new delet_phone();
            dp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            search_phone sp = new search_phone();
            sp.Show();
        }
    }
}
