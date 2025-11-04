namespace LibraryMS
{
    partial class UCStatus
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GridIssuebook = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIssuedate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblissueid = new System.Windows.Forms.Label();
            this.lblIssueby = new System.Windows.Forms.Label();
            this.lblbookname = new System.Windows.Forms.Label();
            this.lblbookid = new System.Windows.Forms.Label();
            this.Lateindays = new System.Windows.Forms.Label();
            this.lateReturn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelTeacherReturn = new System.Windows.Forms.Panel();
            this.lable33 = new System.Windows.Forms.Label();
            this.LblPno = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblDepartment = new System.Windows.Forms.Label();
            this.lblTName = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblTid = new System.Windows.Forms.Label();
            this.PanelStudentReturn = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblclasssem = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblrno = new System.Windows.Forms.Label();
            this.lblsname = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblsid = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NotReturnTeacher = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TeachersMark = new System.Windows.Forms.RadioButton();
            this.StudentsMark = new System.Windows.Forms.RadioButton();
            this.btnshowall = new System.Windows.Forms.Button();
            this.btnNoReturn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIewHIstoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.ShowAllTeacher = new System.Windows.Forms.Button();
            this.ReturnFromTEacher = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridIssuebook)).BeginInit();
            this.panel3.SuspendLayout();
            this.PanelTeacherReturn.SuspendLayout();
            this.PanelStudentReturn.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Return Books";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.GridIssuebook);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(664, 319);
            this.panel2.TabIndex = 3;
            // 
            // GridIssuebook
            // 
            this.GridIssuebook.AllowUserToAddRows = false;
            this.GridIssuebook.AllowUserToOrderColumns = true;
            this.GridIssuebook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridIssuebook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridIssuebook.Cursor = System.Windows.Forms.Cursors.Cross;
            this.GridIssuebook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridIssuebook.Location = new System.Drawing.Point(0, 88);
            this.GridIssuebook.MultiSelect = false;
            this.GridIssuebook.Name = "GridIssuebook";
            this.GridIssuebook.ReadOnly = true;
            this.GridIssuebook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridIssuebook.Size = new System.Drawing.Size(664, 199);
            this.GridIssuebook.StandardTab = true;
            this.GridIssuebook.TabIndex = 0;
            this.GridIssuebook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridIssuebook_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lbl);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lblIssuedate);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lblissueid);
            this.panel3.Controls.Add(this.lblIssueby);
            this.panel3.Controls.Add(this.lblbookname);
            this.panel3.Controls.Add(this.lblbookid);
            this.panel3.Controls.Add(this.Lateindays);
            this.panel3.Controls.Add(this.lateReturn);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.PanelTeacherReturn);
            this.panel3.Controls.Add(this.PanelStudentReturn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(664, 88);
            this.panel3.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Book Name";
            // 
            // lbl
            // 
            this.lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(359, 54);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(95, 21);
            this.lbl.TabIndex = 8;
            this.lbl.Text = "Issue Date";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(359, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Issue By";
            // 
            // lblIssuedate
            // 
            this.lblIssuedate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIssuedate.AutoSize = true;
            this.lblIssuedate.BackColor = System.Drawing.Color.White;
            this.lblIssuedate.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssuedate.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblIssuedate.Location = new System.Drawing.Point(462, 54);
            this.lblIssuedate.Name = "lblIssuedate";
            this.lblIssuedate.Size = new System.Drawing.Size(20, 21);
            this.lblIssuedate.TabIndex = 9;
            this.lblIssuedate.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "IssueId";
            // 
            // lblissueid
            // 
            this.lblissueid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblissueid.AutoSize = true;
            this.lblissueid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblissueid.Location = new System.Drawing.Point(3, 26);
            this.lblissueid.Name = "lblissueid";
            this.lblissueid.Size = new System.Drawing.Size(24, 25);
            this.lblissueid.TabIndex = 9;
            this.lblissueid.Text = "0";
            // 
            // lblIssueby
            // 
            this.lblIssueby.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIssueby.AutoSize = true;
            this.lblIssueby.BackColor = System.Drawing.Color.White;
            this.lblIssueby.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueby.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblIssueby.Location = new System.Drawing.Point(462, 36);
            this.lblIssueby.Name = "lblIssueby";
            this.lblIssueby.Size = new System.Drawing.Size(20, 21);
            this.lblIssueby.TabIndex = 9;
            this.lblIssueby.Text = "0";
            // 
            // lblbookname
            // 
            this.lblbookname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblbookname.AutoSize = true;
            this.lblbookname.BackColor = System.Drawing.Color.White;
            this.lblbookname.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbookname.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblbookname.Location = new System.Drawing.Point(462, 18);
            this.lblbookname.Name = "lblbookname";
            this.lblbookname.Size = new System.Drawing.Size(20, 21);
            this.lblbookname.TabIndex = 10;
            this.lblbookname.Text = "0";
            // 
            // lblbookid
            // 
            this.lblbookid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblbookid.AutoSize = true;
            this.lblbookid.BackColor = System.Drawing.Color.White;
            this.lblbookid.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbookid.ForeColor = System.Drawing.Color.Black;
            this.lblbookid.Location = new System.Drawing.Point(462, 0);
            this.lblbookid.Name = "lblbookid";
            this.lblbookid.Size = new System.Drawing.Size(20, 21);
            this.lblbookid.TabIndex = 11;
            this.lblbookid.Text = "0";
            // 
            // Lateindays
            // 
            this.Lateindays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lateindays.AutoSize = true;
            this.Lateindays.BackColor = System.Drawing.Color.White;
            this.Lateindays.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lateindays.Location = new System.Drawing.Point(609, 2);
            this.Lateindays.Name = "Lateindays";
            this.Lateindays.Size = new System.Drawing.Size(20, 21);
            this.Lateindays.TabIndex = 11;
            this.Lateindays.Text = "0";
            // 
            // lateReturn
            // 
            this.lateReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lateReturn.AutoSize = true;
            this.lateReturn.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lateReturn.Location = new System.Drawing.Point(561, 1);
            this.lateReturn.Name = "lateReturn";
            this.lateReturn.Size = new System.Drawing.Size(45, 21);
            this.lateReturn.TabIndex = 11;
            this.lateReturn.Text = "Late";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Book ID";
            // 
            // PanelTeacherReturn
            // 
            this.PanelTeacherReturn.Controls.Add(this.lable33);
            this.PanelTeacherReturn.Controls.Add(this.LblPno);
            this.PanelTeacherReturn.Controls.Add(this.label9);
            this.PanelTeacherReturn.Controls.Add(this.LblDepartment);
            this.PanelTeacherReturn.Controls.Add(this.lblTName);
            this.PanelTeacherReturn.Controls.Add(this.label15);
            this.PanelTeacherReturn.Controls.Add(this.label16);
            this.PanelTeacherReturn.Controls.Add(this.lblTid);
            this.PanelTeacherReturn.Location = new System.Drawing.Point(55, 2);
            this.PanelTeacherReturn.Name = "PanelTeacherReturn";
            this.PanelTeacherReturn.Size = new System.Drawing.Size(304, 79);
            this.PanelTeacherReturn.TabIndex = 14;
            this.PanelTeacherReturn.Visible = false;
            // 
            // lable33
            // 
            this.lable33.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lable33.AutoSize = true;
            this.lable33.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable33.Location = new System.Drawing.Point(1, 0);
            this.lable33.Name = "lable33";
            this.lable33.Size = new System.Drawing.Size(97, 21);
            this.lable33.TabIndex = 7;
            this.lable33.Text = "Teacher ID";
            // 
            // LblPno
            // 
            this.LblPno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPno.AutoSize = true;
            this.LblPno.BackColor = System.Drawing.Color.White;
            this.LblPno.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPno.ForeColor = System.Drawing.Color.Black;
            this.LblPno.Location = new System.Drawing.Point(141, 54);
            this.LblPno.Name = "LblPno";
            this.LblPno.Size = new System.Drawing.Size(20, 21);
            this.LblPno.TabIndex = 4;
            this.LblPno.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "P.NO";
            // 
            // LblDepartment
            // 
            this.LblDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDepartment.AutoSize = true;
            this.LblDepartment.BackColor = System.Drawing.Color.White;
            this.LblDepartment.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDepartment.ForeColor = System.Drawing.Color.Black;
            this.LblDepartment.Location = new System.Drawing.Point(141, 36);
            this.LblDepartment.Name = "LblDepartment";
            this.LblDepartment.Size = new System.Drawing.Size(20, 21);
            this.LblDepartment.TabIndex = 5;
            this.LblDepartment.Text = "0";
            // 
            // lblTName
            // 
            this.lblTName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTName.AutoSize = true;
            this.lblTName.BackColor = System.Drawing.Color.White;
            this.lblTName.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTName.ForeColor = System.Drawing.Color.Black;
            this.lblTName.Location = new System.Drawing.Point(141, 18);
            this.lblTName.Name = "lblTName";
            this.lblTName.Size = new System.Drawing.Size(20, 21);
            this.lblTName.TabIndex = 6;
            this.lblTName.Text = "0";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 21);
            this.label15.TabIndex = 6;
            this.label15.Text = "Teachert Name";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 21);
            this.label16.TabIndex = 5;
            this.label16.Text = "Department";
            // 
            // lblTid
            // 
            this.lblTid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTid.AutoSize = true;
            this.lblTid.BackColor = System.Drawing.Color.White;
            this.lblTid.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTid.ForeColor = System.Drawing.Color.Black;
            this.lblTid.Location = new System.Drawing.Point(141, 0);
            this.lblTid.Name = "lblTid";
            this.lblTid.Size = new System.Drawing.Size(20, 21);
            this.lblTid.TabIndex = 7;
            this.lblTid.Text = "0";
            // 
            // PanelStudentReturn
            // 
            this.PanelStudentReturn.Controls.Add(this.label8);
            this.PanelStudentReturn.Controls.Add(this.lblclasssem);
            this.PanelStudentReturn.Controls.Add(this.label12);
            this.PanelStudentReturn.Controls.Add(this.lblrno);
            this.PanelStudentReturn.Controls.Add(this.lblsname);
            this.PanelStudentReturn.Controls.Add(this.label10);
            this.PanelStudentReturn.Controls.Add(this.label11);
            this.PanelStudentReturn.Controls.Add(this.lblsid);
            this.PanelStudentReturn.Location = new System.Drawing.Point(57, 3);
            this.PanelStudentReturn.Name = "PanelStudentReturn";
            this.PanelStudentReturn.Size = new System.Drawing.Size(304, 79);
            this.PanelStudentReturn.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Student ID";
            // 
            // lblclasssem
            // 
            this.lblclasssem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblclasssem.AutoSize = true;
            this.lblclasssem.BackColor = System.Drawing.Color.White;
            this.lblclasssem.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclasssem.ForeColor = System.Drawing.Color.Black;
            this.lblclasssem.Location = new System.Drawing.Point(141, 54);
            this.lblclasssem.Name = "lblclasssem";
            this.lblclasssem.Size = new System.Drawing.Size(20, 21);
            this.lblclasssem.TabIndex = 4;
            this.lblclasssem.Text = "0";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 21);
            this.label12.TabIndex = 4;
            this.label12.Text = "Class/Sem/Year";
            // 
            // lblrno
            // 
            this.lblrno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblrno.AutoSize = true;
            this.lblrno.BackColor = System.Drawing.Color.White;
            this.lblrno.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrno.ForeColor = System.Drawing.Color.Black;
            this.lblrno.Location = new System.Drawing.Point(141, 36);
            this.lblrno.Name = "lblrno";
            this.lblrno.Size = new System.Drawing.Size(20, 21);
            this.lblrno.TabIndex = 5;
            this.lblrno.Text = "0";
            // 
            // lblsname
            // 
            this.lblsname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsname.AutoSize = true;
            this.lblsname.BackColor = System.Drawing.Color.White;
            this.lblsname.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsname.ForeColor = System.Drawing.Color.Black;
            this.lblsname.Location = new System.Drawing.Point(141, 18);
            this.lblsname.Name = "lblsname";
            this.lblsname.Size = new System.Drawing.Size(20, 21);
            this.lblsname.TabIndex = 6;
            this.lblsname.Text = "0";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 21);
            this.label10.TabIndex = 6;
            this.label10.Text = "Student Name";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 21);
            this.label11.TabIndex = 5;
            this.label11.Text = "Roll No";
            // 
            // lblsid
            // 
            this.lblsid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsid.AutoSize = true;
            this.lblsid.BackColor = System.Drawing.Color.White;
            this.lblsid.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsid.ForeColor = System.Drawing.Color.Black;
            this.lblsid.Location = new System.Drawing.Point(141, 0);
            this.lblsid.Name = "lblsid";
            this.lblsid.Size = new System.Drawing.Size(20, 21);
            this.lblsid.TabIndex = 7;
            this.lblsid.Text = "0";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.btnshowall);
            this.panel4.Controls.Add(this.btnNoReturn);
            this.panel4.Controls.Add(this.menuStrip1);
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.btnReturn);
            this.panel4.Controls.Add(this.ShowAllTeacher);
            this.panel4.Controls.Add(this.ReturnFromTEacher);
            this.panel4.Controls.Add(this.NotReturnTeacher);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 287);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(664, 32);
            this.panel4.TabIndex = 13;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // NotReturnTeacher
            // 
            this.NotReturnTeacher.BackColor = System.Drawing.Color.DodgerBlue;
            this.NotReturnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotReturnTeacher.ForeColor = System.Drawing.Color.White;
            this.NotReturnTeacher.Location = new System.Drawing.Point(369, 2);
            this.NotReturnTeacher.Name = "NotReturnTeacher";
            this.NotReturnTeacher.Size = new System.Drawing.Size(75, 23);
            this.NotReturnTeacher.TabIndex = 3;
            this.NotReturnTeacher.Text = "Late (7days)";
            this.NotReturnTeacher.UseVisualStyleBackColor = false;
            this.NotReturnTeacher.Visible = false;
            this.NotReturnTeacher.Click += new System.EventHandler(this.NotReturnTeacher_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.TeachersMark);
            this.panel5.Controls.Add(this.StudentsMark);
            this.panel5.Location = new System.Drawing.Point(80, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 20);
            this.panel5.TabIndex = 6;
            // 
            // TeachersMark
            // 
            this.TeachersMark.AutoSize = true;
            this.TeachersMark.Location = new System.Drawing.Point(91, 3);
            this.TeachersMark.Name = "TeachersMark";
            this.TeachersMark.Size = new System.Drawing.Size(70, 17);
            this.TeachersMark.TabIndex = 5;
            this.TeachersMark.TabStop = true;
            this.TeachersMark.Text = "Teahcers";
            this.TeachersMark.UseVisualStyleBackColor = true;
            this.TeachersMark.CheckedChanged += new System.EventHandler(this.TeachersMark_CheckedChanged);
            // 
            // StudentsMark
            // 
            this.StudentsMark.AutoSize = true;
            this.StudentsMark.Checked = true;
            this.StudentsMark.Location = new System.Drawing.Point(10, 3);
            this.StudentsMark.Name = "StudentsMark";
            this.StudentsMark.Size = new System.Drawing.Size(67, 17);
            this.StudentsMark.TabIndex = 5;
            this.StudentsMark.TabStop = true;
            this.StudentsMark.Text = "Students";
            this.StudentsMark.UseVisualStyleBackColor = true;
            this.StudentsMark.CheckedChanged += new System.EventHandler(this.StudentsMark_CheckedChanged);
            // 
            // btnshowall
            // 
            this.btnshowall.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnshowall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshowall.ForeColor = System.Drawing.Color.White;
            this.btnshowall.Location = new System.Drawing.Point(288, 2);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(75, 23);
            this.btnshowall.TabIndex = 4;
            this.btnshowall.Text = "Show All";
            this.btnshowall.UseVisualStyleBackColor = false;
            this.btnshowall.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNoReturn
            // 
            this.btnNoReturn.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNoReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoReturn.ForeColor = System.Drawing.Color.White;
            this.btnNoReturn.Location = new System.Drawing.Point(369, 2);
            this.btnNoReturn.Name = "btnNoReturn";
            this.btnNoReturn.Size = new System.Drawing.Size(75, 23);
            this.btnNoReturn.TabIndex = 3;
            this.btnNoReturn.Text = "Not Return";
            this.btnNoReturn.UseVisualStyleBackColor = false;
            this.btnNoReturn.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.GhostWhite;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(74, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToCSVToolStripMenuItem,
            this.printToolStripMenuItem,
            this.vIewHIstoryToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // exportToCSVToolStripMenuItem
            // 
            this.exportToCSVToolStripMenuItem.Name = "exportToCSVToolStripMenuItem";
            this.exportToCSVToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToCSVToolStripMenuItem.Text = "Export To CSV";
            this.exportToCSVToolStripMenuItem.Click += new System.EventHandler(this.exportToCSVToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // vIewHIstoryToolStripMenuItem
            // 
            this.vIewHIstoryToolStripMenuItem.Name = "vIewHIstoryToolStripMenuItem";
            this.vIewHIstoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vIewHIstoryToolStripMenuItem.Text = "VIew HIstory";
            this.vIewHIstoryToolStripMenuItem.Click += new System.EventHandler(this.vIewHIstoryToolStripMenuItem_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnClear.IconColor = System.Drawing.Color.White;
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.IconSize = 20;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(483, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 27);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.UserXmark;
            this.btnReturn.IconColor = System.Drawing.Color.White;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 25;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(573, -2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(88, 30);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // ShowAllTeacher
            // 
            this.ShowAllTeacher.BackColor = System.Drawing.Color.DodgerBlue;
            this.ShowAllTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowAllTeacher.ForeColor = System.Drawing.Color.White;
            this.ShowAllTeacher.Location = new System.Drawing.Point(285, 2);
            this.ShowAllTeacher.Name = "ShowAllTeacher";
            this.ShowAllTeacher.Size = new System.Drawing.Size(75, 23);
            this.ShowAllTeacher.TabIndex = 4;
            this.ShowAllTeacher.Text = "Show All";
            this.ShowAllTeacher.UseVisualStyleBackColor = false;
            this.ShowAllTeacher.Visible = false;
            this.ShowAllTeacher.Click += new System.EventHandler(this.ShowAllTeacher_Click);
            // 
            // ReturnFromTEacher
            // 
            this.ReturnFromTEacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnFromTEacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ReturnFromTEacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnFromTEacher.ForeColor = System.Drawing.Color.White;
            this.ReturnFromTEacher.IconChar = FontAwesome.Sharp.IconChar.UserXmark;
            this.ReturnFromTEacher.IconColor = System.Drawing.Color.White;
            this.ReturnFromTEacher.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReturnFromTEacher.IconSize = 25;
            this.ReturnFromTEacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReturnFromTEacher.Location = new System.Drawing.Point(573, -1);
            this.ReturnFromTEacher.Name = "ReturnFromTEacher";
            this.ReturnFromTEacher.Size = new System.Drawing.Size(88, 30);
            this.ReturnFromTEacher.TabIndex = 1;
            this.ReturnFromTEacher.Text = "Return";
            this.ReturnFromTEacher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReturnFromTEacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReturnFromTEacher.UseVisualStyleBackColor = false;
            this.ReturnFromTEacher.Click += new System.EventHandler(this.ReturnFromTEacher_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 30);
            this.panel1.TabIndex = 2;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UCStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCStatus";
            this.Size = new System.Drawing.Size(664, 349);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridIssuebook)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PanelTeacherReturn.ResumeLayout(false);
            this.PanelTeacherReturn.PerformLayout();
            this.PanelStudentReturn.ResumeLayout(false);
            this.PanelStudentReturn.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblIssueby;
        private System.Windows.Forms.Label lblbookname;
        private System.Windows.Forms.Label lblbookid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblclasssem;
        private System.Windows.Forms.Label lblrno;
        private System.Windows.Forms.Label lblsname;
        private System.Windows.Forms.Label lblsid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView GridIssuebook;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblissueid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblIssuedate;
        private FontAwesome.Sharp.IconButton btnClear;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnReturn;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIewHIstoryToolStripMenuItem;
        private System.Windows.Forms.Button btnshowall;
        private System.Windows.Forms.Button btnNoReturn;
        private System.Windows.Forms.Label Lateindays;
        private System.Windows.Forms.Label lateReturn;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton ReturnFromTEacher;
        private System.Windows.Forms.Panel PanelStudentReturn;
        private System.Windows.Forms.Panel PanelTeacherReturn;
        private System.Windows.Forms.Label lable33;
        private System.Windows.Forms.Label LblPno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblDepartment;
        private System.Windows.Forms.Label lblTName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblTid;
        protected internal System.Windows.Forms.RadioButton TeachersMark;
        protected internal System.Windows.Forms.RadioButton StudentsMark;
        private System.Windows.Forms.Button NotReturnTeacher;
        private System.Windows.Forms.Button ShowAllTeacher;
    }
}
