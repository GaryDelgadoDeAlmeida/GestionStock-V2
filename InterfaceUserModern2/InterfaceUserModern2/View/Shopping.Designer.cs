namespace InterfaceUserModern2.View
{
    partial class Shopping
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
            this.txtShopping = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtShopping
            // 
            this.txtShopping.AutoSize = true;
            this.txtShopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShopping.Location = new System.Drawing.Point(504, 202);
            this.txtShopping.Name = "txtShopping";
            this.txtShopping.Size = new System.Drawing.Size(237, 58);
            this.txtShopping.TabIndex = 0;
            this.txtShopping.Text = "Shopping";
            this.txtShopping.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInfo
            // 
            this.txtInfo.AutoSize = true;
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.Location = new System.Drawing.Point(342, 273);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(594, 29);
            this.txtInfo.TabIndex = 1;
            this.txtInfo.Text = "I\'m actually working for this page, please be patient.";
            this.txtInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Shopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 603);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtShopping);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Shopping";
            this.Text = "Shopping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtShopping;
        private System.Windows.Forms.Label txtInfo;
    }
}