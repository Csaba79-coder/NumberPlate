using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberPlate
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string fileName = "numberplates.txt";

            if (textBoxNameOfOwner.Text != "" && textBoxNumberPlate.Text != "" && textBoxTypeOfCar.Text != "" && 
                numericUpDownYearOfProd.Value >= 1900 && numericUpDownYearOfProd.Value <= 2022)
            {
                StreamWriter writer = new StreamWriter(fileName, true);
                writer.WriteLine(textBoxNumberPlate.Text);
                writer.WriteLine(textBoxTypeOfCar.Text);
                writer.WriteLine(textBoxNameOfOwner.Text);
                writer.WriteLine(numericUpDownYearOfProd.Value);
                writer.WriteLine(dateTimePickerMOTTestValidity.Value);
                writer.WriteLine(checkBoxDiesel.Checked);
                writer.Close();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("There is not all data fulfilled!");
            }
        }
    }
}
