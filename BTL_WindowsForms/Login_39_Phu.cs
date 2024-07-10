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
    public partial class Login_39_Phu : Form
    {
        public bool login_39_Phu;
        private int failedLogin_39_Phu;
        string filePath_39_Phu = Path.Combine(Application.StartupPath, "account.txt");
        public Login_39_Phu()
        {
            InitializeComponent();
            failedLogin_39_Phu = 0;
        }

        private void Login_Load_39_Phu(object sender, EventArgs e)
        {
            Information_39_Phu(filePath_39_Phu);
        }
        private void Information_39_Phu(string filePath_39_Phu)
        {
            try
            {
                // Mở tệp văn bản để đọc
                using (StreamReader reader_39_Phu = new StreamReader(filePath_39_Phu))
                {
                    string line_39_Phu;
                    while ((line_39_Phu = reader_39_Phu.ReadLine()) != null)
                    {
                        // Tách dòng thành username và password bằng dấu phân cách (ví dụ: username:password)
                        string[] parts_39_Phu = line_39_Phu.Split(':');
                        if (parts_39_Phu.Length == 2)
                        {
                            string storedUsername = parts_39_Phu[0].Trim();
                            string storedPassword = parts_39_Phu[1].Trim();

                            MessageBox.Show($"Tài khoản hiện tại là:{storedUsername}  Mật khẩu hiện tại là:{storedPassword}","Đây là thông báo giúp đăng nhập đồ án!!!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi đọc tệp văn bản: {ex.Message}");
            }
        }
        private bool CheckAccount_39_Phu(string username_39_Phu, string password_39_Phu, string filePath_39_Phu)
        {
            try
            {
                // Mở tệp văn bản để đọc
                using (StreamReader reader_39_Phu = new StreamReader(filePath_39_Phu))
                {
                    string line_39_Phu;
                    while ((line_39_Phu = reader_39_Phu.ReadLine()) != null)
                    {
                        // Tách dòng thành username và password bằng dấu phân cách (ví dụ: username:password)
                        string[] parts_39_Phu = line_39_Phu.Split(':');
                        if (parts_39_Phu.Length == 2)
                        {
                            string storedUsername_39_Phu = parts_39_Phu[0].Trim();
                            string storedPassword_39_Phu = parts_39_Phu[1].Trim();
                            
                            // Kiểm tra tên người dùng và mật khẩu từ tệp với dữ liệu nhập vào
                            if (storedUsername_39_Phu == username_39_Phu && storedPassword_39_Phu == password_39_Phu)
                            {
                                MessageBox.Show("Đăng nhập thành công!");
                                login_39_Phu = true;
                                return true; // Trả về true nếu tài khoản và mật khẩu khớp
                            }
                        }
                    }
                }
     
                MessageBox.Show("Tên người dùng hoặc mật khẩu không chính xác.");
                login_39_Phu = false;
                return false; // Trả về false nếu không tìm thấy tài khoản
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi đọc tệp văn bản: {ex.Message}");
                login_39_Phu = false;
                return false; // Trả về false nếu xảy ra lỗi khi đọc tệp
            }
        }

        private void btnLogin_39_Phu_Click(object sender, EventArgs e)
        {
            if (failedLogin_39_Phu < 3) // Kiểm tra số lần nhập sai chưa đạt giới hạn
            {
                if (CheckAccount_39_Phu(txtAcc_39_Phu.Text, txtPass_39_Phu.Text, filePath_39_Phu))
                {
                    // Đăng nhập thành công
                    Form1_39_Phu f_39_Phu = new Form1_39_Phu();
                    f_39_Phu.LoginForm_39_Phu = this;
                    this.Hide();
                    f_39_Phu.Show();
                }
                else
                {
                    // Đăng nhập không thành công, tăng số lần nhập sai
                    failedLogin_39_Phu++;
                    MessageBox.Show($"Sai tên người dùng hoặc mật khẩu! Số lần nhập sai: {failedLogin_39_Phu}");
                }
            }
            else
            {
                // Đã nhập sai quá 3 lần, đóng chương trình
                MessageBox.Show("Bạn đã nhập sai quá 3 lần. Chương trình sẽ đóng.");
                Application.Exit();
            }

        }

        private void btnCancel_39_Phu_Click(object sender, EventArgs e)
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

        
    }
}
