namespace LibraryMS.Windows_Form
{
    partial class ViewAllStudent
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
            this.ViewAllstudentGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrintButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ExportToCsvButton = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAllstudentGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewAllstudentGrid
            // 
            this.ViewAllstudentGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ViewAllstudentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewAllstudentGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewAllstudentGrid.Location = new System.Drawing.Point(0, 0);
            this.ViewAllstudentGrid.Name = "ViewAllstudentGrid";
            this.ViewAllstudentGrid.Size = new System.Drawing.Size(944, 416);
            this.ViewAllstudentGrid.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ExportToCsvButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.PrintButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 42);
            this.panel1.TabIndex = 1;
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(589, 7);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 0;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 43);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.ViewAllstudentGrid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(944, 416);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Export to CSV";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ExportToCsvButton
            // 
            this.ExportToCsvButton.FormattingEnabled = true;
            this.ExportToCsvButton.Items.AddRange(new object[] {
            "Export To CSV"});
            this.ExportToCsvButton.Location = new System.Drawing.Point(307, 7);
            this.ExportToCsvButton.Name = "ExportToCsvButton";
            this.ExportToCsvButton.Size = new System.Drawing.Size(121, 21);
            this.ExportToCsvButton.TabIndex = 3;
            // 
            // ViewAllStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewAllStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAllStudent";
            this.Load += new System.EventHandler(this.ViewAllStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewAllstudentGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.DataGridView ViewAllstudentGrid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.ComboBox ExportToCsvButton;
        private System.Windows.Forms.Button button1;
    }
}