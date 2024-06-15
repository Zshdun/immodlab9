using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] probT, empericSeries;
        int N; 
        int[] freq;
        Random R = new Random();
        double a;
        double meanEmperic, varianceEmperic, chiSquareEmperic;
        double mean, variance;
        double meanError, varianceError;



        double checkTable = 12.592; // 7 - 1 = 6 => m = 6, alpha = 0.05 => chi(6, 0.05) = 12.592;
        int size = 7;

        private void button1_Click(object sender, EventArgs e)
        {
            probT = new double[size]; 
            empericSeries = new double[size]; 
            freq = new int[size]; 
            N = (int)tbN.Value;

            probT[0] = (double)tbpr1.Value;
            probT[1] = (double)tbpr2.Value;
            probT[2] = (double)tbpr3.Value;
            probT[3] = (double)tbpr4.Value;
            probT[4] = (double)tbpr5.Value;
            probT[5] = (double)tbpr6.Value;
            probT[6] = 1;

            for (int i = 0; i < size - 1; i++)
                probT[6] -= probT[i];

            tbpr7.Text = probT[6].ToString();

            for (int i = 0; i < N; i++)
            {
                a = R.NextDouble();
                double summ = 0;

                for (int k = 0; k < size; k++)
                {
                    summ += probT[k];

                    if (a <= summ)
                    {
                        freq[k]++; 
                        break;
                    }
                }
            }

            n1.Text = freq[0].ToString();
            n2.Text = freq[1].ToString();
            n3.Text = freq[2].ToString();
            n4.Text = freq[3].ToString();
            n5.Text = freq[4].ToString();
            n6.Text = freq[5].ToString();
            n7.Text = freq[6].ToString();

            chart1.Series[0].Points.Clear();

            for (int i = 0; i < size; i++) {
                empericSeries[i] = freq[i] / (double)N; 
                chart1.Series[0].Points.AddXY(i + 1, empericSeries[i]);
            }

            tbprEx1.Text = empericSeries[0].ToString();
            tbprEx2.Text = empericSeries[1].ToString();
            tbprEx3.Text = empericSeries[2].ToString();
            tbprEx4.Text = empericSeries[3].ToString();
            tbprEx5.Text = empericSeries[4].ToString();
            tbprEx6.Text = empericSeries[5].ToString();
            tbprEx7.Text = empericSeries[6].ToString();

            mean = 0;
            for (int i = 0; i < size; i++)
                mean += freq[i] * probT[i]; 

            meanEmperic = 0;
            for (int i = 0; i < size; i++)
                meanEmperic += empericSeries[i] * freq[i]; 

            meanError = Math.Abs(meanEmperic - mean) / Math.Abs(mean); 
            meanErr.Text = meanError.ToString("F2");
           
            variance = 0;
            for (int i = 0; i < size; i++) 
                variance += probT[i] * freq[i] * freq[i]; 
            variance -= mean * mean;

            varianceEmperic = 0;
            for (int i = 0; i < size; i++)
                varianceEmperic += empericSeries[i] * freq[i] * freq[i];
            varianceEmperic -= meanEmperic * meanEmperic; 

            varianceError = Math.Abs(varianceEmperic - variance) / Math.Abs(variance); 
            varErr.Text = varianceError.ToString("F2");

            chiSquareEmperic = 0;
            for (int i = 0; i < size; i++)
                chiSquareEmperic += (freq[i] * freq[i] / (N * probT[i]));
            chiSquareEmperic -= N;
            
            tbMean.Text = meanEmperic.ToString("F4");
            tbVariance.Text = varianceEmperic.ToString("F4");
            tbChiSquare.Text = chiSquareEmperic.ToString("F4");

            checkText.Text = chiSquareEmperic > checkTable ? "False" : "True";
        }
    }
}
