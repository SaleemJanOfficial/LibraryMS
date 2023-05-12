namespace LibraryMS
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucHome1 = new LibraryMS.UCHome();
            this.AboutButton = new FontAwesome.Sharp.IconButton();
            this.ButtonAddUser = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.HomeButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ucAbout1 = new LibraryMS.UCAbout();
            this.ucAddUser1 = new LibraryMS.UCAddUser();
            this.ucStatus1 = new LibraryMS.UCStatus();
            this.ucAddOrder1 = new LibraryMS.UCAddOrder();
            this.ucHome2 = new LibraryMS.UCHome();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucHome1);
            this.panel1.Controls.Add(this.AboutButton);
            this.panel1.Controls.Add(this.ButtonAddUser);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 450);
            this.panel1.TabIndex = 0;
            // 
            // ucHome1
            // 
            this.ucHome1.Location = new System.Drawing.Point(133, 98);
            this.ucHome1.Name = "ucHome1";
            this.ucHome1.Size = new System.Drawing.Size(664, 349);
            this.ucHome1.TabIndex = 2;
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AboutButton.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.AboutButton.IconColor = System.Drawing.Color.White;
            this.AboutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AboutButton.IconSize = 40;
            this.AboutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutButton.Location = new System.Drawing.Point(0, 339);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(136, 49);
            this.AboutButton.TabIndex = 1;
            this.AboutButton.Text = "Aobut";
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // ButtonAddUser
            // 
            this.ButtonAddUser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButtonAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonAddUser.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ButtonAddUser.IconColor = System.Drawing.Color.White;
            this.ButtonAddUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonAddUser.IconSize = 40;
            this.ButtonAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAddUser.Location = new System.Drawing.Point(0, 284);
            this.ButtonAddUser.Name = "ButtonAddUser";
            this.ButtonAddUser.Size = new System.Drawing.Size(136, 49);
            this.ButtonAddUser.TabIndex = 1;
            this.ButtonAddUser.Text = "Add User";
            this.ButtonAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAddUser.UseVisualStyleBackColor = false;
            this.ButtonAddUser.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 40;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 229);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(136, 49);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "Status";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 174);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(136, 49);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Iusse Book";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HomeButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.HomeButton.IconColor = System.Drawing.Color.White;
            this.HomeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HomeButton.IconSize = 40;
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(0, 119);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(136, 49);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "HOME";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(142, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(659, 355);
            this.panel3.TabIndex = 1;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(136, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(664, 100);
            this.panel5.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "LIBRARY  MANAGMENT SYSTEM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nafees Nastaleeq", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ucAbout1);
            this.panel4.Controls.Add(this.ucAddUser1);
            this.panel4.Controls.Add(this.ucStatus1);
            this.panel4.Controls.Add(this.ucAddOrder1);
            this.panel4.Controls.Add(this.ucHome2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(136, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(664, 350);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // ucAbout1
            // 
            this.ucAbout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAbout1.Location = new System.Drawing.Point(0, 0);
            this.ucAbout1.Name = "ucAbout1";
            this.ucAbout1.Size = new System.Drawing.Size(664, 350);
            this.ucAbout1.TabIndex = 4;
            // 
            // ucAddUser1
            // 
            this.ucAddUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAddUser1.Location = new System.Drawing.Point(0, 0);
            this.ucAddUser1.Name = "ucAddUser1";
            this.ucAddUser1.Size = new System.Drawing.Size(664, 350);
            this.ucAddUser1.TabIndex = 3;
            // 
            // ucStatus1
            // 
            this.ucStatus1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucStatus1.Location = new System.Drawing.Point(0, 0);
            this.ucStatus1.Name = "ucStatus1";
            this.ucStatus1.Size = new System.Drawing.Size(664, 350);
            this.ucStatus1.TabIndex = 2;
            // 
            // ucAddOrder1
            // 
            this.ucAddOrder1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ucAddOrder1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucAddOrder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAddOrder1.Location = new System.Drawing.Point(0, 0);
            this.ucAddOrder1.Name = "ucAddOrder1";
            this.ucAddOrder1.Size = new System.Drawing.Size(664, 350);
            this.ucAddOrder1.TabIndex = 1;
            // 
            // ucHome2
            // 
            this.ucHome2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucHome2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucHome2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHome2.Location = new System.Drawing.Point(0, 0);
            this.ucHome2.Name = "ucHome2";
            this.ucHome2.Size = new System.Drawing.Size(664, 350);
            this.ucHome2.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Library Managment System";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel2;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
        private FontAwesome.Sharp.IconButton HomeButton;
        private FontAwesome.Sharp.IconButton AboutButton;
        private FontAwesome.Sharp.IconButton ButtonAddUser;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UCHome ucHome1;
        private System.Windows.Forms.Panel panel4;
        private UCHome ucHome2;
        private UCAddOrder ucAddOrder1;
        private UCStatus ucStatus1;
        private UCAbout ucAbout1;
        private UCAddUser ucAddUser1;
    }
}