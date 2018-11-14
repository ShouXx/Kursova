using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
        public List<Drone> drones = new List<Drone>();
        private bool keyModel = false;
        private bool keyOperator = false;
        private bool keyDistance = false;
        private bool keyHeight = false;
        private bool keySpeed = false;
        private bool keyStatus = false;

        public Form1()
        {
            InitializeComponent();
            toolStripComboBoxStatus.SelectedIndex = 0;
        }

        public void RefreshData()
        {
            dataGridView1.RowCount = 0;
            foreach (Drone d in drones)
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
            FormAdd add = new FormAdd(this);
            add.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            using (BinaryWriter writer = new BinaryWriter(File.OpenWrite(saveFileDialog1.FileName)))
            {
                foreach (Drone drone in drones)
                {
                    writer.Write(drone.Model);
                    writer.Write(drone.Operator);
                    writer.Write(drone.Distance);
                    writer.Write(drone.Height);
                    writer.Write(drone.Speed);
                    writer.Write(drone.Status);
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection cell = dataGridView1.SelectedCells;
            if (cell != null)
            {
                drones.RemoveAt(cell[0].RowIndex);
                RefreshData();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 0;
            drones.Clear();
            saveFileDialog1.FileName = "NewDrones";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.FileName == "NewDrones")
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                using (BinaryWriter writer = new BinaryWriter(File.OpenWrite(saveFileDialog1.FileName)))
                {
                    foreach (Drone drone in drones)
                    {
                        writer.Write(drone.Model);
                        writer.Write(drone.Operator);
                        writer.Write(drone.Distance);
                        writer.Write(drone.Height);
                        writer.Write(drone.Speed);
                        writer.Write(drone.Status);
                    }
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            drones.Clear();
            saveFileDialog1.FileName = openFileDialog1.FileName;
            using (BinaryReader reader = new BinaryReader(File.OpenRead(openFileDialog1.FileName)))
            {
                try
                {
                    while (true)
                    {
                        Drone drone = new Drone(reader.ReadString(), reader.ReadString(), reader.ReadDouble(), reader.ReadDouble(), reader.ReadDouble(), reader.ReadString());
                        drones.Add(drone);
                    }
                }
                catch (EndOfStreamException)
                {

                }
            }
            RefreshData();
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            RefreshData();
            toolStripComboBoxStatus.SelectedIndex = 0;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection cell = dataGridView1.SelectedCells;
            FormEdit form = new FormEdit(cell[0], this);
            form.ShowDialog();
            RefreshData();
        }

        private void toolStripComboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBoxStatus.SelectedIndex == 0)
            {
                RefreshData();
            }
            else if (toolStripComboBoxStatus.SelectedIndex == 1)
            {
                RefreshData();
                for (int i = 0; i < dataGridView1.RowCount; ++i)
                {
                    if (dataGridView1.Rows[i].Cells[6].Value.ToString() != "Успішне повернення")
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        --i;
                    }
                }
            }
            else if (toolStripComboBoxStatus.SelectedIndex == 2)
            {
                RefreshData();
                for (int i = 0; i < dataGridView1.RowCount; ++i)
                {
                    if (dataGridView1.Rows[i].Cells[6].Value.ToString() != "Втрачено")
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        --i;
                    }
                }
            }
        }

        private void Swap<T>(IList<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }

        private void заМоделлюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < drones.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < drones.Count; j++)
                {
                    if (keyModel ? drones[j].Model.CompareTo(drones[min].Model) > 0 :
                    drones[min].Model.CompareTo(drones[j].Model) > 0)
                    {
                        min = j;
                    }
                }
                Swap(drones, i, min);
            }
            keyModel = !keyModel;
            RefreshData();
        }

        private void заОператоромToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < drones.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < drones.Count; j++)
                {
                    if (keyOperator ? drones[j].Operator.CompareTo(drones[min].Operator) > 0 :
                    drones[min].Operator.CompareTo(drones[j].Operator) > 0)
                    {
                        min = j;
                    }
                }
                Swap(drones, i, min);
            }
            keyOperator = !keyOperator;
            RefreshData();
        }

        private void заToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < drones.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < drones.Count; j++)
                {
                    if (keyDistance ? drones[j].Distance < drones[min].Distance :
                    drones[j].Distance > drones[min].Distance)
                    {
                        min = j;
                    }
                }
                Swap(drones, i, min);
            }
            keyDistance = !keyDistance;
            RefreshData();
        }

        private void заВисотоюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < drones.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < drones.Count; j++)
                {
                    if (keyHeight ? drones[j].Height < drones[min].Height :
                    drones[j].Height > drones[min].Height)
                    {
                        min = j;
                    }
                }
                Swap(drones, i, min);
            }
            keyHeight = !keyHeight;
            RefreshData();
        }

        private void заШвидкістюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < drones.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < drones.Count; j++)
                {
                    if (keySpeed ? drones[j].Speed < drones[min].Speed :
                    drones[j].Speed > drones[min].Speed)
                    {
                        min = j;
                    }
                }
                Swap(drones, i, min);
            }
            keySpeed = !keySpeed;
            RefreshData();
        }

        private void заСтатусомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < drones.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < drones.Count; j++)
                {
                    if (keyStatus ? drones[j].Status.CompareTo(drones[min].Status) > 0 :
                    drones[min].Status.CompareTo(drones[j].Status) > 0)
                    {
                        min = j;
                    }
                }
                Swap(drones, i, min);
            }
            keyStatus = !keyStatus;
            RefreshData();
        }

        private void очиститиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drones.Clear();
            RefreshData();
        }

        private void успішнеПоверненняТаНайкращаШвидкістьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshData();
            for (int i = 0; i < dataGridView1.RowCount - 1; ++i)
                if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "Втрачено")
                {
                    dataGridView1.Rows.RemoveAt(i);
                    --i;
                }

            for (int i = 0; i < dataGridView1.RowCount - 1; ++i)
                for (int j = i + 1; j < dataGridView1.RowCount; ++j)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == dataGridView1.Rows[j].Cells[1].Value.ToString())
                    {
                        if (Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value) > Convert.ToDouble(dataGridView1.Rows[j].Cells[5].Value))
                        {
                            dataGridView1.Rows.RemoveAt(j);
                            --j;
                        }
                        else
                        {
                            dataGridView1.Rows.RemoveAt(i);
                            --i;
                            break;
                        }
                    }
                }
            dataGridView1.Sort(Column2, ListSortDirection.Ascending);
        }

        private void однаковаВисотаЗВідхиленням7359ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            dataGridView1.Sort(Column4, ListSortDirection.Descending);
            while (i == 0 && dataGridView1.RowCount > 1)
            {
                double max = Convert.ToDouble(dataGridView1.Rows[i + 1].Cells[4].Value) * 0.7359 + Convert.ToDouble(dataGridView1.Rows[i + 1].Cells[4].Value);
                if (Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value) > max)
                    dataGridView1.Rows.RemoveAt(i);
                else
                    ++i;
            }
            for (;i < dataGridView1.RowCount; ++i)
            {
                double min = Convert.ToDouble(dataGridView1.Rows[i - 1].Cells[4].Value) - Convert.ToDouble(dataGridView1.Rows[i - 1].Cells[4].Value) * 0.7359;
                if (Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value) < min)
                {
                    dataGridView1.Rows.RemoveAt(i);
                    --i;
                }
            }
        }

        private void середнійРезультатДистанціяТаСтатусПотраченоToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
