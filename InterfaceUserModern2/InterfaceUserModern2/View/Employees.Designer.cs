namespace InterfaceUserModern2.View
{
    partial class Employees
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
            this.txtEmployes = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmployes
            // 
            this.txtEmployes.AutoSize = true;
            this.txtEmployes.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployes.Location = new System.Drawing.Point(490, 208);
            this.txtEmployes.Name = "txtEmployes";
            this.txtEmployes.Size = new System.Drawing.Size(245, 58);
            this.txtEmployes.TabIndex = 0;
            this.txtEmployes.Text = "Employes";
            this.txtEmployes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInfo
            // 
            this.txtInfo.AutoSize = true;
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.Location = new System.Drawing.Point(318, 277);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(594, 29);
            this.txtInfo.TabIndex = 1;
            this.txtInfo.Text = "I\'m actually working for this page, please be patient.";
            this.txtInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 603);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtEmployes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employees";
            this.Text = "Employees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtEmployes;
        private System.Windows.Forms.Label txtInfo;
    }
}