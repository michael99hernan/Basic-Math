using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicMath
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            this.Hide();
            mathForm ss = new mathForm("+",trackBar1.Value);
            ss.Show();
        }

        private void SUB_Click(object sender, EventArgs e)
        {
            this.Hide();
            mathForm ss = new mathForm("-", trackBar1.Value);
            ss.Show();
        }

        private void MULT_Click(object sender, EventArgs e)
        {
            this.Hide();
            mathForm ss = new mathForm("*",trackBar1.Value);
            ss.Show();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {

        }

        private void speedLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
