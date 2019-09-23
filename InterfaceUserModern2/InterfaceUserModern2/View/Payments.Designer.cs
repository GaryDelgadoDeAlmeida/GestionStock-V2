namespace InterfaceUserModern2.View
{
    partial class Payments
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtPayments = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(490, 213);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 22);
            this.textBox1.TabIndex = 0;
            // 
            // txtPayments
            // 
            this.txtPayments.AutoSize = true;
            this.txtPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayments.Location = new System.Drawing.Point(496, 177);
            this.txtPayments.Name = "txtPayments";
            this.txtPayments.Size = new System.Drawing.Size(248, 58);
            this.txtPayments.TabIndex = 1;
            this.txtPayments.Text = "Payments";
            this.txtPayments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInfo
            // 
            this.txtInfo.AutoSize = true;
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.Location = new System.Drawing.Point(332, 249);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(594, 29);
            this.txtInfo.TabIndex = 2;
            this.txtInfo.Text = "I\'m actually working for this page, please be patient.";
            this.txtInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 603);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtPayments);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payments";
            this.Text = "Payments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtPayments;
        private System.Windows.Forms.Label txtInfo;
    }
}