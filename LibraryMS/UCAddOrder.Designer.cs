namespace LibraryMS
{
    partial class UCAddOrder
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
            System.Windows.Forms.Panel panel2;
            System.Windows.Forms.Label label1;
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(664, 54);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 54);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(664, 295);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(258, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(112, 25);
            label1.TabIndex = 0;
            label1.Text = "Add Order";
            // 
            // UCAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(panel2);
            this.Controls.Add(panel1);
            this.Name = "UCAddOrder";
            this.Size = new System.Drawing.Size(664, 349);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
