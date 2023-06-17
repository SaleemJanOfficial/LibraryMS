namespace LibraryMS
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
            this.AddNewUserButton = new FontAwesome.Sharp.IconButton();
            this.ViewAllUserButton = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(281, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add User";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.ViewAllUserButton);
            this.panel2.Controls.Add(this.AddNewUserButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(664, 313);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 36);
            this.panel1.TabIndex = 2;
            // 
            // AddNewUserButton
            // 
            this.AddNewUserButton.BackColor = System.Drawing.Color.Black;
            this.AddNewUserButton.ForeColor = System.Drawing.Color.White;
            this.AddNewUserButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AddNewUserButton.IconColor = System.Drawing.Color.Black;
            this.AddNewUserButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddNewUserButton.Location = new System.Drawing.Point(331, 248);
            this.AddNewUserButton.Name = "AddNewUserButton";
            this.AddNewUserButton.Size = new System.Drawing.Size(126, 34);
            this.AddNewUserButton.TabIndex = 0;
            this.AddNewUserButton.Text = "Add New User";
            this.AddNewUserButton.UseVisualStyleBackColor = false;
            // 
            // ViewAllUserButton
            // 
            this.ViewAllUserButton.BackColor = System.Drawing.Color.Black;
            this.ViewAllUserButton.ForeColor = System.Drawing.Color.White;
            this.ViewAllUserButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ViewAllUserButton.IconColor = System.Drawing.Color.Black;
            this.ViewAllUserButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ViewAllUserButton.Location = new System.Drawing.Point(494, 248);
            this.ViewAllUserButton.Name = "ViewAllUserButton";
            this.ViewAllUserButton.Size = new System.Drawing.Size(126, 34);
            this.ViewAllUserButton.TabIndex = 0;
            this.ViewAllUserButton.Text = "View All Users";
            this.ViewAllUserButton.UseVisualStyleBackColor = false;
            this.ViewAllUserButton.Click += new System.EventHandler(this.ViewAllUserButton_Click);
            // 
            // UCAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCAddUser";
            this.Size = new System.Drawing.Size(664, 349);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton ViewAllUserButton;
        private FontAwesome.Sharp.IconButton AddNewUserButton;
    }
}
