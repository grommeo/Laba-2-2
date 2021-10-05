using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба_2_2_Сsh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.pr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pr;
            pr = Convert.ToString(textBox1.Text);
            var Out = Logic.Doli(pr);
            label4.Text = Out;
            Properties.Settings.Default.pr = pr;
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
    public class Logic
    {
        public static string Doli(string pr)
        {
            float buk = 0, m = 0, dl = 0;
            string Out, a, b, c;
            for (int i = 0; i < pr.Length; i++)
            {
                dl++;
                if ((pr[i] >= 'а' && pr[i] <= 'я') || (pr[i] >= 'А' && pr[i] <= 'Я'))
                    buk++;

            }
            m = buk / dl * 100;
            Out = "Букв: " + buk.ToString() + "\nСимволов: " + dl.ToString() + "\nДоля: " + m.ToString() + "%";
            return (Out);
        }
    }
}
