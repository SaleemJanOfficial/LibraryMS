﻿namespace LibraryMS
{
    partial class UCAddUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddNewStudentsButton = new FontAwesome.Sharp.IconButton();
            this.ViewAllStudentsButton = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.ButtonClearAddStudents = new FontAwesome.Sharp.IconButton();
            this.ButtonBackAddStudents = new FontAwesome.Sharp.IconButton();
            this.ButtonSaveAddStudents = new FontAwesome.Sharp.IconButton();
            this.ButtonUpdateAddStudents = new FontAwesome.Sharp.IconButton();
            this.ButtonDeleteAddStudents = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.RadioMale = new System.Windows.Forms.RadioButton();
            this.RadioFemale = new System.Windows.Forms.RadioButton();
            this.RadioOther = new System.Windows.Forms.RadioButton();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.PanelAddUser = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PanelAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(270, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add OR Remove Students";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.PanelAddUser);
            this.panel2.Controls.Add(this.ViewAllStudentsButton);
            this.panel2.Controls.Add(this.AddNewStudentsButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 313);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 36);
            this.panel1.TabIndex = 2;
            // 
            // AddNewStudentsButton
            // 
            this.AddNewStudentsButton.BackColor = System.Drawing.Color.Black;
            this.AddNewStudentsButton.ForeColor = System.Drawing.Color.White;
            this.AddNewStudentsButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AddNewStudentsButton.IconColor = System.Drawing.Color.Black;
            this.AddNewStudentsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddNewStudentsButton.Location = new System.Drawing.Point(9, 34);
            this.AddNewStudentsButton.Name = "AddNewStudentsButton";
            this.AddNewStudentsButton.Size = new System.Drawing.Size(126, 34);
            this.AddNewStudentsButton.TabIndex = 0;
            this.AddNewStudentsButton.Text = "Add New Student";
            this.AddNewStudentsButton.UseVisualStyleBackColor = false;
            this.AddNewStudentsButton.Click += new System.EventHandler(this.AddNewUserButton_Click);
            // 
            // ViewAllStudentsButton
            // 
            this.ViewAllStudentsButton.BackColor = System.Drawing.Color.Black;
            this.ViewAllStudentsButton.ForeColor = System.Drawing.Color.White;
            this.ViewAllStudentsButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ViewAllStudentsButton.IconColor = System.Drawing.Color.Black;
            this.ViewAllStudentsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ViewAllStudentsButton.Location = new System.Drawing.Point(9, 75);
            this.ViewAllStudentsButton.Name = "ViewAllStudentsButton";
            this.ViewAllStudentsButton.Size = new System.Drawing.Size(126, 34);
            this.ViewAllStudentsButton.TabIndex = 0;
            this.ViewAllStudentsButton.Text = "View All Students";
            this.ViewAllStudentsButton.UseVisualStyleBackColor = false;
            this.ViewAllStudentsButton.Click += new System.EventHandler(this.ViewAllUserButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "User ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "F Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Gender";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(95, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 20);
            this.textBox3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Roll No";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(95, 127);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(167, 20);
            this.textBox4.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(285, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Religion";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(385, 105);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(168, 20);
            this.textBox5.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(285, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Address";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(385, 131);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(168, 20);
            this.textBox6.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(285, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Department";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(385, 35);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(168, 20);
            this.textBox9.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(285, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 18);
            this.label12.TabIndex = 1;
            this.label12.Text = "Year/Sem";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(385, 58);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(168, 20);
            this.textBox11.TabIndex = 2;
            // 
            // ButtonClearAddStudents
            // 
            this.ButtonClearAddStudents.BackColor = System.Drawing.Color.Black;
            this.ButtonClearAddStudents.ForeColor = System.Drawing.Color.White;
            this.ButtonClearAddStudents.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonClearAddStudents.IconColor = System.Drawing.Color.Black;
            this.ButtonClearAddStudents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonClearAddStudents.Location = new System.Drawing.Point(50, 184);
            this.ButtonClearAddStudents.Name = "ButtonClearAddStudents";
            this.ButtonClearAddStudents.Size = new System.Drawing.Size(102, 34);
            this.ButtonClearAddStudents.TabIndex = 0;
            this.ButtonClearAddStudents.Text = "Clear";
            this.ButtonClearAddStudents.UseVisualStyleBackColor = false;
            this.ButtonClearAddStudents.Click += new System.EventHandler(this.ButtonClearAdduser_Click);
            // 
            // ButtonBackAddStudents
            // 
            this.ButtonBackAddStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonBackAddStudents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonBackAddStudents.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ButtonBackAddStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBackAddStudents.ForeColor = System.Drawing.Color.White;
            this.ButtonBackAddStudents.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonBackAddStudents.IconColor = System.Drawing.Color.Black;
            this.ButtonBackAddStudents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonBackAddStudents.IconSize = 20;
            this.ButtonBackAddStudents.Location = new System.Drawing.Point(567, 3);
            this.ButtonBackAddStudents.Name = "ButtonBackAddStudents";
            this.ButtonBackAddStudents.Size = new System.Drawing.Size(43, 28);
            this.ButtonBackAddStudents.TabIndex = 0;
            this.ButtonBackAddStudents.Text = "X";
            this.ButtonBackAddStudents.UseMnemonic = false;
            this.ButtonBackAddStudents.UseVisualStyleBackColor = false;
            this.ButtonBackAddStudents.Click += new System.EventHandler(this.ButtonBackAddUser_Click);
            // 
            // ButtonSaveAddStudents
            // 
            this.ButtonSaveAddStudents.BackColor = System.Drawing.Color.Black;
            this.ButtonSaveAddStudents.ForeColor = System.Drawing.Color.White;
            this.ButtonSaveAddStudents.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonSaveAddStudents.IconColor = System.Drawing.Color.Black;
            this.ButtonSaveAddStudents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonSaveAddStudents.Location = new System.Drawing.Point(159, 184);
            this.ButtonSaveAddStudents.Name = "ButtonSaveAddStudents";
            this.ButtonSaveAddStudents.Size = new System.Drawing.Size(102, 34);
            this.ButtonSaveAddStudents.TabIndex = 0;
            this.ButtonSaveAddStudents.Text = "Save";
            this.ButtonSaveAddStudents.UseVisualStyleBackColor = false;
            this.ButtonSaveAddStudents.Click += new System.EventHandler(this.ButtonSaveAddUser_Click);
            // 
            // ButtonUpdateAddStudents
            // 
            this.ButtonUpdateAddStudents.BackColor = System.Drawing.Color.Black;
            this.ButtonUpdateAddStudents.ForeColor = System.Drawing.Color.White;
            this.ButtonUpdateAddStudents.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonUpdateAddStudents.IconColor = System.Drawing.Color.Black;
            this.ButtonUpdateAddStudents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonUpdateAddStudents.Location = new System.Drawing.Point(267, 184);
            this.ButtonUpdateAddStudents.Name = "ButtonUpdateAddStudents";
            this.ButtonUpdateAddStudents.Size = new System.Drawing.Size(102, 34);
            this.ButtonUpdateAddStudents.TabIndex = 0;
            this.ButtonUpdateAddStudents.Text = "Update";
            this.ButtonUpdateAddStudents.UseVisualStyleBackColor = false;
            this.ButtonUpdateAddStudents.Click += new System.EventHandler(this.ButtonUpdateAdduser_Click);
            // 
            // ButtonDeleteAddStudents
            // 
            this.ButtonDeleteAddStudents.BackColor = System.Drawing.Color.Black;
            this.ButtonDeleteAddStudents.ForeColor = System.Drawing.Color.White;
            this.ButtonDeleteAddStudents.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonDeleteAddStudents.IconColor = System.Drawing.Color.Black;
            this.ButtonDeleteAddStudents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonDeleteAddStudents.Location = new System.Drawing.Point(375, 184);
            this.ButtonDeleteAddStudents.Name = "ButtonDeleteAddStudents";
            this.ButtonDeleteAddStudents.Size = new System.Drawing.Size(102, 34);
            this.ButtonDeleteAddStudents.TabIndex = 0;
            this.ButtonDeleteAddStudents.Text = "Delete";
            this.ButtonDeleteAddStudents.UseVisualStyleBackColor = false;
            this.ButtonDeleteAddStudents.Click += new System.EventHandler(this.ButtonDeleteAdduser_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Programe";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(96, 152);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(167, 20);
            this.textBox10.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 67);
            this.dataGridView1.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(285, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 18);
            this.label13.TabIndex = 1;
            this.label13.Text = "Enrol Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.CustomFormat = "dd/mm/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(385, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2023, 6, 18, 0, 0, 0, 0);
            // 
            // RadioMale
            // 
            this.RadioMale.AutoSize = true;
            this.RadioMale.Location = new System.Drawing.Point(97, 107);
            this.RadioMale.Name = "RadioMale";
            this.RadioMale.Size = new System.Drawing.Size(48, 17);
            this.RadioMale.TabIndex = 5;
            this.RadioMale.TabStop = true;
            this.RadioMale.Text = "Male";
            this.RadioMale.UseVisualStyleBackColor = true;
            // 
            // RadioFemale
            // 
            this.RadioFemale.AutoSize = true;
            this.RadioFemale.Location = new System.Drawing.Point(147, 107);
            this.RadioFemale.Name = "RadioFemale";
            this.RadioFemale.Size = new System.Drawing.Size(59, 17);
            this.RadioFemale.TabIndex = 6;
            this.RadioFemale.TabStop = true;
            this.RadioFemale.Text = "Female";
            this.RadioFemale.UseVisualStyleBackColor = true;
            // 
            // RadioOther
            // 
            this.RadioOther.AutoSize = true;
            this.RadioOther.Location = new System.Drawing.Point(213, 107);
            this.RadioOther.Name = "RadioOther";
            this.RadioOther.Size = new System.Drawing.Size(51, 17);
            this.RadioOther.TabIndex = 6;
            this.RadioOther.TabStop = true;
            this.RadioOther.Text = "Other";
            this.RadioOther.UseVisualStyleBackColor = true;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 10;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconLeft = global::LibraryMS.Properties.Resources.download__1_;
            this.guna2TextBox1.IconLeftOffset = new System.Drawing.Point(6, 0);
            this.guna2TextBox1.Location = new System.Drawing.Point(214, 6);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Search Here!";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(182, 24);
            this.guna2TextBox1.TabIndex = 8;
            // 
            // PanelAddUser
            // 
            this.PanelAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelAddUser.BackColor = System.Drawing.Color.SkyBlue;
            this.PanelAddUser.Controls.Add(this.guna2TextBox1);
            this.PanelAddUser.Controls.Add(this.RadioOther);
            this.PanelAddUser.Controls.Add(this.RadioFemale);
            this.PanelAddUser.Controls.Add(this.RadioMale);
            this.PanelAddUser.Controls.Add(this.dateTimePicker1);
            this.PanelAddUser.Controls.Add(this.label13);
            this.PanelAddUser.Controls.Add(this.dataGridView1);
            this.PanelAddUser.Controls.Add(this.textBox10);
            this.PanelAddUser.Controls.Add(this.label11);
            this.PanelAddUser.Controls.Add(this.ButtonDeleteAddStudents);
            this.PanelAddUser.Controls.Add(this.ButtonUpdateAddStudents);
            this.PanelAddUser.Controls.Add(this.ButtonSaveAddStudents);
            this.PanelAddUser.Controls.Add(this.ButtonBackAddStudents);
            this.PanelAddUser.Controls.Add(this.ButtonClearAddStudents);
            this.PanelAddUser.Controls.Add(this.textBox11);
            this.PanelAddUser.Controls.Add(this.label12);
            this.PanelAddUser.Controls.Add(this.textBox9);
            this.PanelAddUser.Controls.Add(this.label10);
            this.PanelAddUser.Controls.Add(this.textBox6);
            this.PanelAddUser.Controls.Add(this.label7);
            this.PanelAddUser.Controls.Add(this.textBox5);
            this.PanelAddUser.Controls.Add(this.label6);
            this.PanelAddUser.Controls.Add(this.textBox4);
            this.PanelAddUser.Controls.Add(this.label5);
            this.PanelAddUser.Controls.Add(this.textBox3);
            this.PanelAddUser.Controls.Add(this.label9);
            this.PanelAddUser.Controls.Add(this.label4);
            this.PanelAddUser.Controls.Add(this.textBox2);
            this.PanelAddUser.Controls.Add(this.label3);
            this.PanelAddUser.Controls.Add(this.textBox1);
            this.PanelAddUser.Controls.Add(this.label2);
            this.PanelAddUser.Location = new System.Drawing.Point(150, 0);
            this.PanelAddUser.Name = "PanelAddUser";
            this.PanelAddUser.Size = new System.Drawing.Size(613, 289);
            this.PanelAddUser.TabIndex = 3;
            this.PanelAddUser.Visible = false;
            // 
            // UCAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCAddUser";
            this.Size = new System.Drawing.Size(763, 349);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PanelAddUser.ResumeLayout(false);
            this.PanelAddUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelAddUser;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.RadioButton RadioOther;
        private System.Windows.Forms.RadioButton RadioFemale;
        private System.Windows.Forms.RadioButton RadioMale;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton ButtonDeleteAddStudents;
        private FontAwesome.Sharp.IconButton ButtonUpdateAddStudents;
        private FontAwesome.Sharp.IconButton ButtonSaveAddStudents;
        private FontAwesome.Sharp.IconButton ButtonBackAddStudents;
        private FontAwesome.Sharp.IconButton ButtonClearAddStudents;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton ViewAllStudentsButton;
        private FontAwesome.Sharp.IconButton AddNewStudentsButton;
    }
}
