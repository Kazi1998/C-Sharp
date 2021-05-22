
namespace Assignment
{
    partial class RegistrationForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCSharp = new System.Windows.Forms.CheckBox();
            this.txtC = new System.Windows.Forms.CheckBox();
            this.txtPython = new System.Windows.Forms.CheckBox();
            this.txtJava = new System.Windows.Forms.CheckBox();
            this.txtCity = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMarried = new System.Windows.Forms.RadioButton();
            this.txtSingle = new System.Windows.Forms.RadioButton();
            this.txtDivorced = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtOther = new System.Windows.Forms.RadioButton();
            this.txtFemale = new System.Windows.Forms.RadioButton();
            this.txtMale = new System.Windows.Forms.RadioButton();
            this.txtDOB = new System.Windows.Forms.DateTimePicker();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Assignment.Properties.Resources.OfvZwy;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtDesignation);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtDOB);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1175, 592);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration Form";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(526, 532);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 45);
            this.button2.TabIndex = 21;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1001, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(776, 486);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(201, 30);
            this.txtPassword.TabIndex = 19;
            // 
            // txtDesignation
            // 
            this.txtDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDesignation.FormattingEnabled = true;
            this.txtDesignation.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "TA"});
            this.txtDesignation.Location = new System.Drawing.Point(776, 435);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(385, 33);
            this.txtDesignation.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(608, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Password :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtCSharp);
            this.panel3.Controls.Add(this.txtC);
            this.panel3.Controls.Add(this.txtPython);
            this.panel3.Controls.Add(this.txtJava);
            this.panel3.Location = new System.Drawing.Point(776, 288);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 131);
            this.panel3.TabIndex = 17;
            // 
            // txtCSharp
            // 
            this.txtCSharp.AutoSize = true;
            this.txtCSharp.BackColor = System.Drawing.Color.White;
            this.txtCSharp.ForeColor = System.Drawing.Color.Black;
            this.txtCSharp.Location = new System.Drawing.Point(225, 86);
            this.txtCSharp.Name = "txtCSharp";
            this.txtCSharp.Size = new System.Drawing.Size(118, 29);
            this.txtCSharp.TabIndex = 16;
            this.txtCSharp.Text = "C Sharp";
            this.txtCSharp.UseVisualStyleBackColor = false;
            this.txtCSharp.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // txtC
            // 
            this.txtC.AutoSize = true;
            this.txtC.BackColor = System.Drawing.Color.White;
            this.txtC.ForeColor = System.Drawing.Color.Black;
            this.txtC.Location = new System.Drawing.Point(19, 28);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(54, 29);
            this.txtC.TabIndex = 13;
            this.txtC.Text = "C";
            this.txtC.UseVisualStyleBackColor = false;
            // 
            // txtPython
            // 
            this.txtPython.AutoSize = true;
            this.txtPython.BackColor = System.Drawing.Color.White;
            this.txtPython.ForeColor = System.Drawing.Color.Black;
            this.txtPython.Location = new System.Drawing.Point(225, 28);
            this.txtPython.Name = "txtPython";
            this.txtPython.Size = new System.Drawing.Size(105, 29);
            this.txtPython.TabIndex = 14;
            this.txtPython.Text = "Python";
            this.txtPython.UseVisualStyleBackColor = false;
            // 
            // txtJava
            // 
            this.txtJava.AutoSize = true;
            this.txtJava.BackColor = System.Drawing.Color.White;
            this.txtJava.ForeColor = System.Drawing.Color.Black;
            this.txtJava.Location = new System.Drawing.Point(19, 86);
            this.txtJava.Name = "txtJava";
            this.txtJava.Size = new System.Drawing.Size(85, 29);
            this.txtJava.TabIndex = 15;
            this.txtJava.Text = "Java";
            this.txtJava.UseVisualStyleBackColor = false;
            // 
            // txtCity
            // 
            this.txtCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCity.FormattingEnabled = true;
            this.txtCity.Items.AddRange(new object[] {
            "Dhaka",
            "Narayanganj",
            "Chittagong",
            "Comilla",
            "Khulna",
            "Rajshahi",
            "Gazipur",
            "Sylhet",
            "Barishal",
            "Rangpur",
            "Mymensingh"});
            this.txtCity.Location = new System.Drawing.Point(776, 229);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(385, 33);
            this.txtCity.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(776, 33);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(385, 172);
            this.txtAddress.TabIndex = 11;
            this.txtAddress.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtMarried);
            this.panel2.Controls.Add(this.txtSingle);
            this.panel2.Controls.Add(this.txtDivorced);
            this.panel2.Location = new System.Drawing.Point(203, 354);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 146);
            this.panel2.TabIndex = 3;
            // 
            // txtMarried
            // 
            this.txtMarried.AutoSize = true;
            this.txtMarried.ForeColor = System.Drawing.Color.Black;
            this.txtMarried.Location = new System.Drawing.Point(151, 24);
            this.txtMarried.Name = "txtMarried";
            this.txtMarried.Size = new System.Drawing.Size(110, 29);
            this.txtMarried.TabIndex = 3;
            this.txtMarried.TabStop = true;
            this.txtMarried.Text = "Married";
            this.txtMarried.UseVisualStyleBackColor = true;
            // 
            // txtSingle
            // 
            this.txtSingle.AutoSize = true;
            this.txtSingle.ForeColor = System.Drawing.Color.Black;
            this.txtSingle.Location = new System.Drawing.Point(18, 24);
            this.txtSingle.Name = "txtSingle";
            this.txtSingle.Size = new System.Drawing.Size(98, 29);
            this.txtSingle.TabIndex = 4;
            this.txtSingle.TabStop = true;
            this.txtSingle.Text = "Single";
            this.txtSingle.UseVisualStyleBackColor = true;
            // 
            // txtDivorced
            // 
            this.txtDivorced.AutoSize = true;
            this.txtDivorced.ForeColor = System.Drawing.Color.Black;
            this.txtDivorced.Location = new System.Drawing.Point(18, 93);
            this.txtDivorced.Name = "txtDivorced";
            this.txtDivorced.Size = new System.Drawing.Size(122, 29);
            this.txtDivorced.TabIndex = 5;
            this.txtDivorced.TabStop = true;
            this.txtDivorced.Text = "Divorced";
            this.txtDivorced.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtOther);
            this.panel1.Controls.Add(this.txtFemale);
            this.panel1.Controls.Add(this.txtMale);
            this.panel1.Location = new System.Drawing.Point(203, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 137);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtOther
            // 
            this.txtOther.AutoSize = true;
            this.txtOther.BackColor = System.Drawing.Color.White;
            this.txtOther.ForeColor = System.Drawing.Color.Black;
            this.txtOther.Location = new System.Drawing.Point(18, 91);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(91, 29);
            this.txtOther.TabIndex = 2;
            this.txtOther.TabStop = true;
            this.txtOther.Text = "Other";
            this.txtOther.UseVisualStyleBackColor = false;
            // 
            // txtFemale
            // 
            this.txtFemale.AutoSize = true;
            this.txtFemale.BackColor = System.Drawing.Color.White;
            this.txtFemale.ForeColor = System.Drawing.Color.Black;
            this.txtFemale.Location = new System.Drawing.Point(151, 18);
            this.txtFemale.Name = "txtFemale";
            this.txtFemale.Size = new System.Drawing.Size(108, 29);
            this.txtFemale.TabIndex = 1;
            this.txtFemale.TabStop = true;
            this.txtFemale.Text = "Female";
            this.txtFemale.UseVisualStyleBackColor = false;
            this.txtFemale.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txtMale
            // 
            this.txtMale.AutoSize = true;
            this.txtMale.BackColor = System.Drawing.Color.White;
            this.txtMale.ForeColor = System.Drawing.Color.Black;
            this.txtMale.Location = new System.Drawing.Point(18, 18);
            this.txtMale.Name = "txtMale";
            this.txtMale.Size = new System.Drawing.Size(84, 29);
            this.txtMale.TabIndex = 0;
            this.txtMale.TabStop = true;
            this.txtMale.Text = "Male";
            this.txtMale.UseVisualStyleBackColor = false;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(203, 104);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(378, 30);
            this.txtDOB.TabIndex = 9;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(203, 30);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(378, 30);
            this.txtFullName.TabIndex = 8;
            this.txtFullName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(586, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 27);
            this.label8.TabIndex = 7;
            this.label8.Text = "Designation :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(648, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "Skills :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(662, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "City :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(620, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marital Status :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(68, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(93, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "DOB :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name :";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment.Properties.Resources.OfvZwy;
            this.ClientSize = new System.Drawing.Size(1198, 625);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker txtDOB;
        private System.Windows.Forms.RadioButton txtOther;
        private System.Windows.Forms.RadioButton txtFemale;
        private System.Windows.Forms.RadioButton txtMale;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton txtMarried;
        private System.Windows.Forms.RadioButton txtSingle;
        private System.Windows.Forms.RadioButton txtDivorced;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox txtCSharp;
        private System.Windows.Forms.CheckBox txtJava;
        private System.Windows.Forms.CheckBox txtPython;
        private System.Windows.Forms.CheckBox txtC;
        private System.Windows.Forms.ComboBox txtCity;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox txtDesignation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}