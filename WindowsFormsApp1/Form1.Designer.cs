namespace WindowsFormsApp1
{
    partial class Form1   // 👈 partial class Form1, KHÔNG thêm : Form ở đây
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Giải phóng tài nguyên
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(30, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(30, 60);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(200, 20);
            this.txtNumber.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(30, 90);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(200, 25);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Xem kết quả";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(30, 130);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "Funny WinForms App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblResult;
    }
}
