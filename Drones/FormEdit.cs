using System;
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
			if (textBoxModel.Text == "")
			{
				MessageBox.Show("Не заповнене поле Модель", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			form.drones[cell.RowIndex].Model = textBoxModel.Text;
			if (textBoxOperator.Text == "")
			{
				MessageBox.Show("Не заповнене поле Оператор", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			form.drones[cell.RowIndex].Operator = textBoxOperator.Text;
			if (textBoxDistance.Text == "")
			{
				MessageBox.Show("Не заповнене поле Дистанція", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (!double.TryParse(textBoxDistance.Text.Replace('.', ','), out double Distance))
			{
				MessageBox.Show("Не правильно заповнене поле Дистанція", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			form.drones[cell.RowIndex].Distance = Distance;
			if (textBoxHeight.Text == "")
			{
				MessageBox.Show("Не заповнене поле Висота", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (!double.TryParse(textBoxHeight.Text.Replace('.', ','), out double Height))
			{
				MessageBox.Show("Не правильно заповнене поле Висота", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			form.drones[cell.RowIndex].Height = Height;
			if (textBoxSpeed.Text == "")
			{
				MessageBox.Show("Не заповнене поле Швидкість", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (!double.TryParse(textBoxSpeed.Text.Replace('.', ','), out double Speed))
			{
				MessageBox.Show("Не правильно заповнене поле Швидкість", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			form.drones[cell.RowIndex].Speed = Speed;
			if (comboBoxStatus.Text == "")
			{
				MessageBox.Show("Не заповнене поле Статус", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			form.drones[cell.RowIndex].Status = comboBoxStatus.Text;
            Close();
        }
    }
}
