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
        public Drone Drone { get; set; }
        public bool created = false; 

        public FormAdd()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string Model = textBoxModel.Text;
            string Operator = textBoxOperator.Text;
            double Distance = double.Parse(textBoxDistance.Text);
            double Height = double.Parse(textBoxHeight.Text);
            double Speed = double.Parse(textBoxSpeed.Text);
            string Status = comboBoxStatus.Text;

            Drone = new Drone(Model, Operator, Distance, Height, Speed, Status);

            created = true;

            Close();
        }

        private void textBoxDistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }
    }
}
