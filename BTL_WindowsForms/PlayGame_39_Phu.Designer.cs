namespace BTL_WindowsForms
{
    partial class PlayGame_39_Phu
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
            this.components = new System.ComponentModel.Container();
            this.Land_39_Phu = new System.Windows.Forms.PictureBox();
            this.T_Rex_39_Phu = new System.Windows.Forms.PictureBox();
            this.obstacle1_39_Phu = new System.Windows.Forms.PictureBox();
            this.obstacle2_39_Phu = new System.Windows.Forms.PictureBox();
            this.lblScore_39_Phu = new System.Windows.Forms.Label();
            this.GameTimer_39_Phu = new System.Windows.Forms.Timer(this.components);
            this.btnExit_39_Phu = new System.Windows.Forms.Button();
            this.lblPressR_39_Phu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Land_39_Phu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_Rex_39_Phu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1_39_Phu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2_39_Phu)).BeginInit();
            this.SuspendLayout();
            // 
            // Land_39_Phu
            // 
            this.Land_39_Phu.BackColor = System.Drawing.Color.Black;
            this.Land_39_Phu.Location = new System.Drawing.Point(-12, 356);
            this.Land_39_Phu.Name = "Land_39_Phu";
            this.Land_39_Phu.Size = new System.Drawing.Size(988, 50);
            this.Land_39_Phu.TabIndex = 0;
            this.Land_39_Phu.TabStop = false;
            // 
            // T_Rex_39_Phu
            // 
            this.T_Rex_39_Phu.Image = global::BTL_WindowsForms.Properties.Resources.running;
            this.T_Rex_39_Phu.Location = new System.Drawing.Point(190, 313);
            this.T_Rex_39_Phu.Name = "T_Rex_39_Phu";
            this.T_Rex_39_Phu.Size = new System.Drawing.Size(40, 43);
            this.T_Rex_39_Phu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.T_Rex_39_Phu.TabIndex = 1;
            this.T_Rex_39_Phu.TabStop = false;
            // 
            // obstacle1_39_Phu
            // 
            this.obstacle1_39_Phu.Image = global::BTL_WindowsForms.Properties.Resources.obstacle_1;
            this.obstacle1_39_Phu.Location = new System.Drawing.Point(398, 313);
            this.obstacle1_39_Phu.Name = "obstacle1_39_Phu";
            this.obstacle1_39_Phu.Size = new System.Drawing.Size(23, 46);
            this.obstacle1_39_Phu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle1_39_Phu.TabIndex = 2;
            this.obstacle1_39_Phu.TabStop = false;
            this.obstacle1_39_Phu.Tag = "obstacle";
            // 
            // obstacle2_39_Phu
            // 
            this.obstacle2_39_Phu.Image = global::BTL_WindowsForms.Properties.Resources.obstacle_2;
            this.obstacle2_39_Phu.Location = new System.Drawing.Point(803, 323);
            this.obstacle2_39_Phu.Name = "obstacle2_39_Phu";
            this.obstacle2_39_Phu.Size = new System.Drawing.Size(32, 33);
            this.obstacle2_39_Phu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle2_39_Phu.TabIndex = 3;
            this.obstacle2_39_Phu.TabStop = false;
            this.obstacle2_39_Phu.Tag = "obstacle";
            // 
            // lblScore_39_Phu
            // 
            this.lblScore_39_Phu.AutoSize = true;
            this.lblScore_39_Phu.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore_39_Phu.Location = new System.Drawing.Point(861, 9);
            this.lblScore_39_Phu.Name = "lblScore_39_Phu";
            this.lblScore_39_Phu.Size = new System.Drawing.Size(94, 24);
            this.lblScore_39_Phu.TabIndex = 4;
            this.lblScore_39_Phu.Text = "Điểm: 0";
            this.lblScore_39_Phu.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // GameTimer_39_Phu
            // 
            this.GameTimer_39_Phu.Interval = 20;
            this.GameTimer_39_Phu.Tick += new System.EventHandler(this.MainGameTimerEvent_39_Phu);
            // 
            // btnExit_39_Phu
            // 
            this.btnExit_39_Phu.Location = new System.Drawing.Point(12, 12);
            this.btnExit_39_Phu.Name = "btnExit_39_Phu";
            this.btnExit_39_Phu.Size = new System.Drawing.Size(75, 23);
            this.btnExit_39_Phu.TabIndex = 5;
            this.btnExit_39_Phu.TabStop = false;
            this.btnExit_39_Phu.Text = "Thoát";
            this.btnExit_39_Phu.UseVisualStyleBackColor = true;
            this.btnExit_39_Phu.Click += new System.EventHandler(this.btnExit_39_Phu_Click);
            // 
            // lblPressR_39_Phu
            // 
            this.lblPressR_39_Phu.AutoSize = true;
            this.lblPressR_39_Phu.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressR_39_Phu.Location = new System.Drawing.Point(561, 43);
            this.lblPressR_39_Phu.Name = "lblPressR_39_Phu";
            this.lblPressR_39_Phu.Size = new System.Drawing.Size(394, 24);
            this.lblPressR_39_Phu.TabIndex = 6;
            this.lblPressR_39_Phu.Text = "                                ";
            // 
            // PlayGame_39_Phu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 396);
            this.Controls.Add(this.lblPressR_39_Phu);
            this.Controls.Add(this.btnExit_39_Phu);
            this.Controls.Add(this.T_Rex_39_Phu);
            this.Controls.Add(this.lblScore_39_Phu);
            this.Controls.Add(this.obstacle2_39_Phu);
            this.Controls.Add(this.Land_39_Phu);
            this.Controls.Add(this.obstacle1_39_Phu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PlayGame_39_Phu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "obstacle";
            this.Text = "PlayGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown_39_Phu);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp_39_Phu);
            ((System.ComponentModel.ISupportInitialize)(this.Land_39_Phu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_Rex_39_Phu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1_39_Phu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2_39_Phu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Land_39_Phu;
        private System.Windows.Forms.PictureBox T_Rex_39_Phu;
        private System.Windows.Forms.PictureBox obstacle1_39_Phu;
        private System.Windows.Forms.PictureBox obstacle2_39_Phu;
        private System.Windows.Forms.Label lblScore_39_Phu;
        private System.Windows.Forms.Timer GameTimer_39_Phu;
        private System.Windows.Forms.Button btnExit_39_Phu;
        private System.Windows.Forms.Label lblPressR_39_Phu;
    }
}