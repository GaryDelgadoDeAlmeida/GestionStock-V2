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
            this.pnlEmployeesMenu = new System.Windows.Forms.Panel();
            this.btnEmployeesList = new System.Windows.Forms.Button();
            this.btnEmployeesDelete = new System.Windows.Forms.Button();
            this.btnEmployeesEdit = new System.Windows.Forms.Button();
            this.btnEmployeesNew = new System.Windows.Forms.Button();
            this.pnlEmployeesContainer = new System.Windows.Forms.Panel();
            this.pnlEmployeesMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEmployeesMenu
            // 
            this.pnlEmployeesMenu.Controls.Add(this.btnEmployeesList);
            this.pnlEmployeesMenu.Controls.Add(this.btnEmployeesDelete);
            this.pnlEmployeesMenu.Controls.Add(this.btnEmployeesEdit);
            this.pnlEmployeesMenu.Controls.Add(this.btnEmployeesNew);
            this.pnlEmployeesMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEmployeesMenu.Location = new System.Drawing.Point(0, 585);
            this.pnlEmployeesMenu.Name = "pnlEmployeesMenu";
            this.pnlEmployeesMenu.Size = new System.Drawing.Size(1200, 79);
            this.pnlEmployeesMenu.TabIndex = 0;
            // 
            // btnEmployeesList
            // 
            this.btnEmployeesList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmployeesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEmployeesList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeesList.Enabled = false;
            this.btnEmployeesList.FlatAppearance.BorderSize = 0;
            this.btnEmployeesList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEmployeesList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeesList.ForeColor = System.Drawing.Color.White;
            this.btnEmployeesList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeesList.Location = new System.Drawing.Point(810, 19);
            this.btnEmployeesList.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployeesList.Name = "btnEmployeesList";
            this.btnEmployeesList.Size = new System.Drawing.Size(200, 37);
            this.btnEmployeesList.TabIndex = 12;
            this.btnEmployeesList.Text = "List";
            this.btnEmployeesList.UseVisualStyleBackColor = false;
            this.btnEmployeesList.Click += new System.EventHandler(this.BtnEmployeesList_Click);
            // 
            // btnEmployeesDelete
            // 
            this.btnEmployeesDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmployeesDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEmployeesDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeesDelete.FlatAppearance.BorderSize = 0;
            this.btnEmployeesDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEmployeesDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeesDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeesDelete.ForeColor = System.Drawing.Color.White;
            this.btnEmployeesDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeesDelete.Location = new System.Drawing.Point(584, 19);
            this.btnEmployeesDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployeesDelete.Name = "btnEmployeesDelete";
            this.btnEmployeesDelete.Size = new System.Drawing.Size(200, 37);
            this.btnEmployeesDelete.TabIndex = 11;
            this.btnEmployeesDelete.Text = "Delete";
            this.btnEmployeesDelete.UseVisualStyleBackColor = false;
            this.btnEmployeesDelete.Click += new System.EventHandler(this.BtnEmployeesDelete_Click);
            // 
            // btnEmployeesEdit
            // 
            this.btnEmployeesEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmployeesEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEmployeesEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeesEdit.FlatAppearance.BorderSize = 0;
            this.btnEmployeesEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEmployeesEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeesEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeesEdit.ForeColor = System.Drawing.Color.White;
            this.btnEmployeesEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeesEdit.Location = new System.Drawing.Point(358, 19);
            this.btnEmployeesEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployeesEdit.Name = "btnEmployeesEdit";
            this.btnEmployeesEdit.Size = new System.Drawing.Size(200, 37);
            this.btnEmployeesEdit.TabIndex = 10;
            this.btnEmployeesEdit.Text = "Edit";
            this.btnEmployeesEdit.UseVisualStyleBackColor = false;
            this.btnEmployeesEdit.Click += new System.EventHandler(this.BtnEmployeesEdit_Click);
            // 
            // btnEmployeesNew
            // 
            this.btnEmployeesNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmployeesNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEmployeesNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeesNew.FlatAppearance.BorderSize = 0;
            this.btnEmployeesNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEmployeesNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeesNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeesNew.ForeColor = System.Drawing.Color.White;
            this.btnEmployeesNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeesNew.Location = new System.Drawing.Point(131, 19);
            this.btnEmployeesNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployeesNew.Name = "btnEmployeesNew";
            this.btnEmployeesNew.Size = new System.Drawing.Size(200, 37);
            this.btnEmployeesNew.TabIndex = 9;
            this.btnEmployeesNew.Text = "Add";
            this.btnEmployeesNew.UseVisualStyleBackColor = false;
            this.btnEmployeesNew.Click += new System.EventHandler(this.BtnEmployeesNew_Click);
            // 
            // pnlEmployeesContainer
            // 
            this.pnlEmployeesContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmployeesContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlEmployeesContainer.Name = "pnlEmployeesContainer";
            this.pnlEmployeesContainer.Size = new System.Drawing.Size(1200, 585);
            this.pnlEmployeesContainer.TabIndex = 1;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 664);
            this.Controls.Add(this.pnlEmployeesContainer);
            this.Controls.Add(this.pnlEmployeesMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employees";
            this.Text = "Employees";
            this.pnlEmployeesMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmployeesMenu;
        private System.Windows.Forms.Panel pnlEmployeesContainer;
        private System.Windows.Forms.Button btnEmployeesNew;
        private System.Windows.Forms.Button btnEmployeesList;
        private System.Windows.Forms.Button btnEmployeesDelete;
        private System.Windows.Forms.Button btnEmployeesEdit;
    }
}