using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drones
{
    public partial class FormAvgDistance : Form
    {
        public FormAvgDistance(Form1 form)
        {
            InitializeComponent();

            double sum = 0;
            double avg;
            foreach (Drone d in form.drones)
                sum += d.Distance;
            avg = Math.Round(sum / form.drones.Count, 2);
            textBox1.Text = avg.ToString();

            foreach (Drone d in form.drones) {
                if (d.Status == "Втрачено")
                {
                    ++dataGridView1.RowCount;
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value = d.Operator;
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[1].Value = d.Status;
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[2].Value = d.Distance;
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[3].Value = Math.Round(Math.Abs(d.Distance / avg -  1 ) * 100, 2).ToString() + "%";
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
