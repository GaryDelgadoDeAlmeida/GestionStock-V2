namespace InterfaceUserModern2.View
{
    partial class Sales
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
            this.txtSales = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSales
            // 
            this.txtSales.AutoSize = true;
            this.txtSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSales.Location = new System.Drawing.Point(539, 193);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(150, 58);
            this.txtSales.TabIndex = 0;
            this.txtSales.Text = "Sales";
            this.txtSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInfo
            // 
            this.txtInfo.AutoSize = true;
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.Location = new System.Drawing.Point(315, 262);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(594, 29);
            this.txtInfo.TabIndex = 1;
            this.txtInfo.Text = "I\'m actually working for this page, please be patient.";
            this.txtInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 603);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtSales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales";
            this.Text = "Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtSales;
        private System.Windows.Forms.Label txtInfo;
    }
}