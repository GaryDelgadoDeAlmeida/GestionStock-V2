namespace InterfaceUserModern2.View
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.txtHour = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.Label();
            this.hourDate = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtHour
            // 
            this.txtHour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHour.AutoSize = true;
            this.txtHour.BackColor = System.Drawing.SystemColors.Control;
            this.txtHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtHour.Location = new System.Drawing.Point(374, 196);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(318, 113);
            this.txtHour.TabIndex = 0;
            this.txtHour.Text = "label1";
            this.txtHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDate
            // 
            this.txtDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDate.AutoSize = true;
            this.txtDate.BackColor = System.Drawing.SystemColors.Control;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.SlateGray;
            this.txtDate.Location = new System.Drawing.Point(295, 320);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(159, 58);
            this.txtDate.TabIndex = 1;
            this.txtDate.Text = "label1";
            this.txtDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hourDate
            // 
            this.hourDate.Enabled = true;
            this.hourDate.Tick += new System.EventHandler(this.HourDate_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 664);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtHour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtHour;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.Timer hourDate;
    }
}