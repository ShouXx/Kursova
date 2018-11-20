﻿using System;
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
			if (cell.Count == 0)
			{
				MessageBox.Show("Не вибрані дані для видалення", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
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
			FormAbout formAbout = new FormAbout();
			formAbout.ShowDialog();
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
			if (cell.Count == 0)
			{
				MessageBox.Show("Не вибрані дані для редагування", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				FormEdit form = new FormEdit(cell[0], this);
				form.ShowDialog();
				RefreshData();
			}
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

		private void forModelToolStripMenuItem_Click(object sender, EventArgs e)
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

		private void forOperatorToolStripMenuItem_Click(object sender, EventArgs e)
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

		private void forDistanceToolStripMenuItem_Click(object sender, EventArgs e)
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

		private void forHeightToolStripMenuItem_Click(object sender, EventArgs e)
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

		private void forSpeedToolStripMenuItem_Click(object sender, EventArgs e)
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

		private void forStatusToolStripMenuItem_Click(object sender, EventArgs e)
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

		private void clearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			drones.Clear();
			RefreshData();
		}

		private void function_2_ToolStripMenuItem_Click(object sender, EventArgs e)
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

		private void function_3_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RefreshData();

			int i = 0;
			keyHeight = false;
			forHeightToolStripMenuItem_Click(sender, e);
			while (i < dataGridView1.RowCount)
			{
				while (i == 0)
				{
					double d = 1 - Convert.ToDouble(dataGridView1.Rows[i + 1].Cells[4].Value) / Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
					if (d > 0.07359)
						dataGridView1.Rows.RemoveAt(i);
					else
						++i;
				}
				if (i == dataGridView1.RowCount - 1)
				{
					double d = 1 - Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value) / Convert.ToDouble(dataGridView1.Rows[i - 1].Cells[4].Value);

					if (d > 0.07359)
						dataGridView1.Rows.RemoveAt(i);
					else
						++i;
				}
				else
				{
					double db = 1 - Convert.ToDouble(dataGridView1.Rows[i + 1].Cells[4].Value) / Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
					double dl = 1 - Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value) / Convert.ToDouble(dataGridView1.Rows[i - 1].Cells[4].Value);

					if (db > 0.07359 && dl > 0.07359)
						dataGridView1.Rows.RemoveAt(i);
					else
						++i;
				}
			}
		}

		private void function_4_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormAvgDistance formAvg = new FormAvgDistance(this);
			formAvg.ShowDialog();
		}

		private void function_5_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < dataGridView1.RowCount - 1; ++i)
			{
				int best = i;
				if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "Успішне повернення")
				{
					double bestValue = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value) +
									   Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value) +
									   Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
					for (int j = i + 1; j < dataGridView1.RowCount; ++j)
					{
						if (dataGridView1.Rows[best].Cells[1].Value.ToString() == dataGridView1.Rows[j].Cells[1].Value.ToString())
						{
							if (dataGridView1.Rows[j].Cells[6].Value.ToString() == "Успішне повернення")
							{
								double value = Convert.ToDouble(dataGridView1.Rows[j].Cells[3].Value) +
											   Convert.ToDouble(dataGridView1.Rows[j].Cells[4].Value) +
											   Convert.ToDouble(dataGridView1.Rows[j].Cells[5].Value);
								if (value > bestValue)
								{
									dataGridView1.Rows.RemoveAt(best);
									--j;
									if (i == best)
										--i;
									best = j;
									bestValue = value;
								}
								else
								{
									dataGridView1.Rows.RemoveAt(j);
									--j;
								}
							}
							else
							{
								dataGridView1.Rows.RemoveAt(j);
								--j;
							}
						}

					}

				}
				else
				{
					dataGridView1.Rows.RemoveAt(i);
					--i;
				}
			}

			if (dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[6].Value.ToString() != "Успішне повернення")
				dataGridView1.Rows.RemoveAt(dataGridView1.RowCount - 1);
		}

		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormHelp formHelp = new FormHelp();
			formHelp.ShowDialog();
		}
	}
}
