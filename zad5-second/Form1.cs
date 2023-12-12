using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad5_second
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tmrSecundomer_Tick(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString("HH:mm:ss");
            int seconds = int.Parse(txtSeconds.Text);
            int minutes = int.Parse(txtMinutes.Text);

            seconds++;
            if (seconds >= 60)
            {
                minutes++;
                seconds = 0;
            }

            txtSeconds.Text = seconds.ToString();
            txtMinutes.Text = minutes.ToString();

        }
        bool timerStart = false;
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!timerStart)
            {
                tmrSecundomer.Enabled = true;
                timerStart = true;
                btnStart.Text = "Стоп";
            }
            else
            {
                tmrSecundomer.Enabled = false;
                timerStart = false;
                btnStart.Text = "Старт";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMinutes.Text = "0";
            txtSeconds.Text = "0";
            textBox1.Text = " ";
        }

        
    }
}
