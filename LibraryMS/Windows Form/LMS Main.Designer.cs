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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sidepanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddBook = new FontAwesome.Sharp.IconButton();
            this.AboutButton = new FontAwesome.Sharp.IconButton();
            this.ButtonAddUser = new FontAwesome.Sharp.IconButton();
            this.ReturnButton = new FontAwesome.Sharp.IconButton();
            this.IssueButton = new FontAwesome.Sharp.IconButton();
            this.HomeButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.UCPanel = new System.Windows.Forms.Panel();
            this.ucMainHome = new LibraryMS.UCHome();
            this.ucIssueBook = new LibraryMS.UCIssueBooks();
            this.ucAddUser = new LibraryMS.UCAddUser();
            this.ucAbout = new LibraryMS.UCAbout();
            this.ucAddBooks = new LibraryMS.UCAddBooks();
            this.ucPanding = new LibraryMS.UCStatus();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            this.UCPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.Sidepanel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonAddBook);
            this.panel1.Controls.Add(this.AboutButton);
            this.panel1.Controls.Add(this.ButtonAddUser);
            this.panel1.Controls.Add(this.ReturnButton);
            this.panel1.Controls.Add(this.IssueButton);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 474);
            this.panel1.TabIndex = 0;
            // 
            // Sidepanel
            // 
            this.Sidepanel.BackColor = System.Drawing.Color.Red;
            this.Sidepanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sidepanel.Location = new System.Drawing.Point(127, 100);
            this.Sidepanel.Name = "Sidepanel";
            this.Sidepanel.Size = new System.Drawing.Size(7, 49);
            this.Sidepanel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(32, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Version 1.1";
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAddBook.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBook.ForeColor = System.Drawing.Color.White;
            this.buttonAddBook.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.buttonAddBook.IconColor = System.Drawing.Color.White;
            this.buttonAddBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonAddBook.IconSize = 40;
            this.buttonAddBook.Location = new System.Drawing.Point(0, 196);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(136, 49);
            this.buttonAddBook.TabIndex = 5;
            this.buttonAddBook.Text = "Add Books";
            this.buttonAddBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddBook.UseVisualStyleBackColor = false;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AboutButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AboutButton.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.AboutButton.IconColor = System.Drawing.Color.White;
            this.AboutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AboutButton.IconSize = 40;
            this.AboutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutButton.Location = new System.Drawing.Point(0, 343);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(136, 49);
            this.AboutButton.TabIndex = 6;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // ButtonAddUser
            // 
            this.ButtonAddUser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButtonAddUser.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButtonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonAddUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ButtonAddUser.IconColor = System.Drawing.Color.White;
            this.ButtonAddUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonAddUser.IconSize = 40;
            this.ButtonAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAddUser.Location = new System.Drawing.Point(0, 147);
            this.ButtonAddUser.Name = "ButtonAddUser";
            this.ButtonAddUser.Size = new System.Drawing.Size(136, 49);
            this.ButtonAddUser.TabIndex = 4;
            this.ButtonAddUser.Text = "Add Users";
            this.ButtonAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAddUser.UseVisualStyleBackColor = false;
            this.ButtonAddUser.Click += new System.EventHandler(this.ButtonAddUser_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ReturnButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReturnButton.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.ReturnButton.IconColor = System.Drawing.Color.White;
            this.ReturnButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReturnButton.IconSize = 40;
            this.ReturnButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReturnButton.Location = new System.Drawing.Point(0, 294);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(136, 49);
            this.ReturnButton.TabIndex = 3;
            this.ReturnButton.Text = "Return Book";
            this.ReturnButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.PandingButton_Click);
            // 
            // IssueButton
            // 
            this.IssueButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.IssueButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.IssueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IssueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IssueButton.IconChar = FontAwesome.Sharp.IconChar.SpellCheck;
            this.IssueButton.IconColor = System.Drawing.Color.White;
            this.IssueButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IssueButton.IconSize = 40;
            this.IssueButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IssueButton.Location = new System.Drawing.Point(0, 245);
            this.IssueButton.Name = "IssueButton";
            this.IssueButton.Size = new System.Drawing.Size(136, 49);
            this.IssueButton.TabIndex = 2;
            this.IssueButton.Text = "Issue Book";
            this.IssueButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IssueButton.UseVisualStyleBackColor = false;
            this.IssueButton.Click += new System.EventHandler(this.IssueButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.HomeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HomeButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.HomeButton.IconColor = System.Drawing.Color.White;
            this.HomeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HomeButton.IconSize = 40;
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(0, 98);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(136, 49);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "HOME";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 100);
            this.panel2.TabIndex = 0;
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
            // UCPanel
            // 
            this.UCPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UCPanel.Controls.Add(this.ucMainHome);
            this.UCPanel.Controls.Add(this.ucIssueBook);
            this.UCPanel.Controls.Add(this.ucAddUser);
            this.UCPanel.Controls.Add(this.ucAbout);
            this.UCPanel.Controls.Add(this.ucAddBooks);
            this.UCPanel.Controls.Add(this.ucPanding);
            this.UCPanel.Location = new System.Drawing.Point(136, 100);
            this.UCPanel.Name = "UCPanel";
            this.UCPanel.Size = new System.Drawing.Size(754, 374);
            this.UCPanel.TabIndex = 1;
            // 
            // ucMainHome
            // 
            this.ucMainHome.AutoScroll = true;
            this.ucMainHome.AutoSize = true;
            this.ucMainHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucMainHome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ucMainHome.CausesValidation = false;
            this.ucMainHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMainHome.Location = new System.Drawing.Point(0, 0);
            this.ucMainHome.Name = "ucMainHome";
            this.ucMainHome.Size = new System.Drawing.Size(754, 374);
            this.ucMainHome.TabIndex = 0;
            // 
            // ucIssueBook
            // 
            this.ucIssueBook.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ucIssueBook.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucIssueBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucIssueBook.Location = new System.Drawing.Point(0, 0);
            this.ucIssueBook.Name = "ucIssueBook";
            this.ucIssueBook.Size = new System.Drawing.Size(754, 374);
            this.ucIssueBook.TabIndex = 1;
            this.ucIssueBook.Visible = false;
            // 
            // ucAddUser
            // 
            this.ucAddUser.AutoSize = true;
            this.ucAddUser.BackColor = System.Drawing.Color.Magenta;
            this.ucAddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAddUser.Location = new System.Drawing.Point(0, 0);
            this.ucAddUser.Name = "ucAddUser";
            this.ucAddUser.Size = new System.Drawing.Size(754, 374);
            this.ucAddUser.TabIndex = 3;
            this.ucAddUser.Visible = false;
            // 
            // ucAbout
            // 
            this.ucAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAbout.Location = new System.Drawing.Point(0, 0);
            this.ucAbout.Name = "ucAbout";
            this.ucAbout.Size = new System.Drawing.Size(754, 374);
            this.ucAbout.TabIndex = 8;
            // 
            // ucAddBooks
            // 
            this.ucAddBooks.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ucAddBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAddBooks.Location = new System.Drawing.Point(0, 0);
            this.ucAddBooks.Name = "ucAddBooks";
            this.ucAddBooks.Size = new System.Drawing.Size(754, 374);
            this.ucAddBooks.TabIndex = 5;
            this.ucAddBooks.Visible = false;
            // 
            // ucPanding
            // 
            this.ucPanding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanding.Location = new System.Drawing.Point(0, 0);
            this.ucPanding.Name = "ucPanding";
            this.ucPanding.Size = new System.Drawing.Size(754, 374);
            this.ucPanding.TabIndex = 6;
            this.ucPanding.Visible = false;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.OrangeRed;
            this.HeaderPanel.Controls.Add(this.label5);
            this.HeaderPanel.Controls.Add(this.lblWelcome);
            this.HeaderPanel.Controls.Add(this.label2);
            this.HeaderPanel.Controls.Add(this.label4);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.HeaderPanel.Location = new System.Drawing.Point(136, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(754, 100);
            this.HeaderPanel.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Shia", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(139, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(476, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "گورنمٹ پوسٹ گریجویٹ کالج گوہاٹی (صوابی)";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Blue;
            this.lblWelcome.Location = new System.Drawing.Point(156, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(154, 35);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "User Name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(316, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(417, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = " to Library Managment System ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 474);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.UCPanel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(906, 513);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Managment System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            this.UCPanel.ResumeLayout(false);
            this.UCPanel.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
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
        private FontAwesome.Sharp.IconButton ReturnButton;
        private FontAwesome.Sharp.IconButton IssueButton;
        private FontAwesome.Sharp.IconButton buttonAddBook;
        private System.Windows.Forms.Panel UCPanel;
        private UCAddBooks ucAddBooks;
        internal protected UCStatus ucPanding;
        private UCIssueBooks ucIssueBook;
        private UCAddUser ucAddUser;
       private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private UCHome ucMainHome;
        private UCAbout ucAbout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Sidepanel;
    }
}