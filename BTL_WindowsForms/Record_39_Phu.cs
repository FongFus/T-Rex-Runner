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
    public partial class Record_39_Phu : Form
    {
        string filePath2_39_Phu = Path.Combine(Application.StartupPath, "record.txt");
        List<Player_39_Phu> loadedPlayers_39_Phu;
        public Record_39_Phu()
        {
            InitializeComponent();
        }

        private void Record_Load_39_Phu(object sender, EventArgs e)
        {
            // Đọc dữ liệu người chơi từ tệp và hiển thị trên lsvRecord_39_Phu
            loadedPlayers_39_Phu = ReadPlayersFromFile_39_Phu(filePath2_39_Phu);

            foreach (Player_39_Phu player in loadedPlayers_39_Phu)
            {
                ListViewItem item_39_Phu = new ListViewItem(player.Name); // Tạo ListViewItem với tên người chơi
                item_39_Phu.SubItems.Add(player.Score.ToString()); // Thêm SubItem với điểm số
                lsvRecord_39_Phu.Items.Add(item_39_Phu); // Thêm ListViewItem vào lsvRecord_39_Phu
            }
        }
        public List<Player_39_Phu> ReadPlayersFromFile_39_Phu(string filePath)
        {
            List<Player_39_Phu> players_39_Phu = new List<Player_39_Phu>();

            try
            {
                using (StreamReader reader_39_Phu = new StreamReader(filePath))
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
                                Player_39_Phu player = new Player_39_Phu
                                {
                                    Name = name_39_Phu,
                                    Score = score_39_Phu
                                };
                                players_39_Phu.Add(player);
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
        Form form1_39_Phu;
        public Form Form1_39_Phu
        {
            set { form1_39_Phu = value; }
        }

        private void btnDone_39_Phu_Click(object sender, EventArgs e)
        {
            this.Close();
            form1_39_Phu.Show();
        }

        
    }
}
