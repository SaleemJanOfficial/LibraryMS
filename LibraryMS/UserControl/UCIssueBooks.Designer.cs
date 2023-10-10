namespace LibraryMS
{
    partial class UCIssueBooks
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
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Panel PanelTeacher;
            this.ViewAllBook = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.GridBookview = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SHowStudent = new System.Windows.Forms.Button();
            this.showteacher = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.IssuetoTeacher = new System.Windows.Forms.Button();
            this.IssuedBook = new System.Windows.Forms.Button();
            this.txtBookSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.ClearbtnBk = new System.Windows.Forms.Button();
            this.txtbookid = new System.Windows.Forms.TextBox();
            this.txtremaining = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.TxtStatus = new System.Windows.Forms.Label();
            this.stockbook = new System.Windows.Forms.Label();
            this.PanelStudent = new System.Windows.Forms.Panel();
            this.viewAllStudent = new System.Windows.Forms.Button();
            this.txtstudentSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStuName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtsRno = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.Label();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AlreadyIssued = new System.Windows.Forms.Label();
            this.txtbookname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelTacher = new System.Windows.Forms.Panel();
            this.viewallTeacher = new System.Windows.Forms.Button();
            this.SearchTeacher = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.Label();
            this.cleaerbuttonTeacher = new System.Windows.Forms.Button();
            this.txtPno = new System.Windows.Forms.Label();
            this.TId = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.ALreadyIssuedTeacher = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            PanelTeacher = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            PanelTeacher.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBookview)).BeginInit();
            this.panel3.SuspendLayout();
            this.PanelStudent.SuspendLayout();
            this.PanelTacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Blue;
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.ForeColor = System.Drawing.Color.White;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(664, 36);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(273, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(118, 22);
            label1.TabIndex = 0;
            label1.Text = "Issue Books";
            // 
            // PanelTeacher
            // 
            PanelTeacher.BackColor = System.Drawing.Color.DeepSkyBlue;
            PanelTeacher.Controls.Add(this.ViewAllBook);
            PanelTeacher.Controls.Add(this.panel4);
            PanelTeacher.Controls.Add(this.panel3);
            PanelTeacher.Controls.Add(this.txtBookSearch);
            PanelTeacher.Controls.Add(this.ClearbtnBk);
            PanelTeacher.Controls.Add(this.txtbookid);
            PanelTeacher.Controls.Add(this.txtremaining);
            PanelTeacher.Controls.Add(this.label6);
            PanelTeacher.Controls.Add(this.txtPublisher);
            PanelTeacher.Controls.Add(this.label33);
            PanelTeacher.Controls.Add(this.TxtStatus);
            PanelTeacher.Controls.Add(this.stockbook);
            PanelTeacher.Controls.Add(this.PanelStudent);
            PanelTeacher.Controls.Add(this.txtbookname);
            PanelTeacher.Controls.Add(this.label3);
            PanelTeacher.Controls.Add(this.label2);
            PanelTeacher.Controls.Add(this.PanelTacher);
            PanelTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelTeacher.Location = new System.Drawing.Point(0, 36);
            PanelTeacher.Name = "PanelTeacher";
            PanelTeacher.Size = new System.Drawing.Size(664, 313);
            PanelTeacher.TabIndex = 1;
            // 
            // ViewAllBook
            // 
            this.ViewAllBook.BackColor = System.Drawing.SystemColors.WindowText;
            this.ViewAllBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewAllBook.ForeColor = System.Drawing.Color.White;
            this.ViewAllBook.Location = new System.Drawing.Point(289, 4);
            this.ViewAllBook.Name = "ViewAllBook";
            this.ViewAllBook.Size = new System.Drawing.Size(75, 23);
            this.ViewAllBook.TabIndex = 20;
            this.ViewAllBook.Text = "View ALl";
            this.ViewAllBook.UseVisualStyleBackColor = false;
            this.ViewAllBook.Click += new System.EventHandler(this.ViewAllBook_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.GridBookview);
            this.panel4.Location = new System.Drawing.Point(0, 151);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(664, 130);
            this.panel4.TabIndex = 19;
            // 
            // GridBookview
            // 
            this.GridBookview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridBookview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBookview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridBookview.Location = new System.Drawing.Point(0, 0);
            this.GridBookview.Name = "GridBookview";
            this.GridBookview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridBookview.Size = new System.Drawing.Size(664, 130);
            this.GridBookview.TabIndex = 17;
            this.GridBookview.Visible = false;
            this.GridBookview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridviewBooksearching_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SHowStudent);
            this.panel3.Controls.Add(this.showteacher);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.IssuedBook);
            this.panel3.Controls.Add(this.IssuetoTeacher);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 281);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(664, 32);
            this.panel3.TabIndex = 18;
            // 
            // SHowStudent
            // 
            this.SHowStudent.BackColor = System.Drawing.Color.Blue;
            this.SHowStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SHowStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SHowStudent.Location = new System.Drawing.Point(55, 4);
            this.SHowStudent.Name = "SHowStudent";
            this.SHowStudent.Size = new System.Drawing.Size(75, 23);
            this.SHowStudent.TabIndex = 15;
            this.SHowStudent.Text = "Students";
            this.SHowStudent.UseVisualStyleBackColor = false;
            this.SHowStudent.Click += new System.EventHandler(this.SHowStudent_Click);
            // 
            // showteacher
            // 
            this.showteacher.BackColor = System.Drawing.Color.Blue;
            this.showteacher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showteacher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showteacher.Location = new System.Drawing.Point(136, 4);
            this.showteacher.Name = "showteacher";
            this.showteacher.Size = new System.Drawing.Size(75, 23);
            this.showteacher.TabIndex = 14;
            this.showteacher.Text = "Teachers";
            this.showteacher.UseVisualStyleBackColor = false;
            this.showteacher.Click += new System.EventHandler(this.showteacher_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(496, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "RESET";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // IssuetoTeacher
            // 
            this.IssuetoTeacher.BackColor = System.Drawing.Color.GreenYellow;
            this.IssuetoTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssuetoTeacher.ForeColor = System.Drawing.Color.Black;
            this.IssuetoTeacher.Location = new System.Drawing.Point(579, 1);
            this.IssuetoTeacher.Name = "IssuetoTeacher";
            this.IssuetoTeacher.Size = new System.Drawing.Size(64, 29);
            this.IssuetoTeacher.TabIndex = 13;
            this.IssuetoTeacher.Text = "ISSUE";
            this.IssuetoTeacher.UseVisualStyleBackColor = false;
            this.IssuetoTeacher.Visible = false;
            this.IssuetoTeacher.Click += new System.EventHandler(this.IssuetoTeacher_Click);
            // 
            // IssuedBook
            // 
            this.IssuedBook.BackColor = System.Drawing.Color.GreenYellow;
            this.IssuedBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssuedBook.ForeColor = System.Drawing.Color.Black;
            this.IssuedBook.Location = new System.Drawing.Point(579, 1);
            this.IssuedBook.Name = "IssuedBook";
            this.IssuedBook.Size = new System.Drawing.Size(64, 29);
            this.IssuedBook.TabIndex = 13;
            this.IssuedBook.Text = "ISSUE";
            this.IssuedBook.UseVisualStyleBackColor = false;
            this.IssuedBook.Visible = false;
            this.IssuedBook.Click += new System.EventHandler(this.IssuedBook_Click);
            // 
            // txtBookSearch
            // 
            this.txtBookSearch.BorderRadius = 8;
            this.txtBookSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookSearch.DefaultText = "";
            this.txtBookSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBookSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBookSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBookSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookSearch.IconLeft = global::LibraryMS.Properties.Resources.Search;
            this.txtBookSearch.IconLeftSize = new System.Drawing.Size(22, 22);
            this.txtBookSearch.IconRightSize = new System.Drawing.Size(0, 0);
            this.txtBookSearch.Location = new System.Drawing.Point(116, 6);
            this.txtBookSearch.Name = "txtBookSearch";
            this.txtBookSearch.PasswordChar = '\0';
            this.txtBookSearch.PlaceholderText = "Search Books!";
            this.txtBookSearch.SelectedText = "";
            this.txtBookSearch.Size = new System.Drawing.Size(167, 23);
            this.txtBookSearch.TabIndex = 16;
            this.txtBookSearch.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            this.txtBookSearch.Click += new System.EventHandler(this.txtBookSearch_Click);
            // 
            // ClearbtnBk
            // 
            this.ClearbtnBk.BackColor = System.Drawing.Color.Red;
            this.ClearbtnBk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearbtnBk.ForeColor = System.Drawing.Color.White;
            this.ClearbtnBk.Location = new System.Drawing.Point(289, 33);
            this.ClearbtnBk.Name = "ClearbtnBk";
            this.ClearbtnBk.Size = new System.Drawing.Size(53, 29);
            this.ClearbtnBk.TabIndex = 6;
            this.ClearbtnBk.Text = "Clear";
            this.ClearbtnBk.UseVisualStyleBackColor = false;
            this.ClearbtnBk.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbookid
            // 
            this.txtbookid.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookid.Location = new System.Drawing.Point(116, 36);
            this.txtbookid.Name = "txtbookid";
            this.txtbookid.Size = new System.Drawing.Size(167, 24);
            this.txtbookid.TabIndex = 0;
            this.txtbookid.TextChanged += new System.EventHandler(this.textbookid_TextChanged);
            // 
            // txtremaining
            // 
            this.txtremaining.AutoSize = true;
            this.txtremaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtremaining.Location = new System.Drawing.Point(113, 127);
            this.txtremaining.Name = "txtremaining";
            this.txtremaining.Size = new System.Drawing.Size(17, 18);
            this.txtremaining.TabIndex = 3;
            this.txtremaining.Text = "0";
            this.txtremaining.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Remaining";
            this.label6.Visible = false;
            // 
            // txtPublisher
            // 
            this.txtPublisher.AutoSize = true;
            this.txtPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.Location = new System.Drawing.Point(113, 89);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(17, 18);
            this.txtPublisher.TabIndex = 3;
            this.txtPublisher.Text = "0";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(15, 89);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(78, 18);
            this.label33.TabIndex = 3;
            this.label33.Text = "Publisher";
            // 
            // TxtStatus
            // 
            this.TxtStatus.AutoSize = true;
            this.TxtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStatus.Location = new System.Drawing.Point(113, 111);
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.Size = new System.Drawing.Size(17, 18);
            this.TxtStatus.TabIndex = 3;
            this.TxtStatus.Text = "0";
            // 
            // stockbook
            // 
            this.stockbook.AutoSize = true;
            this.stockbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockbook.Location = new System.Drawing.Point(15, 111);
            this.stockbook.Name = "stockbook";
            this.stockbook.Size = new System.Drawing.Size(52, 18);
            this.stockbook.TabIndex = 3;
            this.stockbook.Text = "Stock";
            // 
            // PanelStudent
            // 
            this.PanelStudent.Controls.Add(this.viewAllStudent);
            this.PanelStudent.Controls.Add(this.txtstudentSearch);
            this.PanelStudent.Controls.Add(this.label8);
            this.PanelStudent.Controls.Add(this.label10);
            this.PanelStudent.Controls.Add(this.txtStuName);
            this.PanelStudent.Controls.Add(this.label11);
            this.PanelStudent.Controls.Add(this.txtsRno);
            this.PanelStudent.Controls.Add(this.ClearButton);
            this.PanelStudent.Controls.Add(this.label12);
            this.PanelStudent.Controls.Add(this.txtClass);
            this.PanelStudent.Controls.Add(this.txtSID);
            this.PanelStudent.Controls.Add(this.label4);
            this.PanelStudent.Controls.Add(this.AlreadyIssued);
            this.PanelStudent.Location = new System.Drawing.Point(367, -2);
            this.PanelStudent.Name = "PanelStudent";
            this.PanelStudent.Size = new System.Drawing.Size(388, 145);
            this.PanelStudent.TabIndex = 22;
            this.PanelStudent.Visible = false;
            // 
            // viewAllStudent
            // 
            this.viewAllStudent.BackColor = System.Drawing.SystemColors.WindowText;
            this.viewAllStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewAllStudent.ForeColor = System.Drawing.Color.White;
            this.viewAllStudent.Location = new System.Drawing.Point(306, 7);
            this.viewAllStudent.Name = "viewAllStudent";
            this.viewAllStudent.Size = new System.Drawing.Size(75, 23);
            this.viewAllStudent.TabIndex = 21;
            this.viewAllStudent.Text = "View All";
            this.viewAllStudent.UseVisualStyleBackColor = false;
            this.viewAllStudent.Click += new System.EventHandler(this.viewAllStudent_Click);
            // 
            // txtstudentSearch
            // 
            this.txtstudentSearch.BorderRadius = 8;
            this.txtstudentSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstudentSearch.DefaultText = "";
            this.txtstudentSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtstudentSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtstudentSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstudentSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstudentSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstudentSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtstudentSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstudentSearch.IconLeft = global::LibraryMS.Properties.Resources.Search;
            this.txtstudentSearch.IconLeftSize = new System.Drawing.Size(22, 22);
            this.txtstudentSearch.IconRightSize = new System.Drawing.Size(0, 0);
            this.txtstudentSearch.Location = new System.Drawing.Point(130, 7);
            this.txtstudentSearch.Name = "txtstudentSearch";
            this.txtstudentSearch.PasswordChar = '\0';
            this.txtstudentSearch.PlaceholderText = "Search Students!";
            this.txtstudentSearch.SelectedText = "";
            this.txtstudentSearch.Size = new System.Drawing.Size(167, 23);
            this.txtstudentSearch.TabIndex = 15;
            this.txtstudentSearch.TextChanged += new System.EventHandler(this.txtstudentSearchBox_TextChanged);
            this.txtstudentSearch.Click += new System.EventHandler(this.txtstudentSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Student ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "Student Name";
            // 
            // txtStuName
            // 
            this.txtStuName.AutoSize = true;
            this.txtStuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuName.Location = new System.Drawing.Point(133, 62);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(17, 18);
            this.txtStuName.TabIndex = 3;
            this.txtStuName.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 18);
            this.label11.TabIndex = 3;
            this.label11.Text = "Roll No";
            // 
            // txtsRno
            // 
            this.txtsRno.AutoSize = true;
            this.txtsRno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsRno.Location = new System.Drawing.Point(133, 85);
            this.txtsRno.Name = "txtsRno";
            this.txtsRno.Size = new System.Drawing.Size(17, 18);
            this.txtsRno.TabIndex = 3;
            this.txtsRno.Text = "0";
            this.txtsRno.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Red;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(306, 34);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(64, 26);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 18);
            this.label12.TabIndex = 3;
            this.label12.Text = "Class/Sem/Year";
            // 
            // txtClass
            // 
            this.txtClass.AutoSize = true;
            this.txtClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.Location = new System.Drawing.Point(133, 106);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(17, 18);
            this.txtClass.TabIndex = 3;
            this.txtClass.Text = "0";
            // 
            // txtSID
            // 
            this.txtSID.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSID.Location = new System.Drawing.Point(130, 36);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(167, 24);
            this.txtSID.TabIndex = 7;
            this.txtSID.TextChanged += new System.EventHandler(this.txtSID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Already Issued";
            // 
            // AlreadyIssued
            // 
            this.AlreadyIssued.AutoSize = true;
            this.AlreadyIssued.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlreadyIssued.Location = new System.Drawing.Point(133, 126);
            this.AlreadyIssued.Name = "AlreadyIssued";
            this.AlreadyIssued.Size = new System.Drawing.Size(17, 18);
            this.AlreadyIssued.TabIndex = 3;
            this.AlreadyIssued.Text = "0";
            // 
            // txtbookname
            // 
            this.txtbookname.AutoSize = true;
            this.txtbookname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookname.Location = new System.Drawing.Point(113, 67);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(17, 18);
            this.txtbookname.TabIndex = 3;
            this.txtbookname.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Book Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Book ID";
            // 
            // PanelTacher
            // 
            this.PanelTacher.Controls.Add(this.viewallTeacher);
            this.PanelTacher.Controls.Add(this.SearchTeacher);
            this.PanelTacher.Controls.Add(this.label5);
            this.PanelTacher.Controls.Add(this.label7);
            this.PanelTacher.Controls.Add(this.txtTName);
            this.PanelTacher.Controls.Add(this.label13);
            this.PanelTacher.Controls.Add(this.txtDepartment);
            this.PanelTacher.Controls.Add(this.cleaerbuttonTeacher);
            this.PanelTacher.Controls.Add(this.txtPno);
            this.PanelTacher.Controls.Add(this.TId);
            this.PanelTacher.Controls.Add(this.label17);
            this.PanelTacher.Controls.Add(this.ALreadyIssuedTeacher);
            this.PanelTacher.Controls.Add(this.label15);
            this.PanelTacher.Location = new System.Drawing.Point(367, 0);
            this.PanelTacher.Name = "PanelTacher";
            this.PanelTacher.Size = new System.Drawing.Size(400, 145);
            this.PanelTacher.TabIndex = 23;
            this.PanelTacher.Visible = false;
            // 
            // viewallTeacher
            // 
            this.viewallTeacher.BackColor = System.Drawing.SystemColors.WindowText;
            this.viewallTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewallTeacher.ForeColor = System.Drawing.Color.White;
            this.viewallTeacher.Location = new System.Drawing.Point(306, 7);
            this.viewallTeacher.Name = "viewallTeacher";
            this.viewallTeacher.Size = new System.Drawing.Size(75, 23);
            this.viewallTeacher.TabIndex = 21;
            this.viewallTeacher.Text = "View All";
            this.viewallTeacher.UseVisualStyleBackColor = false;
            this.viewallTeacher.Click += new System.EventHandler(this.viewallTeacher_Click);
            // 
            // SearchTeacher
            // 
            this.SearchTeacher.BorderRadius = 8;
            this.SearchTeacher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTeacher.DefaultText = "";
            this.SearchTeacher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchTeacher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchTeacher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTeacher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTeacher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTeacher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchTeacher.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTeacher.IconLeft = global::LibraryMS.Properties.Resources.Search;
            this.SearchTeacher.IconLeftSize = new System.Drawing.Size(22, 22);
            this.SearchTeacher.IconRightSize = new System.Drawing.Size(0, 0);
            this.SearchTeacher.Location = new System.Drawing.Point(130, 7);
            this.SearchTeacher.Name = "SearchTeacher";
            this.SearchTeacher.PasswordChar = '\0';
            this.SearchTeacher.PlaceholderText = "Search  Teacher!";
            this.SearchTeacher.SelectedText = "";
            this.SearchTeacher.Size = new System.Drawing.Size(167, 23);
            this.SearchTeacher.TabIndex = 15;
            this.SearchTeacher.TextChanged += new System.EventHandler(this.SearchTeacher_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Teacher Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Teacher Name";
            // 
            // txtTName
            // 
            this.txtTName.AutoSize = true;
            this.txtTName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTName.Location = new System.Drawing.Point(133, 62);
            this.txtTName.Name = "txtTName";
            this.txtTName.Size = new System.Drawing.Size(17, 18);
            this.txtTName.TabIndex = 3;
            this.txtTName.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 18);
            this.label13.TabIndex = 3;
            this.label13.Text = "Department";
            // 
            // txtDepartment
            // 
            this.txtDepartment.AutoSize = true;
            this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.Location = new System.Drawing.Point(133, 85);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(17, 18);
            this.txtDepartment.TabIndex = 3;
            this.txtDepartment.Text = "0";
            this.txtDepartment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cleaerbuttonTeacher
            // 
            this.cleaerbuttonTeacher.BackColor = System.Drawing.Color.Red;
            this.cleaerbuttonTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleaerbuttonTeacher.ForeColor = System.Drawing.Color.White;
            this.cleaerbuttonTeacher.Location = new System.Drawing.Point(306, 34);
            this.cleaerbuttonTeacher.Name = "cleaerbuttonTeacher";
            this.cleaerbuttonTeacher.Size = new System.Drawing.Size(64, 26);
            this.cleaerbuttonTeacher.TabIndex = 6;
            this.cleaerbuttonTeacher.Text = "Clear";
            this.cleaerbuttonTeacher.UseVisualStyleBackColor = false;
            this.cleaerbuttonTeacher.Click += new System.EventHandler(this.cleaerbuttonTeacher_Click);
            // 
            // txtPno
            // 
            this.txtPno.AutoSize = true;
            this.txtPno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPno.Location = new System.Drawing.Point(133, 106);
            this.txtPno.Name = "txtPno";
            this.txtPno.Size = new System.Drawing.Size(17, 18);
            this.txtPno.TabIndex = 3;
            this.txtPno.Text = "0";
            // 
            // TId
            // 
            this.TId.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TId.Location = new System.Drawing.Point(130, 36);
            this.TId.Name = "TId";
            this.TId.Size = new System.Drawing.Size(167, 24);
            this.TId.TabIndex = 7;
            this.TId.TextChanged += new System.EventHandler(this.txtIdbox_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 126);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 18);
            this.label17.TabIndex = 3;
            this.label17.Text = "Already Issued";
            // 
            // ALreadyIssuedTeacher
            // 
            this.ALreadyIssuedTeacher.AutoSize = true;
            this.ALreadyIssuedTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALreadyIssuedTeacher.Location = new System.Drawing.Point(133, 126);
            this.ALreadyIssuedTeacher.Name = "ALreadyIssuedTeacher";
            this.ALreadyIssuedTeacher.Size = new System.Drawing.Size(17, 18);
            this.ALreadyIssuedTeacher.TabIndex = 3;
            this.ALreadyIssuedTeacher.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 18);
            this.label15.TabIndex = 3;
            this.label15.Text = "P.NO";
            // 
            // UCIssueBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(PanelTeacher);
            this.Controls.Add(panel1);
            this.Name = "UCIssueBooks";
            this.Size = new System.Drawing.Size(664, 349);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PanelTeacher.ResumeLayout(false);
            PanelTeacher.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridBookview)).EndInit();
            this.panel3.ResumeLayout(false);
            this.PanelStudent.ResumeLayout(false);
            this.PanelStudent.PerformLayout();
            this.PanelTacher.ResumeLayout(false);
            this.PanelTacher.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbookid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label stockbook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button IssuedBook;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button ClearbtnBk;
        private System.Windows.Forms.Label txtremaining;
        private System.Windows.Forms.Label txtPublisher;
        private System.Windows.Forms.Label TxtStatus;
        private System.Windows.Forms.Label txtbookname;
        private Guna.UI2.WinForms.Guna2TextBox txtBookSearch;
        private System.Windows.Forms.DataGridView GridBookview;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ViewAllBook;
        private System.Windows.Forms.Button SHowStudent;
        private System.Windows.Forms.Button showteacher;
        private System.Windows.Forms.Button viewAllStudent;
        private Guna.UI2.WinForms.Guna2TextBox txtstudentSearch;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.Label AlreadyIssued;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtClass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtsRno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txtStuName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel PanelStudent;
        private System.Windows.Forms.Panel PanelTacher;
        private System.Windows.Forms.Button viewallTeacher;
        private Guna.UI2.WinForms.Guna2TextBox SearchTeacher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtTName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label txtDepartment;
        private System.Windows.Forms.Button cleaerbuttonTeacher;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label txtPno;
        private System.Windows.Forms.TextBox TId;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label ALreadyIssuedTeacher;
        private System.Windows.Forms.Button IssuetoTeacher;
    }
}
