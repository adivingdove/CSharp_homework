using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WordMemoryApp
{
    public partial class Form1: Form
    {
        private MySqlConnection conn;
        private DataTable wordTable;
        private int currentIndex = 0;
        public Form1()
        {
            InitializeComponent(); 
            InitializeDatabase();
            LoadWords();
            DisplayNextWord();
        }

        private void InitializeDatabase()
        {
            string connStr = "server=localhost;user=root;password=minatoaqua3710;database=WordLearning;";
            conn = new MySqlConnection(connStr);
        }

        private void LoadWords()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM Words";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                wordTable = new DataTable();
                adapter.Fill(wordTable);
            }
            finally
            {
                conn.Close();
            }
        }

        private void DisplayNextWord()
        {
            txtEnglish.Focus(); // 自动聚焦

            if (wordTable.Rows.Count == 0) return;

            if (currentIndex >= wordTable.Rows.Count)
                currentIndex = 0; // 从头开始

            var row = wordTable.Rows[currentIndex];
            lblChinese.Text = row["chinese_meaning"].ToString();
            txtEnglish.Clear();
            lblResult.Text = "";
        }

        private void txtEnglish_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckAnswer();
                e.SuppressKeyPress = true; // 防止回车触发“ding”声
            }
        }

        private void CheckAnswer()
        {
            var correctWord = wordTable.Rows[currentIndex]["english_word"].ToString().Trim();
            var userInput = txtEnglish.Text.Trim();

            if (string.Equals(correctWord, userInput, StringComparison.OrdinalIgnoreCase))
            {
                lblResult.Text = "正确";
                lblResult.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblResult.Text = $"错误，正确答案是：{correctWord}";
                lblResult.ForeColor = System.Drawing.Color.Red;
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentIndex++;
            DisplayNextWord();
        }

        private void lblChinese_Click(object sender, EventArgs e)
        {

        }
    }
}
