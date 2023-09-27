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
            this.label8 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblIssuedate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblissueid = new System.Windows.Forms.Label();
            this.lblIssueby = new System.Windows.Forms.Label();
            this.lblsid = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblbookname = new System.Windows.Forms.Label();
            this.lblsname = new System.Windows.Forms.Label();
            this.lblbookid = new System.Windows.Forms.Label();
            this.lblrno = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblclasssem = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridIssuebook)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.GridIssuebook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridIssuebook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridIssuebook.Cursor = System.Windows.Forms.Cursors.Cross;
            this.GridIssuebook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridIssuebook.Location = new System.Drawing.Point(0, 88);
            this.GridIssuebook.Name = "GridIssuebook";
            this.GridIssuebook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridIssuebook.Size = new System.Drawing.Size(664, 198);
            this.GridIssuebook.TabIndex = 0;
            this.GridIssuebook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridIssuebook_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lbl);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.lblIssuedate);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lblissueid);
            this.panel3.Controls.Add(this.lblIssueby);
            this.panel3.Controls.Add(this.lblsid);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.lblbookname);
            this.panel3.Controls.Add(this.lblsname);
            this.panel3.Controls.Add(this.lblbookid);
            this.panel3.Controls.Add(this.lblrno);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblclasssem);
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
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(59, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Student ID";
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
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 21);
            this.label10.TabIndex = 6;
            this.label10.Text = "Student Name";
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
            // lblsid
            // 
            this.lblsid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsid.AutoSize = true;
            this.lblsid.BackColor = System.Drawing.Color.White;
            this.lblsid.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsid.ForeColor = System.Drawing.Color.Black;
            this.lblsid.Location = new System.Drawing.Point(197, 1);
            this.lblsid.Name = "lblsid";
            this.lblsid.Size = new System.Drawing.Size(20, 21);
            this.lblsid.TabIndex = 7;
            this.lblsid.Text = "0";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(59, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 21);
            this.label11.TabIndex = 5;
            this.label11.Text = "Roll No";
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
            // lblsname
            // 
            this.lblsname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsname.AutoSize = true;
            this.lblsname.BackColor = System.Drawing.Color.White;
            this.lblsname.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsname.ForeColor = System.Drawing.Color.Black;
            this.lblsname.Location = new System.Drawing.Point(197, 19);
            this.lblsname.Name = "lblsname";
            this.lblsname.Size = new System.Drawing.Size(20, 21);
            this.lblsname.TabIndex = 6;
            this.lblsname.Text = "0";
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
            // lblrno
            // 
            this.lblrno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblrno.AutoSize = true;
            this.lblrno.BackColor = System.Drawing.Color.White;
            this.lblrno.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrno.ForeColor = System.Drawing.Color.Black;
            this.lblrno.Location = new System.Drawing.Point(197, 37);
            this.lblrno.Name = "lblrno";
            this.lblrno.Size = new System.Drawing.Size(20, 21);
            this.lblrno.TabIndex = 5;
            this.lblrno.Text = "0";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(59, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 21);
            this.label12.TabIndex = 4;
            this.label12.Text = "Class/Sem/Year";
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
            // lblclasssem
            // 
            this.lblclasssem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblclasssem.AutoSize = true;
            this.lblclasssem.BackColor = System.Drawing.Color.White;
            this.lblclasssem.Font = new System.Drawing.Font("Bookshelf Symbol 7", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclasssem.ForeColor = System.Drawing.Color.Black;
            this.lblclasssem.Location = new System.Drawing.Point(197, 55);
            this.lblclasssem.Name = "lblclasssem";
            this.lblclasssem.Size = new System.Drawing.Size(20, 21);
            this.lblclasssem.TabIndex = 4;
            this.lblclasssem.Text = "0";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnReturn);
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 286);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(664, 33);
            this.panel4.TabIndex = 13;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.UserXmark;
            this.btnReturn.IconColor = System.Drawing.Color.White;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 30;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(334, 0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(98, 33);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnClear.IconColor = System.Drawing.Color.White;
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.IconSize = 20;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(234, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 30);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.panel4.ResumeLayout(false);
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
    }
}
