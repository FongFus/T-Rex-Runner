namespace BTL_WindowsForms
{
    partial class SubRecord_39_Phu
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
            this.txtNamePlayer_39_Phu = new System.Windows.Forms.TextBox();
            this.btnDone_39_Phu = new System.Windows.Forms.Button();
            this.lblTop3_39_Phu = new System.Windows.Forms.Label();
            this.lblNamePlayer_39_Phu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNamePlayer_39_Phu
            // 
            this.txtNamePlayer_39_Phu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamePlayer_39_Phu.Location = new System.Drawing.Point(205, 81);
            this.txtNamePlayer_39_Phu.Name = "txtNamePlayer_39_Phu";
            this.txtNamePlayer_39_Phu.Size = new System.Drawing.Size(268, 29);
            this.txtNamePlayer_39_Phu.TabIndex = 0;
            this.txtNamePlayer_39_Phu.TextChanged += new System.EventHandler(this.txtNamePlayer_39_Phu_TextChanged);
            // 
            // btnDone_39_Phu
            // 
            this.btnDone_39_Phu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone_39_Phu.Location = new System.Drawing.Point(148, 125);
            this.btnDone_39_Phu.Name = "btnDone_39_Phu";
            this.btnDone_39_Phu.Size = new System.Drawing.Size(181, 36);
            this.btnDone_39_Phu.TabIndex = 1;
            this.btnDone_39_Phu.Text = "Hoàn tất";
            this.btnDone_39_Phu.UseVisualStyleBackColor = true;
            this.btnDone_39_Phu.Click += new System.EventHandler(this.btnDone_39_Phu_Click);
            // 
            // lblTop3_39_Phu
            // 
            this.lblTop3_39_Phu.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop3_39_Phu.ForeColor = System.Drawing.Color.Red;
            this.lblTop3_39_Phu.Location = new System.Drawing.Point(34, 9);
            this.lblTop3_39_Phu.Name = "lblTop3_39_Phu";
            this.lblTop3_39_Phu.Size = new System.Drawing.Size(439, 53);
            this.lblTop3_39_Phu.TabIndex = 2;
            this.lblTop3_39_Phu.Text = "Chúc mừng bạn đã vào top 3";
            this.lblTop3_39_Phu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNamePlayer_39_Phu
            // 
            this.lblNamePlayer_39_Phu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePlayer_39_Phu.Location = new System.Drawing.Point(23, 81);
            this.lblNamePlayer_39_Phu.Name = "lblNamePlayer_39_Phu";
            this.lblNamePlayer_39_Phu.Size = new System.Drawing.Size(176, 23);
            this.lblNamePlayer_39_Phu.TabIndex = 3;
            this.lblNamePlayer_39_Phu.Text = "Nhập tên của bạn:";
            // 
            // SubRecord_39_Phu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 173);
            this.Controls.Add(this.lblNamePlayer_39_Phu);
            this.Controls.Add(this.lblTop3_39_Phu);
            this.Controls.Add(this.btnDone_39_Phu);
            this.Controls.Add(this.txtNamePlayer_39_Phu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SubRecord_39_Phu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubRecord";
            this.Load += new System.EventHandler(this.SubRecord_Load_39_Phu);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNamePlayer_39_Phu;
        private System.Windows.Forms.Button btnDone_39_Phu;
        private System.Windows.Forms.Label lblTop3_39_Phu;
        private System.Windows.Forms.Label lblNamePlayer_39_Phu;
    }
}