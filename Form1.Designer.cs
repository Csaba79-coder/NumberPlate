
namespace NumberPlate
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxNumberPlate = new System.Windows.Forms.ListBox();
            this.buttonAddNewItem = new System.Windows.Forms.Button();
            this.textBoxNumberPlate = new System.Windows.Forms.TextBox();
            this.textBoxTypeOfCar = new System.Windows.Forms.TextBox();
            this.textBoxNameOfOwner = new System.Windows.Forms.TextBox();
            this.checkBoxDiesel = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxYearOfProduction = new System.Windows.Forms.TextBox();
            this.textBoxMOTTestValidity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxNumberPlate
            // 
            this.listBoxNumberPlate.FormattingEnabled = true;
            this.listBoxNumberPlate.ItemHeight = 15;
            this.listBoxNumberPlate.Location = new System.Drawing.Point(70, 35);
            this.listBoxNumberPlate.Name = "listBoxNumberPlate";
            this.listBoxNumberPlate.Size = new System.Drawing.Size(228, 274);
            this.listBoxNumberPlate.TabIndex = 0;
            this.listBoxNumberPlate.SelectedIndexChanged += new System.EventHandler(this.listBoxNumberPlate_SelectedIndexChanged);
            // 
            // buttonAddNewItem
            // 
            this.buttonAddNewItem.Location = new System.Drawing.Point(131, 346);
            this.buttonAddNewItem.Name = "buttonAddNewItem";
            this.buttonAddNewItem.Size = new System.Drawing.Size(120, 39);
            this.buttonAddNewItem.TabIndex = 1;
            this.buttonAddNewItem.Text = "Add New Item";
            this.buttonAddNewItem.UseVisualStyleBackColor = true;
            this.buttonAddNewItem.Click += new System.EventHandler(this.buttonAddNewItem_Click);
            // 
            // textBoxNumberPlate
            // 
            this.textBoxNumberPlate.Location = new System.Drawing.Point(484, 35);
            this.textBoxNumberPlate.Name = "textBoxNumberPlate";
            this.textBoxNumberPlate.Size = new System.Drawing.Size(155, 23);
            this.textBoxNumberPlate.TabIndex = 2;
            // 
            // textBoxTypeOfCar
            // 
            this.textBoxTypeOfCar.Location = new System.Drawing.Point(484, 90);
            this.textBoxTypeOfCar.Name = "textBoxTypeOfCar";
            this.textBoxTypeOfCar.Size = new System.Drawing.Size(155, 23);
            this.textBoxTypeOfCar.TabIndex = 3;
            // 
            // textBoxNameOfOwner
            // 
            this.textBoxNameOfOwner.Location = new System.Drawing.Point(484, 141);
            this.textBoxNameOfOwner.Name = "textBoxNameOfOwner";
            this.textBoxNameOfOwner.Size = new System.Drawing.Size(155, 23);
            this.textBoxNameOfOwner.TabIndex = 4;
            // 
            // checkBoxDiesel
            // 
            this.checkBoxDiesel.AutoSize = true;
            this.checkBoxDiesel.Location = new System.Drawing.Point(582, 305);
            this.checkBoxDiesel.Name = "checkBoxDiesel";
            this.checkBoxDiesel.Size = new System.Drawing.Size(57, 19);
            this.checkBoxDiesel.TabIndex = 7;
            this.checkBoxDiesel.Text = "Diesel";
            this.checkBoxDiesel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Registered Number Plate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Number Plate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Type Of Car";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name of Owner";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Year of Production";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "MOT Test Validity";
            // 
            // textBoxYearOfProduction
            // 
            this.textBoxYearOfProduction.Location = new System.Drawing.Point(484, 199);
            this.textBoxYearOfProduction.Name = "textBoxYearOfProduction";
            this.textBoxYearOfProduction.Size = new System.Drawing.Size(155, 23);
            this.textBoxYearOfProduction.TabIndex = 14;
            // 
            // textBoxMOTTestValidity
            // 
            this.textBoxMOTTestValidity.Location = new System.Drawing.Point(484, 261);
            this.textBoxMOTTestValidity.Name = "textBoxMOTTestValidity";
            this.textBoxMOTTestValidity.Size = new System.Drawing.Size(155, 23);
            this.textBoxMOTTestValidity.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxMOTTestValidity);
            this.Controls.Add(this.textBoxYearOfProduction);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxDiesel);
            this.Controls.Add(this.textBoxNameOfOwner);
            this.Controls.Add(this.textBoxTypeOfCar);
            this.Controls.Add(this.textBoxNumberPlate);
            this.Controls.Add(this.buttonAddNewItem);
            this.Controls.Add(this.listBoxNumberPlate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNumberPlate;
        private System.Windows.Forms.Button buttonAddNewItem;
        private System.Windows.Forms.TextBox textBoxNumberPlate;
        private System.Windows.Forms.TextBox textBoxTypeOfCar;
        private System.Windows.Forms.TextBox textBoxNameOfOwner;
        private System.Windows.Forms.CheckBox checkBoxDiesel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxYearOfProduction;
        private System.Windows.Forms.TextBox textBoxMOTTestValidity;
    }
}

