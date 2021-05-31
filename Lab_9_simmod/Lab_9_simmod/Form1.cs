using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;

namespace Lab_9_simmod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public void Finder(double a)
        {
            double p1 = Convert.ToDouble(tb_p1);
            double p2 = Convert.ToDouble(tb_p2);
            double p3 = Convert.ToDouble(tb_p3);
            double p4 = Convert.ToDouble(tb_p4);
            double p5 = Convert.ToDouble(tb_p5);

            double[] P = new double[5];
            P[0] = p1;
            P[1] = p2;
            P[2] = p3;
            P[3] = p4;
            P[4] = p5;

            int[] St = new int[5];
            for (int i = 0; i < 5; i++) St[i] = 0;

            for (int i = 0; i < 5; i++)
            {
                if (a < P[i]) St[i]++;
            }
        }

        /*double a = (double)rn.NextDouble();

        double[] A = new double[5];
        string[] phrase = { "Ты уверен, что того стоит?", "Лучшая идея за неделю!", "Я бы на твоем месте не принимал поспешных решений...", "Дерзай!", "Может, лучше передумаешь, пока не поздно?" };
        A[0] = 0.2;
            for (int i = 1; i< 5; i++)
            {
                A[i] = A[i - 1] + 0.2;
            }
            for (int i = 0; i< 5; i++)
            {
                if ((a - A[i]) < 0)
                {
                    l_magicans.Text = phrase[i];
                    break;
                }
            }*/

        private void b_start_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            Random rn = new Random();
           
            int n = Convert.ToInt32(tb_exp.Text);
            double[] Fr = new double[5];
            
            double p1 = Convert.ToDouble(tb_p1.Text);
            double p2 = Convert.ToDouble(tb_p2.Text);
            double p3 = Convert.ToDouble(tb_p3.Text);
            double p4 = Convert.ToDouble(tb_p4.Text);
            double p5 = 1 - p1 - p2 - p3 - p4;
            tb_p5.Text = Convert.ToString(p5);

            double[] P = new double[5];
            P[0] = p1;
            P[1] = p2;
            P[2] = p3;
            P[3] = p4;
            P[4] = p5;
            int[] St = new int[5];
            int i = 0;
            int k = 1;


            while (i < n)
            {
                double a = rn.NextDouble();
                
                k = 0;
                while (true)
                {
                    a = a - P[k];
                    if (a <= 0)
                    {
                        break;
                    }
                    k++;
                }

                St[k]++;
                i++;
            }

            for (int j = 0; j < 5; j++)
            {
                Fr[j] = (double)St[j] / (double)n;
                Console.WriteLine(Fr[j]);
                chart1.Series[0].Points.AddXY(j+1, Fr[j]);
            }
           
        }

        
    }
}
