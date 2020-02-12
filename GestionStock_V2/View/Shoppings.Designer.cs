namespace GestionStock_V2.View
{
    partial class Shoppings
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
            this.pnlShoppingMenu = new System.Windows.Forms.Panel();
            this.btnListShopping = new System.Windows.Forms.Button();
            this.btnDeleteShopping = new System.Windows.Forms.Button();
            this.btnAddShopping = new System.Windows.Forms.Button();
            this.pnlShoppingContainer = new System.Windows.Forms.Panel();
            this.pnlShoppingMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlShoppingMenu
            // 
            this.pnlShoppingMenu.Controls.Add(this.btnListShopping);
            this.pnlShoppingMenu.Controls.Add(this.btnDeleteShopping);
            this.pnlShoppingMenu.Controls.Add(this.btnAddShopping);
            this.pnlShoppingMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlShoppingMenu.Location = new System.Drawing.Point(0, 585);
            this.pnlShoppingMenu.Name = "pnlShoppingMenu";
            this.pnlShoppingMenu.Size = new System.Drawing.Size(1200, 79);
            this.pnlShoppingMenu.TabIndex = 0;
            // 
            // btnListShopping
            // 
            this.btnListShopping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.btnListShopping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListShopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListShopping.ForeColor = System.Drawing.Color.White;
            this.btnListShopping.Image = global::GestionStock_V2.Properties.Resources.shopping;
            this.btnListShopping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListShopping.Location = new System.Drawing.Point(621, 21);
            this.btnListShopping.Name = "btnListShopping";
            this.btnListShopping.Size = new System.Drawing.Size(200, 37);
            this.btnListShopping.TabIndex = 2;
            this.btnListShopping.Text = "List";
            this.btnListShopping.UseVisualStyleBackColor = false;
            // 
            // btnDeleteShopping
            // 
            this.btnDeleteShopping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.btnDeleteShopping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteShopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteShopping.ForeColor = System.Drawing.Color.White;
            this.btnDeleteShopping.Image = global::GestionStock_V2.Properties.Resources.delete;
            this.btnDeleteShopping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteShopping.Location = new System.Drawing.Point(388, 21);
            this.btnDeleteShopping.Name = "btnDeleteShopping";
            this.btnDeleteShopping.Size = new System.Drawing.Size(200, 37);
            this.btnDeleteShopping.TabIndex = 1;
            this.btnDeleteShopping.Text = "Delete";
            this.btnDeleteShopping.UseVisualStyleBackColor = false;
            // 
            // btnAddShopping
            // 
            this.btnAddShopping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(210)))));
            this.btnAddShopping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddShopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShopping.ForeColor = System.Drawing.Color.White;
            this.btnAddShopping.Image = global::GestionStock_V2.Properties.Resources.shopping;
            this.btnAddShopping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddShopping.Location = new System.Drawing.Point(153, 21);
            this.btnAddShopping.Name = "btnAddShopping";
            this.btnAddShopping.Size = new System.Drawing.Size(200, 37);
            this.btnAddShopping.TabIndex = 0;
            this.btnAddShopping.Text = "Add";
            this.btnAddShopping.UseVisualStyleBackColor = false;
            // 
            // pnlShoppingContainer
            // 
            this.pnlShoppingContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShoppingContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlShoppingContainer.Name = "pnlShoppingContainer";
            this.pnlShoppingContainer.Size = new System.Drawing.Size(1200, 585);
            this.pnlShoppingContainer.TabIndex = 1;
            // 
            // Shopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 664);
            this.Controls.Add(this.pnlShoppingContainer);
            this.Controls.Add(this.pnlShoppingMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Shopping";
            this.Text = "Shopping";
            this.pnlShoppingMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlShoppingMenu;
        private System.Windows.Forms.Panel pnlShoppingContainer;
        private System.Windows.Forms.Button btnAddShopping;
        private System.Windows.Forms.Button btnListShopping;
        private System.Windows.Forms.Button btnDeleteShopping;
    }
}