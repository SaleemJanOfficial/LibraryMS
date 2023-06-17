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
            this.buttonAddBook = new FontAwesome.Sharp.IconButton();
            this.AboutButton = new FontAwesome.Sharp.IconButton();
            this.ButtonAddUser = new FontAwesome.Sharp.IconButton();
            this.PandingButton = new FontAwesome.Sharp.IconButton();
            this.IssueButton = new FontAwesome.Sharp.IconButton();
            this.HomeButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UCPanel = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ucAbout = new LibraryMS.UCAbout();
            this.ucAddBooks = new LibraryMS.UCAddBooks();
            this.ucPending = new LibraryMS.UCStatus();
            this.ucMainHome = new LibraryMS.UCHome();
            this.ucIssueBook = new LibraryMS.UCAddOrder();
            this.ucPanding = new LibraryMS.UCStatus();
            this.ucAddUser = new LibraryMS.UCAddUser();
            this.ucHome1 = new LibraryMS.UCHome();
            this.panel1.SuspendLayout();
            this.UCPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            this.panel5.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.buttonAddBook);
            this.panel1.Controls.Add(this.ucHome1);
            this.panel1.Controls.Add(this.AboutButton);
            this.panel1.Controls.Add(this.ButtonAddUser);
            this.panel1.Controls.Add(this.PandingButton);
            this.panel1.Controls.Add(this.IssueButton);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 474);
            this.panel1.TabIndex = 0;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBook.ForeColor = System.Drawing.Color.White;
            this.buttonAddBook.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.buttonAddBook.IconColor = System.Drawing.Color.White;
            this.buttonAddBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonAddBook.IconSize = 40;
            this.buttonAddBook.Location = new System.Drawing.Point(-3, 327);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(139, 49);
            this.buttonAddBook.TabIndex = 7;
            this.buttonAddBook.Text = "Add Books";
            this.buttonAddBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddBook.UseVisualStyleBackColor = false;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AboutButton.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.AboutButton.IconColor = System.Drawing.Color.White;
            this.AboutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AboutButton.IconSize = 40;
            this.AboutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutButton.Location = new System.Drawing.Point(-3, 382);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(139, 49);
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
            this.ButtonAddUser.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.ButtonAddUser.IconColor = System.Drawing.Color.White;
            this.ButtonAddUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonAddUser.IconSize = 40;
            this.ButtonAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAddUser.Location = new System.Drawing.Point(-3, 272);
            this.ButtonAddUser.Name = "ButtonAddUser";
            this.ButtonAddUser.Size = new System.Drawing.Size(139, 49);
            this.ButtonAddUser.TabIndex = 1;
            this.ButtonAddUser.Text = "Add Users";
            this.ButtonAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAddUser.UseVisualStyleBackColor = false;
            this.ButtonAddUser.Click += new System.EventHandler(this.ButtonAddUser_Click);
            // 
            // PandingButton
            // 
            this.PandingButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PandingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PandingButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PandingButton.IconChar = FontAwesome.Sharp.IconChar.GroupArrowsRotate;
            this.PandingButton.IconColor = System.Drawing.Color.White;
            this.PandingButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PandingButton.IconSize = 40;
            this.PandingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PandingButton.Location = new System.Drawing.Point(-3, 217);
            this.PandingButton.Name = "PandingButton";
            this.PandingButton.Size = new System.Drawing.Size(139, 49);
            this.PandingButton.TabIndex = 1;
            this.PandingButton.Text = "Pending";
            this.PandingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PandingButton.UseVisualStyleBackColor = false;
            this.PandingButton.Click += new System.EventHandler(this.PandingButton_Click);
            // 
            // IssueButton
            // 
            this.IssueButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.IssueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IssueButton.IconChar = FontAwesome.Sharp.IconChar.Hive;
            this.IssueButton.IconColor = System.Drawing.Color.White;
            this.IssueButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IssueButton.IconSize = 40;
            this.IssueButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IssueButton.Location = new System.Drawing.Point(-3, 162);
            this.IssueButton.Name = "IssueButton";
            this.IssueButton.Size = new System.Drawing.Size(139, 49);
            this.IssueButton.TabIndex = 1;
            this.IssueButton.Text = "Iusse Book";
            this.IssueButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IssueButton.UseVisualStyleBackColor = false;
            this.IssueButton.Click += new System.EventHandler(this.IssueButton_Click);
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
            this.HomeButton.Location = new System.Drawing.Point(-3, 107);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(139, 49);
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
            this.panel2.TabIndex = 1;
            // 
            // UCPanel
            // 
            this.UCPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UCPanel.Controls.Add(this.ucAddBooks);
            this.UCPanel.Controls.Add(this.ucPending);
            this.UCPanel.Controls.Add(this.ucMainHome);
            this.UCPanel.Controls.Add(this.ucIssueBook);
            this.UCPanel.Controls.Add(this.ucPanding);
            this.UCPanel.Controls.Add(this.ucAddUser);
            this.UCPanel.Controls.Add(this.ucAbout);
            this.UCPanel.Location = new System.Drawing.Point(0, 98);
            this.UCPanel.Name = "UCPanel";
            this.UCPanel.Size = new System.Drawing.Size(751, 373);
            this.UCPanel.TabIndex = 1;
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
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Location = new System.Drawing.Point(136, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(664, 100);
            this.panel5.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "GPGC Gohati Swabi";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(601, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO LIBRARY  MANAGMENT SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 0;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.panel6);
            this.HeaderPanel.Controls.Add(this.UCPanel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderPanel.Location = new System.Drawing.Point(136, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(754, 474);
            this.HeaderPanel.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(751, 100);
            this.panel6.TabIndex = 2;
            // 
            // ucAbout
            // 
            this.ucAbout.AutoSize = true;
            this.ucAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAbout.Location = new System.Drawing.Point(0, 0);
            this.ucAbout.Name = "ucAbout";
            this.ucAbout.Size = new System.Drawing.Size(751, 373);
            this.ucAbout.TabIndex = 4;
            this.ucAbout.Visible = false;
            // 
            // ucAddBooks
            // 
            this.ucAddBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucAddBooks.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ucAddBooks.Location = new System.Drawing.Point(0, 0);
            this.ucAddBooks.Name = "ucAddBooks";
            this.ucAddBooks.Size = new System.Drawing.Size(751, 373);
            this.ucAddBooks.TabIndex = 5;
            this.ucAddBooks.Visible = false;
            // 
            // ucPending
            // 
            this.ucPending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPending.Location = new System.Drawing.Point(0, 0);
            this.ucPending.Name = "ucPending";
            this.ucPending.Size = new System.Drawing.Size(751, 373);
            this.ucPending.TabIndex = 6;
            this.ucPending.Visible = false;
            // 
            // ucMainHome
            // 
            this.ucMainHome.AutoScroll = true;
            this.ucMainHome.AutoSize = true;
            this.ucMainHome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ucMainHome.CausesValidation = false;
            this.ucMainHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMainHome.Location = new System.Drawing.Point(0, 0);
            this.ucMainHome.Name = "ucMainHome";
            this.ucMainHome.Size = new System.Drawing.Size(751, 373);
            this.ucMainHome.TabIndex = 7;
            // 
            // ucIssueBook
            // 
            this.ucIssueBook.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ucIssueBook.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucIssueBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucIssueBook.Location = new System.Drawing.Point(0, 0);
            this.ucIssueBook.Name = "ucIssueBook";
            this.ucIssueBook.Size = new System.Drawing.Size(751, 373);
            this.ucIssueBook.TabIndex = 1;
            this.ucIssueBook.Visible = false;
            // 
            // ucPanding
            // 
            this.ucPanding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanding.Location = new System.Drawing.Point(0, 0);
            this.ucPanding.Name = "ucPanding";
            this.ucPanding.Size = new System.Drawing.Size(751, 373);
            this.ucPanding.TabIndex = 2;
            this.ucPanding.Visible = false;
            // 
            // ucAddUser
            // 
            this.ucAddUser.AutoSize = true;
            this.ucAddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAddUser.Location = new System.Drawing.Point(0, 0);
            this.ucAddUser.Name = "ucAddUser";
            this.ucAddUser.Size = new System.Drawing.Size(751, 373);
            this.ucAddUser.TabIndex = 3;
            this.ucAddUser.Visible = false;
            // 
            // ucHome1
            // 
            this.ucHome1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ucHome1.Location = new System.Drawing.Point(133, 98);
            this.ucHome1.Name = "ucHome1";
            this.ucHome1.Size = new System.Drawing.Size(664, 349);
            this.ucHome1.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 474);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Managment System";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.UCPanel.ResumeLayout(false);
            this.UCPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
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
        private FontAwesome.Sharp.IconButton PandingButton;
        private FontAwesome.Sharp.IconButton IssueButton;
        private System.Windows.Forms.Panel UCPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UCHome ucHome1;
        private System.Windows.Forms.Panel HeaderPanel;
        private UCAddOrder ucIssueBook;
        private UCStatus ucPanding;
        private UCAbout ucAbout;
        private UCAddUser ucAddUser;
        private UCAddBooks ucAddBooks;
        private UCStatus ucPending;
        private FontAwesome.Sharp.IconButton buttonAddBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private UCHome ucMainHome;
    }
}