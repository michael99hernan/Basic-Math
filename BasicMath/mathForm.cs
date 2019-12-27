using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace BasicMath
{

    public partial class mathForm : Form
    {
        public int MAX = 100;
        public string symbol;
        private int speed;
        public mathForm(string c, int speed)
        {
            InitializeComponent();
            symbol = c;
            start.Show();
            this.speed = speed;
        }

        public void calculate()
        {
            start.Hide();
            backButton.Hide();
            sign.Text = symbol;
            int result,first,second;
            
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                first = rnd.Next(1, MAX);
                second = rnd.Next(1, MAX);
                this.Update();
                switch (symbol)
                {
                    case "+":

                        result = first + second;
                        break;
                    case "-":
                        if(first<second)
                        {
                            int temp = first;
                            first = second;
                            second = temp;
                        }
                        result = first - second;
                        break;
                    case "*":
                        first = rnd.Next(1, 12);
                        second = rnd.Next(1, 12);
                        result = first * second;
                        break;
                    default:
                        result = 0;
                        break;

                }
                fNum.Text = first.ToString();
                sNum.Text = second.ToString();
                this.Update();
                Thread.Sleep(speed);
                res.Text = result.ToString();
                this.Update();
                Thread.Sleep(1000);
                res.Text = "";
            }
            start.Show();
            backButton.Show();
        }

        private void start_Click(object sender, EventArgs e)
        {
            calculate();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu ss = new Menu();
            ss.Show();
        }
    }
}
