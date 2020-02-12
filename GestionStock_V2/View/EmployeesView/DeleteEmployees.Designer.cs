namespace GestionStock_V2.View.EmployeesView
{
    partial class DeleteEmployees
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
            this.cmbDeleteEmployee = new System.Windows.Forms.ComboBox();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDeleteEmployee
            // 
            this.cmbDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDeleteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeleteEmployee.FormattingEnabled = true;
            this.cmbDeleteEmployee.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmbDeleteEmployee.Location = new System.Drawing.Point(466, 247);
            this.cmbDeleteEmployee.Name = "cmbDeleteEmployee";
            this.cmbDeleteEmployee.Size = new System.Drawing.Size(325, 33);
            this.cmbDeleteEmployee.TabIndex = 1;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteEmployee.FlatAppearance.BorderSize = 0;
            this.btnDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(523, 354);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(208, 42);
            this.btnDeleteEmployee.TabIndex = 2;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = false;
            // 
            // DeleteEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 585);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.cmbDeleteEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteEmployees";
            this.Text = "DeleteEmployees";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbDeleteEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
    }
}