namespace GestionStock_V2.View.ShoppingView
{
    partial class ListShopping
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
            this.dataGridShopping = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShopping)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridShopping
            // 
            this.dataGridShopping.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridShopping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridShopping.Location = new System.Drawing.Point(12, 12);
            this.dataGridShopping.Name = "dataGridShopping";
            this.dataGridShopping.RowHeadersWidth = 51;
            this.dataGridShopping.RowTemplate.Height = 24;
            this.dataGridShopping.Size = new System.Drawing.Size(1176, 561);
            this.dataGridShopping.TabIndex = 0;
            // 
            // ListShopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 585);
            this.Controls.Add(this.dataGridShopping);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListShopping";
            this.Text = "ListShopping";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShopping)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridShopping;
    }
}