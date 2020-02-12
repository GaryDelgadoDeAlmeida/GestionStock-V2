namespace GestionStock_V2.View.SalesView
{
    partial class ListSales
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.productId,
            this.clientId,
            this.productPrice,
            this.productQuantity});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1176, 561);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // productId
            // 
            this.productId.HeaderText = "ProductID";
            this.productId.MinimumWidth = 6;
            this.productId.Name = "productId";
            this.productId.Width = 125;
            // 
            // clientId
            // 
            this.clientId.HeaderText = "ClientID";
            this.clientId.MinimumWidth = 6;
            this.clientId.Name = "clientId";
            this.clientId.Width = 125;
            // 
            // productPrice
            // 
            this.productPrice.HeaderText = "ProductPrice";
            this.productPrice.MinimumWidth = 6;
            this.productPrice.Name = "productPrice";
            this.productPrice.Width = 125;
            // 
            // productQuantity
            // 
            this.productQuantity.HeaderText = "ProductQuantity";
            this.productQuantity.MinimumWidth = 6;
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Width = 125;
            // 
            // ListSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 585);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListSales";
            this.Text = "ListSales";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantity;
    }
}