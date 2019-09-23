namespace InterfaceUserModern2.View
{
    partial class Reports
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
            this.pnlSubMenu = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSubMenu
            // 
            this.pnlSubMenu.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSubMenu.Controls.Add(this.button2);
            this.pnlSubMenu.Controls.Add(this.button1);
            this.pnlSubMenu.Controls.Add(this.btnReport);
            this.pnlSubMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSubMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSubMenu.Name = "pnlSubMenu";
            this.pnlSubMenu.Size = new System.Drawing.Size(224, 603);
            this.pnlSubMenu.TabIndex = 0;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(224, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(976, 603);
            this.pnlContainer.TabIndex = 1;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(12, 128);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(200, 37);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "Report Sales";
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Report Shopping";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Report Payments";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 603);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlSubMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.Text = "Reports";
            this.pnlSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSubMenu;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}