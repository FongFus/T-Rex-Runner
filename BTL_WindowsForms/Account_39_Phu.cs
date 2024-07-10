using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BTL_WindowsForms
{
    public partial class Account_39_Phu : Form
    {
        Form form1_39_Phu;
        public Account_39_Phu()
        {
            InitializeComponent();
        }
        public Form Form1_39_Phu
        {
            set { form1_39_Phu = value; }
        }
        private bool ChangePassword_39_Phu()
        {
            string filePath_39_Phu = Path.Combine(Application.StartupPath, "account.txt");
            string username_39_Phu = txtNameAcc_39_Phu.Text.Trim();
            string oldPassword_39_Phu = txtOldPass_39_Phu.Text.Trim();
            string newPassword_39_Phu = txtNewPass_39_Phu.Text.Trim();

            // Kiểm tra mật khẩu mới có đủ điều kiện không
            if (txtNameAcc_39_Phu.Text == "" || txtNewPass_39_Phu.Text == "" || txtOldPass_39_Phu.Text == "")
            {
                MessageBox.Show("Tài khoản, mật khẩu không được để trống");
                return false;
            }
                
            if (!IsValidPassword_39_Phu(newPassword_39_Phu))
            {
                MessageBox.Show("Mật khẩu mới không hợp lệ. Mật khẩu mới phải chứa chữ và số, từ 5 đến 9 ký tự.");
                return false;
            }

            try
            {
                // Đọc tệp và tìm thông tin tài khoản
                string[] lines_39_Phu = File.ReadAllLines(filePath_39_Phu);
                bool accountFound_39_Phu = false;

                for (int i = 0; i < lines_39_Phu.Length; i++)
                {
                    string[] parts_39_Phu = lines_39_Phu[i].Split(':');
                    if (parts_39_Phu.Length == 2)
                    {
                        string fileUsername_39_Phu = parts_39_Phu[0].Trim();
                        string filePassword_39_Phu = parts_39_Phu[1].Trim();

                        if (fileUsername_39_Phu == username_39_Phu && filePassword_39_Phu == oldPassword_39_Phu)
                        {
                            // Tìm thấy tài khoản, thay đổi mật khẩu
                            lines_39_Phu[i] = $"{username_39_Phu}:{newPassword_39_Phu}";
                            File.WriteAllLines(filePath_39_Phu, lines_39_Phu);
                            accountFound_39_Phu = true;
                            break;
                        }
                    }
                }

                if (!accountFound_39_Phu)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu cũ không đúng.");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
                return false;
            }
        }

        private bool IsValidPassword_39_Phu(string password_39_Phu)
        {
            if (password_39_Phu.Length < 5 || password_39_Phu.Length > 9)
                return false;

            bool hasLetter_39_Phu = false;
            bool hasDigit_39_Phu = false;

            foreach (char c in password_39_Phu)
            {
                if (char.IsLetter(c))
                    hasLetter_39_Phu = true;
                else if (char.IsDigit(c))
                    hasDigit_39_Phu = true;

                if (hasLetter_39_Phu && hasDigit_39_Phu)
                    return true;
            }

            return false;
        }
        private void btnDone_39_Phu_Click(object sender, EventArgs e)
        {
            // Kiểm tra và đổi mật khẩu
            if (ChangePassword_39_Phu())
            {
                MessageBox.Show("Đổi mật khẩu thành công! Để hoàn tất bạn cần khởi động lại trò chơi!");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại. Vui lòng kiểm tra lại thông tin!");
            }
        }

        private void btnCancel_39_Phu_Click(object sender, EventArgs e)
        {
            this.Close();
            form1_39_Phu.Show();
        }

        private void Account_Load_39_Phu(object sender, EventArgs e)
        {

        }
    }
}
