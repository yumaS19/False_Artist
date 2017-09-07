using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;


namespace False_Artist
{
    public partial class main : Form
    {
        private int pepole;
        private List<string> wordList = new List<string>();
        private string word;
        private int false_pepole;
        private int i = 0;

        public main(int player)
        {
            InitializeComponent();
            //保存元のファイル名
            string fileName = @"vocabulary.txt";
            StreamReader sr = new StreamReader(fileName);
            while (sr.Peek() >= 0)
            {
                wordList.Add(sr.ReadLine());
            }
            System.Random r = new System.Random();
            pepole = player;
            false_pepole = r.Next(player);
            word = wordList[r.Next(wordList.Count)];
            sr.Close();
        }

        private void main_Load(object sender, EventArgs e)
        {
            DialogResult msg_box = MessageBox.Show("次の人に交代します。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            player_num.Text = "0";
            if (false_pepole == 0)
            {
                role.Text = "エセ芸術家";
                title.Text = "？？？";
            }
            else
            {
                role.Text = "本物の芸術家";
                title.Text = word;
            }
            i++;
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            role.Text = "";
            title.Text = "";
            DialogResult msg_box = MessageBox.Show("次の人に交代します。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (i < pepole)
            {
                player_num.Text = i.ToString();
                if (false_pepole == i)
                {
                    role.Text = "エセ芸術家";
                    title.Text = "？？？";
                }else
                {
                    role.Text = "本物の芸術家";
                    title.Text = word;
                }
                i++;
            }else
            {
                DialogResult result = MessageBox.Show("ゲームを終了しますか？","質問",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    return;
                }
            }
        }
        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            // 下がったキーがAキーの場合
            if (e.KeyCode == Keys.L)
            {
                DialogResult msg_tito_box = MessageBox.Show("FALSE_ARTIST：" + false_pepole.ToString(), "チート", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }

        }
    }
}
