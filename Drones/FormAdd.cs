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
    public partial class FormAdd : Form
    {
        private Form1 form1;
        
        public FormAdd(Form1 form)
        {
            InitializeComponent();
            form1 = form;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
			if (textBoxModel.Text == "")
			{
				MessageBox.Show("Не заповнене поле Модель", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			string Model = textBoxModel.Text;
			if (textBoxOperator.Text == "")
			{
				MessageBox.Show("Не заповнене поле Оператор", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			string Operator = textBoxOperator.Text;
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
			if (comboBoxStatus.Text == "")
			{
				MessageBox.Show("Не заповнене поле Статус", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			string Status = comboBoxStatus.Text;

            form1.drones.Add(new Drone(Model, Operator, Distance, Height, Speed, Status));
            form1.RefreshData();
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
    }
}
