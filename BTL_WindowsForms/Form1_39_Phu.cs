using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_WindowsForms
{
    public partial class Form1_39_Phu : Form
    {
        public Form1_39_Phu()
        {

            InitializeComponent();
        }

        private void SetButtonColors_39_Phu(Button button, Color backgroundColor, Color textColor)
        {
            button.BackColor = backgroundColor;
            button.ForeColor = textColor;
        }

        private Login_39_Phu loginForm_39_Phu;
        public Login_39_Phu LoginForm_39_Phu
        {
            set { loginForm_39_Phu = value; }
        }

        private void btn_Start_39_Phu_Click(object sender, EventArgs e)
        {
            PlayGame_39_Phu f_39_Phu = new PlayGame_39_Phu();
            f_39_Phu.Form1_39_Phu = this;
            this.Hide();
            f_39_Phu.Show();
        }

        private void btn_Level_39_Phu_Click(object sender, EventArgs e)
        {
            Level_39_Phu f_39_Phu = new Level_39_Phu();
            f_39_Phu.Form1_39_Phu = this;
            this.Hide();
            f_39_Phu.Show();
        }

        private void btn_Record_39_Phu_Click(object sender, EventArgs e)
        {
            Record_39_Phu f_39_Phu = new Record_39_Phu();
            f_39_Phu.Form1_39_Phu = this;
            this.Hide();
            f_39_Phu.Show();
        }

        private void btnExitGame_39_Phu_Click(object sender, EventArgs e)
        {
            // Hiển thị MessageBox để xác nhận thoát
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát khỏi ứng dụng?", "Xác nhận thoát",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra kết quả người dùng chọn
            if (result == DialogResult.Yes)
            {
                // Đóng chương trình hiện tại
                Application.Exit();
            }
            // Nếu người dùng chọn "No", không làm gì cả, tiếp tục ở form hiện tại
        }

        private void btn_Account_39_Phu_Click(object sender, EventArgs e)
        {
            Account_39_Phu f_39_Phu = new Account_39_Phu();
            f_39_Phu.Form1_39_Phu = this;
            this.Hide();
            f_39_Phu.Show();
        }

        private void Form1_Load_39_Phu(object sender, EventArgs e)
        {
            // Đăng ký sự kiện MouseEnter và MouseLeave cho button
            btn_Start_39_Phu.MouseEnter += (s, ev) => SetButtonColors_39_Phu(btn_Start_39_Phu, Color.Gray, Color.White);
            btn_Start_39_Phu.MouseLeave += (s, ev) => SetButtonColors_39_Phu(btn_Start_39_Phu, Color.White, Color.Black);
            btn_Level_39_Phu.MouseEnter += (s, ev) => SetButtonColors_39_Phu(btn_Level_39_Phu, Color.Gray, Color.White);
            btn_Level_39_Phu.MouseLeave += (s, ev) => SetButtonColors_39_Phu(btn_Level_39_Phu, Color.White, Color.Black);
            btn_Record_39_Phu.MouseEnter += (s, ev) => SetButtonColors_39_Phu(btn_Record_39_Phu, Color.Gray, Color.White);
            btn_Record_39_Phu.MouseLeave += (s, ev) => SetButtonColors_39_Phu(btn_Record_39_Phu, Color.White, Color.Black);
            btn_Account_39_Phu.MouseEnter += (s, ev) => SetButtonColors_39_Phu(btn_Account_39_Phu, Color.Gray, Color.White);
            btn_Account_39_Phu.MouseLeave += (s, ev) => SetButtonColors_39_Phu(btn_Account_39_Phu, Color.White, Color.Black);
        }
    }
}
