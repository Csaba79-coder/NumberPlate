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
    public partial class Form1 : Form
    {

        List<Register> registers = new List<Register>();

        public Form1()
        {
            InitializeComponent();
            ReadData();
            WriteData();
        }

        private void buttonAddNewItem_Click(object sender, EventArgs e)
        {
            AddForm addFrom = new AddForm();
            addFrom.ShowDialog();

            if (addFrom.DialogResult == DialogResult.OK)
            {
                ReadData();
                WriteData();
            }
        }

        private void WriteData()
        {
            listBoxNumberPlate.Items.Clear();
            foreach(Register reg in registers)
            {
                listBoxNumberPlate.Items.Add(reg.NumberPlate + " " + reg.NameOfOwner);
            }

            /*for (int reg = 0; reg < registers.Count(); reg++)
            {
                listBoxNumberPlate.Items.Add(registers[reg].NameOfOwner + " " + registers[reg].NumberPlate);
            }*/
        }

        private void ReadData()
        {
            string fileName = "numberplates.txt";

            registers.Clear();
            StreamReader reader = new StreamReader(fileName);

            while (!reader.EndOfStream)
            {
                Register reg = new Register();
                reg.NumberPlate = reader.ReadLine();
                reg.Type = reader.ReadLine();
                reg.NameOfOwner = reader.ReadLine();
                reg.YearOfProduction = Convert.ToInt32(reader.ReadLine());
                reg.MotTestValidity = Convert.ToDateTime(reader.ReadLine());
                reg.IsGasoline = Convert.ToBoolean(reader.ReadLine());
                registers.Add(reg);
            }
            reader.Close();
        }

        private void listBoxNumberPlate_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBoxDiesel.Checked = false;

            if (listBoxNumberPlate.SelectedIndex >= 0)
            {
                textBoxNumberPlate.Text = registers[listBoxNumberPlate.SelectedIndex].NumberPlate.ToString();
                textBoxTypeOfCar.Text = registers[listBoxNumberPlate.SelectedIndex].Type.ToString();
                textBoxNameOfOwner.Text = registers[listBoxNumberPlate.SelectedIndex].NameOfOwner.ToString();
                textBoxYearOfProduction.Text = registers[listBoxNumberPlate.SelectedIndex].YearOfProduction.ToString();
                textBoxMOTTestValidity.Text = registers[listBoxNumberPlate.SelectedIndex].MotTestValidity.ToString();

                bool diesel = registers[listBoxNumberPlate.SelectedIndex].IsGasoline;

                if (diesel)
                {
                    checkBoxDiesel.Checked = true;
                }
                else
                {
                    checkBoxDiesel.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("There is no data choosen!");
            }
        } 
    }
}
