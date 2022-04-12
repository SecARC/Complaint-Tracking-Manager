using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace week13_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ts_Click(object sender, EventArgs e)
        {
            var tsButtons = sender as ToolStripButton;
            label2.Text = tsButtons.Text;
            calculate();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

            ComplaintRepository cr = new ComplaintRepository();
            Complaint c = new Complaint()
            {
                monthName = label2.Text,
                c1 = Convert.ToInt32(textBox1.Text),
                c2 = Convert.ToInt32(textBox2.Text),
                c3 = Convert.ToInt32(textBox3.Text),
                c4 = Convert.ToInt32(textBox4.Text),
                c5 = Convert.ToInt32(textBox5.Text)
            };
            cr.saveData(c.monthName, c.c1, c.c2, c.c3, c.c3, c.c4, c.c5);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ComplaintRepository cr = new ComplaintRepository();
            //var list = cr.getData($"{label2.Text}.csv");
            var list = cr.getData($"{label2.Text}.csv");
            foreach (var item in list)
            {
                label2.Text = item.monthName;
                textBox1.Text = item.c1.ToString();
                textBox2.Text = item.c2.ToString();
                textBox3.Text = item.c3.ToString();
                textBox4.Text = item.c4.ToString();
                textBox5.Text = item.c5.ToString();
            }
        }

        public void calculate()
        {
            if(!string.IsNullOrEmpty(textBox1.Text) )
            {
                int total;
                int c1 = Convert.ToInt32(textBox1.Text);
                int c2 = Convert.ToInt32(textBox2.Text);
                int c3 = Convert.ToInt32(textBox3.Text);
                int c4 = Convert.ToInt32(textBox4.Text);
                int c5 = Convert.ToInt32(textBox5.Text);
                total = c1 + c2 + c3 + c4 + c5;
                textBox7.Text = total.ToString();
                int c1Percentage = (int)((double)c1 / total * 100);
                int c2Percentage = (int)((double)c2 / total * 100);
                int c3Percentage = (int)((double)c3 / total * 100);
                int c4Percentage = (int)((double)c4 / total * 100);
                int c5Percentage = (int)((double)c5 / total * 100);

                textBox8.Text = $"{c1Percentage}";
                textBox9.Text = $"{c2Percentage}";
                textBox10.Text = $"{c3Percentage}";
                textBox11.Text = $"{c4Percentage}";
                textBox12.Text = $"{c5Percentage}";
                
            }
            else
            {
                MessageBox.Show("Please fill the blanks");
            }
        }
    }
}
