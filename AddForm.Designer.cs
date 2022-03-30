
namespace NumberPlate
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNumberPlate = new System.Windows.Forms.TextBox();
            this.textBoxTypeOfCar = new System.Windows.Forms.TextBox();
            this.textBoxNameOfOwner = new System.Windows.Forms.TextBox();
            this.numericUpDownYearOfProd = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerMOTTestValidity = new System.Windows.Forms.DateTimePicker();
            this.checkBoxDiesel = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearOfProd)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNumberPlate
            // 
            this.textBoxNumberPlate.Location = new System.Drawing.Point(82, 50);
            this.textBoxNumberPlate.Name = "textBoxNumberPlate";
            this.textBoxNumberPlate.Size = new System.Drawing.Size(200, 23);
            this.textBoxNumberPlate.TabIndex = 0;
            // 
            // textBoxTypeOfCar
            // 
            this.textBoxTypeOfCar.Location = new System.Drawing.Point(82, 103);
            this.textBoxTypeOfCar.Name = "textBoxTypeOfCar";
            this.textBoxTypeOfCar.Size = new System.Drawing.Size(200, 23);
            this.textBoxTypeOfCar.TabIndex = 1;
            // 
            // textBoxNameOfOwner
            // 
            this.textBoxNameOfOwner.Location = new System.Drawing.Point(82, 157);
            this.textBoxNameOfOwner.Name = "textBoxNameOfOwner";
            this.textBoxNameOfOwner.Size = new System.Drawing.Size(200, 23);
            this.textBoxNameOfOwner.TabIndex = 2;
            // 
            // numericUpDownYearOfProd
            // 
            this.numericUpDownYearOfProd.Location = new System.Drawing.Point(82, 211);
            this.numericUpDownYearOfProd.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numericUpDownYearOfProd.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownYearOfProd.Name = "numericUpDownYearOfProd";
            this.numericUpDownYearOfProd.Size = new System.Drawing.Size(200, 23);
            this.numericUpDownYearOfProd.TabIndex = 3;
            this.numericUpDownYearOfProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownYearOfProd.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // dateTimePickerMOTTestValidity
            // 
            this.dateTimePickerMOTTestValidity.Location = new System.Drawing.Point(82, 269);
            this.dateTimePickerMOTTestValidity.MinDate = new System.DateTime(1905, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerMOTTestValidity.Name = "dateTimePickerMOTTestValidity";
            this.dateTimePickerMOTTestValidity.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerMOTTestValidity.TabIndex = 4;
            // 
            // checkBoxDiesel
            // 
            this.checkBoxDiesel.AutoSize = true;
            this.checkBoxDiesel.Location = new System.Drawing.Point(82, 319);
            this.checkBoxDiesel.Name = "checkBoxDiesel";
            this.checkBoxDiesel.Size = new System.Drawing.Size(57, 19);
            this.checkBoxDiesel.TabIndex = 5;
            this.checkBoxDiesel.Text = "Diesel";
            this.checkBoxDiesel.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(82, 373);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add Item";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number Plate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Type of Car";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name of Owner";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Year of Production";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "MOT Test Validity";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.checkBoxDiesel);
            this.Controls.Add(this.dateTimePickerMOTTestValidity);
            this.Controls.Add(this.numericUpDownYearOfProd);
            this.Controls.Add(this.textBoxNameOfOwner);
            this.Controls.Add(this.textBoxTypeOfCar);
            this.Controls.Add(this.textBoxNumberPlate);
            this.Name = "AddForm";
            this.Text = "AddForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearOfProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumberPlate;
        private System.Windows.Forms.TextBox textBoxTypeOfCar;
        private System.Windows.Forms.TextBox textBoxNameOfOwner;
        private System.Windows.Forms.NumericUpDown numericUpDownYearOfProd;
        private System.Windows.Forms.DateTimePicker dateTimePickerMOTTestValidity;
        private System.Windows.Forms.CheckBox checkBoxDiesel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}