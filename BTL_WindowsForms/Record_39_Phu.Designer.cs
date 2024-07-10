namespace BTL_WindowsForms
{
    partial class Record_39_Phu
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
            this.lblCharts_39_Phu = new System.Windows.Forms.Label();
            this.btnDone_39_Phu = new System.Windows.Forms.Button();
            this.lsvRecord_39_Phu = new System.Windows.Forms.ListView();
            this.colName_39_Phu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colScore_39_Phu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblCharts_39_Phu
            // 
            this.lblCharts_39_Phu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCharts_39_Phu.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharts_39_Phu.ForeColor = System.Drawing.Color.White;
            this.lblCharts_39_Phu.Location = new System.Drawing.Point(132, 9);
            this.lblCharts_39_Phu.Name = "lblCharts_39_Phu";
            this.lblCharts_39_Phu.Size = new System.Drawing.Size(286, 56);
            this.lblCharts_39_Phu.TabIndex = 8;
            this.lblCharts_39_Phu.Text = "Bảng xếp hạng";
            this.lblCharts_39_Phu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDone_39_Phu
            // 
            this.btnDone_39_Phu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone_39_Phu.Location = new System.Drawing.Point(183, 258);
            this.btnDone_39_Phu.Name = "btnDone_39_Phu";
            this.btnDone_39_Phu.Size = new System.Drawing.Size(183, 46);
            this.btnDone_39_Phu.TabIndex = 9;
            this.btnDone_39_Phu.Text = "Hoàn tất";
            this.btnDone_39_Phu.UseVisualStyleBackColor = true;
            this.btnDone_39_Phu.Click += new System.EventHandler(this.btnDone_39_Phu_Click);
            // 
            // lsvRecord_39_Phu
            // 
            this.lsvRecord_39_Phu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName_39_Phu,
            this.colScore_39_Phu});
            this.lsvRecord_39_Phu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvRecord_39_Phu.GridLines = true;
            this.lsvRecord_39_Phu.Location = new System.Drawing.Point(37, 88);
            this.lsvRecord_39_Phu.Name = "lsvRecord_39_Phu";
            this.lsvRecord_39_Phu.Size = new System.Drawing.Size(480, 143);
            this.lsvRecord_39_Phu.TabIndex = 10;
            this.lsvRecord_39_Phu.UseCompatibleStateImageBehavior = false;
            this.lsvRecord_39_Phu.View = System.Windows.Forms.View.Details;
            // 
            // colName_39_Phu
            // 
            this.colName_39_Phu.Text = "Tên";
            this.colName_39_Phu.Width = 299;
            // 
            // colScore_39_Phu
            // 
            this.colScore_39_Phu.Text = "Điểm";
            this.colScore_39_Phu.Width = 176;
            // 
            // Record_39_Phu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 325);
            this.Controls.Add(this.lsvRecord_39_Phu);
            this.Controls.Add(this.btnDone_39_Phu);
            this.Controls.Add(this.lblCharts_39_Phu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Record_39_Phu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Record";
            this.Load += new System.EventHandler(this.Record_Load_39_Phu);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCharts_39_Phu;
        private System.Windows.Forms.Button btnDone_39_Phu;
        private System.Windows.Forms.ListView lsvRecord_39_Phu;
        private System.Windows.Forms.ColumnHeader colName_39_Phu;
        private System.Windows.Forms.ColumnHeader colScore_39_Phu;
    }
}