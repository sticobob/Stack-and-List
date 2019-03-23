using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> allvalues = new List<int>();
            int n = 50; //Convert.ToInt32(textBox1.Text);
            int n_try = 10000;// Convert.ToInt32(textBox2.Text);
            int seed = 1;// Convert.ToInt32(textBox3.Text);
            for (int j = 0; j < n_try; j++)
            {
                var rnd = new System.Random(seed + j + 1);
                var ml = new Listik<int>(n);
                for (int i = 0; i != n; i++)
                {
                    ml.add(rnd.Next(0, n));
                }
                for (int i = 0; i != n; i++)
                {
                    ml.removeat(rnd.Next(0, ml.size));
                    ml.insert(rnd.Next(0, ml.size), rnd.Next(0, ml.size));
                }
                double rez = (Convert.ToDouble(ml.c1) + 1) / Convert.ToDouble(ml.c2);
                allvalues.Add(Convert.ToInt32(Math.Round(rez)));
            }

            int[] tochart = new int[n];
            for (int i = 0; i < n; i++)
            {
                tochart[i] = 0;
            }
            for (int i = 0; i < n_try; i++)
            {
                ++tochart[allvalues[i]];
            }

            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[0].SetDefault(true);
            this.chart1.Series[0].IsValueShownAsLabel = false;
            this.chart1.ChartAreas[0].AxisX.Minimum = 0;
            this.chart1.ChartAreas[0].AxisX.Maximum = n;

            for (int i = 0; i != n; i++)
            {
                this.chart1.Series[0].Points.AddXY(i, tochart[i]);
            }
        }
    }
}
