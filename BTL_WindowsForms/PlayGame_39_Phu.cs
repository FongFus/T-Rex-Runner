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
    public partial class PlayGame_39_Phu : Form
    {
        bool jumping_39_Phu = false;
        int jumpSpeed_39_Phu;
        int force_39_Phu = 12;
        int score_39_Phu = 0;
        int obstacleSpeed_39_Phu = 10;
        int addObstacleSpeed_39_Phu;
        Random rand_39_Phu = new Random();
        int position_39_Phu;
        bool isGameOver_39_Phu = false;
        string filePath_39_Phu = Path.Combine(Application.StartupPath, "level.txt");
        string filePath2_39_Phu = Path.Combine(Application.StartupPath, "record.txt");
        public PlayGame_39_Phu()
        {
            InitializeComponent();
            GameReset_39_Phu();
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
                Console.WriteLine($"Lỗi đọc tập tin: {ex.Message}");
            }

            return players_39_Phu;
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
                    if (int.TryParse(content_39_Phu, out difficultyLevel_39_Phu))
                    {
                        switch (difficultyLevel_39_Phu)
                        {
                            case 1:
                                addObstacleSpeed_39_Phu = 3;
                                break;
                            case 2:
                                addObstacleSpeed_39_Phu = 5;
                                break;
                            case 3:
                                addObstacleSpeed_39_Phu = 7;
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

        private void MainGameTimerEvent_39_Phu(object sender, EventArgs e)
        {
            T_Rex_39_Phu.Top += jumpSpeed_39_Phu;

            lblScore_39_Phu.Text = "Điểm: " + score_39_Phu;

            if (jumping_39_Phu == true && force_39_Phu < 0)
            {
                jumping_39_Phu = false;
            }

            if (jumping_39_Phu == true)
            {
                jumpSpeed_39_Phu = -12;
                force_39_Phu -= 1;
            }
            else
            {
                jumpSpeed_39_Phu = 12;
            }


            if (T_Rex_39_Phu.Top > 312 && jumping_39_Phu == false)
            {
                force_39_Phu = 12;
                T_Rex_39_Phu.Top = 313;
                jumpSpeed_39_Phu = 0;
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed_39_Phu;

                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rand_39_Phu.Next(500, 500) + (x.Width * 30);
                        if (addObstacleSpeed_39_Phu == 3)
                            score_39_Phu++;
                        else if (addObstacleSpeed_39_Phu == 5)
                            score_39_Phu += 2;
                        else if (addObstacleSpeed_39_Phu == 7)
                            score_39_Phu += 3;
                    }
                    if (T_Rex_39_Phu.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameTimer_39_Phu.Stop();
                        T_Rex_39_Phu.Image = Properties.Resources.dead;
                        lblPressR_39_Phu.Text = " \nNhấn R để khởi động lại trò chơi!";
                        isGameOver_39_Phu = true;
                        int curentScore_39_Phu = score_39_Phu;
                        List<Player_39_Phu> loadedPlayers_39_Phu = ReadPlayersFromFile_39_Phu(filePath2_39_Phu);


                        // Kiểm tra điểm số với điểm số thấp nhất trong danh sách người chơi đã tải (người chơi cuối cùng trong danh sách đã được sắp xếp)
                        if (loadedPlayers_39_Phu.Any())
                        {
                            int minScoreIndex_39_Phu = loadedPlayers_39_Phu.Count - 1;
                            if (score_39_Phu > loadedPlayers_39_Phu[minScoreIndex_39_Phu].Score)
                            {
                                MessageBox.Show($"BẠN ĐÃ ĐẠT SỐ ĐIỂM CAO.", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                SubRecord_39_Phu inputForm_39_Phu = new SubRecord_39_Phu(curentScore_39_Phu);
                                inputForm_39_Phu.ShowDialog();
                            }
                        }
                        else
                        {
                            MessageBox.Show($"BẠN ĐÃ ĐẠT SỐ ĐIỂM CAO.", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SubRecord_39_Phu inputForm = new SubRecord_39_Phu(curentScore_39_Phu);
                            inputForm.ShowDialog();
                        }
                    }
                    if (obstacleSpeed_39_Phu >= 38)
                        obstacleSpeed_39_Phu = 38;
                    else if (score_39_Phu >= obstacleSpeed_39_Phu && score_39_Phu != 0)
                    {
                        obstacleSpeed_39_Phu += addObstacleSpeed_39_Phu;
                    }
                }
            }
        }

        private void KeyIsDown_39_Phu(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping_39_Phu == false)
            {
                jumping_39_Phu = true;
            }
        }

        private void KeyIsUp_39_Phu(object sender, KeyEventArgs e)
        {
            if (jumping_39_Phu == true)
            {
                jumping_39_Phu = false;
            }

            if (e.KeyCode == Keys.R && isGameOver_39_Phu == true)
            {
                GameReset_39_Phu();
            }
        }
        private void GameReset_39_Phu()
        {
            force_39_Phu = 12;
            jumpSpeed_39_Phu = 0;
            jumping_39_Phu = false;
            score_39_Phu = 0;
            obstacleSpeed_39_Phu = 10;
            lblPressR_39_Phu.Text = " ";
            lblScore_39_Phu.Text = "Score: " + score_39_Phu;
            T_Rex_39_Phu.Image = Properties.Resources.running;
            isGameOver_39_Phu = false;
            T_Rex_39_Phu.Top = 313;

            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    position_39_Phu = this.ClientSize.Width + rand_39_Phu.Next(500, 500) + (x.Width * 30);

                    x.Left = position_39_Phu;
                }
            }
            ReadDifficultySettingFromFile_39_Phu();
            GameTimer_39_Phu.Start();
        }

        Form form1_39_Phu;
        public Form Form1_39_Phu
        {
            set { form1_39_Phu = value; }
        }
        private void btnExit_39_Phu_Click(object sender, EventArgs e)
        {
            this.Close();
            form1_39_Phu.Show();
        }


        
    }
}
