using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab._9
{
    public partial class Form1:Form
    {
        public Form1()
        {
            InitializeComponent();
            Axis ox=new Axis();
            ox.Title="Ось Х";
            chart1.ChartAreas[0].AxisX=ox;
            Axis oy=new Axis();
            oy.Title="Ось Y";
            chart1.ChartAreas[0].AxisY=oy;
        }

        private void button1_MouseClick(object sender,MouseEventArgs e)
        {
            try
            {
                int t=(int)numericUpDown1.Value;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[2].Points.Clear();

                double y;
                for(int x=1; x<7; x++)
                {
                    y=x^3+x^4-x^5;
                    chart1.Series[0].Points.AddXY(x,y);
                }
            }
            catch
            {
                MessageBox.Show("Нет фильт.");
            }
        }

        private void button2_MouseClick(object sender,MouseEventArgs e)
        {
            try
            {
                int t=(int)numericUpDown1.Value;

                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[2].Points.Clear();

                double y;
                for (int x=1; x<7; x++)
                {
                    y=x^3+x^4-x^5;
                    chart1.Series[1].Points.AddXY(x,y);
                }
            }
            catch
            {
                MessageBox.Show("Нет фильт.");
            }
        }

        private void button3_Click(object sender,EventArgs e)
        {
            try
            {
                int t=(int)numericUpDown1.Value;
                chart1.Series[2].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[0].Points.Clear();

                double y;
                for(int x=1; x<7; x++)
                {
                    y=x^3+x^4-x^5;
                    chart1.Series[2].Points.AddXY(x,y);
                }
            }
            catch
            {
                MessageBox.Show("Нет фильт.");
            }
        }

        private void numericUpDown1_Click(object sender,EventArgs e)
        {
            int t=(int)numericUpDown1.Value;
            chart1.Series[0].BorderWidth=t;
            chart1.Series[1].BorderWidth=t;
            chart1.Series[2].BorderWidth=t;
        }

        private void numericUpDown2_Click(object sender,EventArgs e)
        {
            int t=(int)numericUpDown2.Value;
            chart1.ChartAreas[0].AxisX.LineWidth=t;
            chart1.ChartAreas[0].AxisY.LineWidth=t;
        }

        private void checkBox3_CheckedChanged(object sender,EventArgs e)
        {
            if(checkBox3.Checked)
            {
                checkBox4.Checked=false;
                checkBox5.Checked=false;
                chart1.Series[0].Color=Color.Blue;
                chart1.Series[1].Color=Color.Blue;
                chart1.Series[2].Color=Color.Blue;
            }
        }

        private void checkBox4_CheckedChanged(object sender,EventArgs e)
        {
            if(checkBox4.Checked)
            {
                checkBox3.Checked=false;
                checkBox5.Checked=false;
                chart1.Series[0].Color=Color.Green;
                chart1.Series[1].Color=Color.Green;
                chart1.Series[2].Color=Color.Green;
            }
        }

        private void checkBox5_CheckedChanged(object sender,EventArgs e)
        {
            if(checkBox5.Checked)
            {
                checkBox4.Checked=false;
                checkBox3.Checked=false;
                chart1.Series[0].Color=Color.Orange;
                chart1.Series[1].Color=Color.Orange;
                chart1.Series[2].Color=Color.Orange;
            }
        }
    }
}
