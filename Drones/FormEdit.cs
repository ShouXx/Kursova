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
    public partial class FormEdit : Form
    {
        private Form1 form;
        private DataGridViewCell cell;

        public FormEdit(DataGridViewCell cell, Form1 form)
        {
            InitializeComponent();

            this.form = form;
            this.cell = cell;

            textBoxModel.Text = form.drones[cell.RowIndex].Model;
            textBoxOperator.Text = form.drones[cell.RowIndex].Operator;
            textBoxDistance.Text = form.drones[cell.RowIndex].Distance.ToString();
            textBoxHeight.Text = form.drones[cell.RowIndex].Height.ToString();
            textBoxSpeed.Text = form.drones[cell.RowIndex].Speed.ToString();
            comboBoxStatus.Text = form.drones[cell.RowIndex].Status;
        }

        private void textBoxDistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            form.drones[cell.RowIndex].Model = textBoxModel.Text;
            form.drones[cell.RowIndex].Operator = textBoxOperator.Text;
            form.drones[cell.RowIndex].Distance = double.Parse(textBoxDistance.Text);
            form.drones[cell.RowIndex].Height = double.Parse(textBoxHeight.Text);
            form.drones[cell.RowIndex].Speed = double.Parse(textBoxSpeed.Text);
            form.drones[cell.RowIndex].Status = comboBoxStatus.Text;
            Close();
        }
    }
}
