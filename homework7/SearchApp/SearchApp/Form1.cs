using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.RegularExpressions;



namespace SearchApp
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // 🧠 异步方法：百度搜索
        private async Task<string> SearchBaiduAsync(string keyword)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://www.baidu.com/s?wd={Uri.EscapeDataString(keyword)}";
                string html = await client.GetStringAsync(url);
                return ExtractTextFromHtml(html, 200);
            }
        }

        // 🌍 异步方法：必应搜索
        private async Task<string> SearchBingAsync(string keyword)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://www.bing.com/search?q={Uri.EscapeDataString(keyword)}";
                string html = await client.GetStringAsync(url);
                return ExtractTextFromHtml(html, 200);
            }
        }

        // 🔧 文本提取方法（过滤 HTML）
        private string ExtractTextFromHtml(string html, int maxLength)
        {
            html = Regex.Replace(html, "<script[^>]*>.*?</script>", "", RegexOptions.Singleline);
            html = Regex.Replace(html, "<style[^>]*>.*?</style>", "", RegexOptions.Singleline);
            string text = Regex.Replace(html, "<[^>]+>", "");
            text = Regex.Replace(text, @"\s+", " ");
            return text.Length > maxLength ? text.Substring(0, maxLength) : text;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("请输入关键字！");
                return;
            }

            // 清空之前的结果
            txtBaiduResult.Text = "正在搜索 Baidu...";
            txtBingResult.Text = "正在搜索 Bing...";

            try
            {
                // 并行执行两个搜索任务
                var baiduTask = SearchBaiduAsync(keyword);
                var bingTask = SearchBingAsync(keyword);

                await Task.WhenAll(baiduTask, bingTask);

                txtBaiduResult.Text = baiduTask.Result;
                txtBingResult.Text = bingTask.Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("搜索过程中出错：" + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }



}
