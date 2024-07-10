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
    public partial class SubRecord_39_Phu : Form
    {
        public string EnteredText_39_Phu { get; private set; }
        public int CurrentScore_39_Phu { get; private set; }
        string filePath2_39_Phu = Path.Combine(Application.StartupPath, "record.txt");
        List<Player_39_Phu> loadedPlayers_39_Phu;
        int maxLength_39_Phu = 10;
        public SubRecord_39_Phu()
        {
            InitializeComponent();
        }
        // Constructor nhận tham số int để thiết lập điểm hiện tại
        public SubRecord_39_Phu(int currentScore) : this()
        {
            CurrentScore_39_Phu = currentScore;
        }
        private void SubRecord_Load_39_Phu(object sender, EventArgs e)
        {
            loadedPlayers_39_Phu = ReadPlayersFromFile_39_Phu(filePath2_39_Phu);
        }
        public void WritePlayersToFile_39_Phu(List<Player_39_Phu> players_39_Phu, string filePath_39_Phu)
        {
            players_39_Phu = players_39_Phu.OrderByDescending(p => p.Score).ToList();
            try
            {
                using (StreamWriter writer_39_Phu = new StreamWriter(filePath_39_Phu))
                {
                    foreach (var player in players_39_Phu)
                    {
                        writer_39_Phu.WriteLine(player.Name);
                        writer_39_Phu.WriteLine(player.Score);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi ghi vào tập tin: {ex.Message}");
            }
        }
        public List<Player_39_Phu> ReadPlayersFromFile_39_Phu(string filePath_39_Phu)
        {
            List<Player_39_Phu> players_39_Phu = new List<Player_39_Phu>();

            try
            {
                using (StreamReader reader_39_Phu = new StreamReader(filePath_39_Phu))
                {
                    while (!reader_39_Phu.EndOfStream)
                    {
                        string nameLine_39_Phu = reader_39_Phu.ReadLine();
                        string scoreLine_39_Phu = reader_39_Phu.ReadLine();

                        if (!string.IsNullOrEmpty(nameLine_39_Phu) && !string.IsNullOrEmpty(scoreLine_39_Phu))
                        {
                            string name_39_Phu = nameLine_39_Phu.Trim();
                            int score_39_Phu;
                            if (int.TryParse(scoreLine_39_Phu.Trim(), out score_39_Phu))
                            {
                                Player_39_Phu player_39_Phu = new Player_39_Phu
                                {
                                    Name = name_39_Phu,
                                    Score = score_39_Phu
                                };
                                players_39_Phu.Add(player_39_Phu);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi đọc vào tập tin: {ex.Message}");
            }

            return players_39_Phu;
        }
        private bool IsInputValid_39_Phu(string input_39_Phu, int maxLength_39_Phu)
        {
            if (input_39_Phu.Length > maxLength_39_Phu)
            {
                return false;
            }
            return true;
        }
        
        private void btnDone_39_Phu_Click(object sender, EventArgs e)
        {
                EnteredText_39_Phu = txtNamePlayer_39_Phu.Text;
                Player_39_Phu newP_39_Phu = new Player_39_Phu
                {
                    Name = EnteredText_39_Phu,
                    Score = CurrentScore_39_Phu//lấy score vừa chơi từ Form PlayGame
                };
                loadedPlayers_39_Phu.Add(newP_39_Phu);
                loadedPlayers_39_Phu = loadedPlayers_39_Phu.OrderByDescending(p => p.Score).ToList();
                // Giới hạn danh sách chỉ có 3 người chơi có điểm cao nhất
                int maxPlayers = 3;
                if (loadedPlayers_39_Phu.Count > maxPlayers)
                {
                    // Xoá người chơi có điểm số thấp nhất
                    loadedPlayers_39_Phu.RemoveAt(loadedPlayers_39_Phu.Count - 1);
                }

                // Ghi danh sách người chơi vào tệp
                WritePlayersToFile_39_Phu(loadedPlayers_39_Phu, filePath2_39_Phu);
                this.Close(); // Đóng form sau khi nhập xong
            }

        private void txtNamePlayer_39_Phu_TextChanged(object sender, EventArgs e)
        {
            if(!IsInputValid_39_Phu(txtNamePlayer_39_Phu.Text, maxLength_39_Phu))
            {
                // Nếu độ dài không hợp lệ, hiển thị MessageBox và cho người dùng nhập lại
                MessageBox.Show($"Độ dài tên người chơi không được vượt quá {maxLength_39_Phu} ký tự. Vui lòng nhập lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Xoá nội dung đã nhập để người dùng nhập lại
                txtNamePlayer_39_Phu.Text = "";

                // Hiển thị lại form SubRecord để người dùng nhập liệu
                this.txtNamePlayer_39_Phu.Focus(); // Đưa trỏ chuột vào ô nhập tên người chơi
            }
        }

        
    }
}
