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
    public partial class Form1 : Form
    {
        List<Drone> drone = new List<Drone>();

        public Form1()
        {
            InitializeComponent();
        }

        void RefreshData()
        {
            dataGridView1.RowCount = 0;
            foreach(Drone d in drone)
            {
                ++dataGridView1.RowCount;
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value = dataGridView1.RowCount.ToString();
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[1].Value = d.Model;
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[2].Value = d.Operator;
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[3].Value = d.Distance.ToString();
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[4].Value = d.Height.ToString();
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[5].Value = d.Speed.ToString();
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[6].Value = d.Status;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAdd add = new FormAdd();
            add.ShowDialog();
            if (add.created)
            {
                drone.Add(add.Drone);
                RefreshData();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
