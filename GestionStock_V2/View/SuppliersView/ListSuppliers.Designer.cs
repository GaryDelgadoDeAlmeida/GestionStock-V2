﻿namespace GestionStock_V2.View.SuppliersView
{
    partial class ListSuppliers
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
            this.dataGridSuppliers = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSuppliers
            // 
            this.dataGridSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.firstName,
            this.lastName,
            this.phoneNumber,
            this.address,
            this.postalCode,
            this.city,
            this.country,
            this.quantity,
            this.price});
            this.dataGridSuppliers.Location = new System.Drawing.Point(12, 12);
            this.dataGridSuppliers.Name = "dataGridSuppliers";
            this.dataGridSuppliers.RowHeadersWidth = 51;
            this.dataGridSuppliers.RowTemplate.Height = 24;
            this.dataGridSuppliers.Size = new System.Drawing.Size(1176, 561);
            this.dataGridSuppliers.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "FirstName";
            this.firstName.MinimumWidth = 6;
            this.firstName.Name = "firstName";
            this.firstName.Width = 125;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "LastName";
            this.lastName.MinimumWidth = 6;
            this.lastName.Name = "lastName";
            this.lastName.Width = 125;
            // 
            // phoneNumber
            // 
            this.phoneNumber.HeaderText = "PhoneNumber";
            this.phoneNumber.MinimumWidth = 6;
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Width = 125;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.Width = 125;
            // 
            // postalCode
            // 
            this.postalCode.HeaderText = "PostalCode";
            this.postalCode.MinimumWidth = 6;
            this.postalCode.Name = "postalCode";
            this.postalCode.Width = 125;
            // 
            // city
            // 
            this.city.HeaderText = "City";
            this.city.MinimumWidth = 6;
            this.city.Name = "city";
            this.city.Width = 125;
            // 
            // country
            // 
            this.country.HeaderText = "Country";
            this.country.MinimumWidth = 6;
            this.country.Name = "country";
            this.country.Width = 125;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.Width = 125;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 125;
            // 
            // ListSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 585);
            this.Controls.Add(this.dataGridSuppliers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListSuppliers";
            this.Text = "ListSuppliers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSuppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}