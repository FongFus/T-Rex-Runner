using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BTL_WindowsForms
{
    public partial class Level_39_Phu : Form
    {
        string filePath_39_Phu = Path.Combine(Application.StartupPath, "level.txt");
        public Level_39_Phu()
        {
            InitializeComponent();
        }
        private void Level_Load_39_Phu(object sender, EventArgs e)
        {
            // Đọc và xử lý nội dung từ tệp level.txt khi form được tải
            ReadDifficultySettingFromFile_39_Phu();
        }
        private void ReadDifficultySettingFromFile_39_Phu()
        {
                // Kiểm tra nếu tệp level.txt tồn tại
                if (File.Exists(filePath_39_Phu))
                {
                    // Đọc nội dung từ tệp level.txt
                    using (StreamReader reader_39_Phu = new StreamReader(filePath_39_Phu))
                    {
                        string content_39_Phu = reader_39_Phu.ReadToEnd();

                        // Xác định giá trị nội dung và đánh dấu radio button tương ứng
                        int difficultyLevel_39_Phu;
                        DialogResult result_39_Phu;
                        if (int.TryParse(content_39_Phu, out difficultyLevel_39_Phu))
                        {
                            switch (difficultyLevel_39_Phu)
                            {
                                case 1:
                                result_39_Phu = MessageBox.Show("Bạn đang ở mức độ DỄ!", "Độ khó hiện tại",
                                              MessageBoxButtons.OK);
                                break;
                                case 2:
                                result_39_Phu = MessageBox.Show("Bạn đang ở mức độ TRUNG BÌNH!", "Độ khó hiện tại",
                                          MessageBoxButtons.OK);
                                break;
                                case 3:
                                result_39_Phu = MessageBox.Show("Bạn đang ở mức độ KHÓ!", "Độ khó hiện tại",
                                          MessageBoxButtons.OK);
                                break;
                                default:
                                    // Trường hợp ngoài các giá trị 1, 2, 3
                                    // Không làm gì nếu giá trị không hợp lệ
                                    break;
                            }
                        }
                    }
                }
           
        }
        Form form1_39_Phu;
        public Form Form1_39_Phu
        {
            set { form1_39_Phu = value; }
        }

        private void SaveDifficultySetting_39_Phu(int difficultyLevel_39_Phu)
        {
            try
            {
                // Ghi nội dung vào tệp văn bản
                using (StreamWriter writer_39_Phu = new StreamWriter(filePath_39_Phu))
                {
                    writer_39_Phu.Write(difficultyLevel_39_Phu);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu cài đặt: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnDone_39_Phu_Click_1(object sender, EventArgs e)
        {
            this.Close();
            form1_39_Phu.Show();
        }

        private void rbtnEasy_39_Phu_CheckedChanged(object sender, EventArgs e)
        {
            SaveDifficultySetting_39_Phu(1);
        }

        private void rbtnMedium_39_Phu_CheckedChanged(object sender, EventArgs e)
        {
            SaveDifficultySetting_39_Phu(2);
        }

        private void rbtnDifficult_39_Phu_CheckedChanged(object sender, EventArgs e)
        {
            SaveDifficultySetting_39_Phu(3);
        }

       
    }
}
