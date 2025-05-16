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


namespace WebScraperDemo
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnFetch_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text.Trim();
            lstResults.Items.Clear();

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("请输入有效的URL！");
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // 设置 User-Agent 避免被部分网站拦截
                    client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");

                    string html = await client.GetStringAsync(url);

                    // 正则表达式提取手机号和邮箱
                    var emails = Regex.Matches(html, @"[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+");
                    var phones = Regex.Matches(html, @"1[3-9]\d{9}"); // 针对中国手机号格式

                    if (emails.Count == 0 && phones.Count == 0)
                    {
                        lstResults.Items.Add("未找到手机号或邮箱");
                    }
                    else
                    {
                        lstResults.Items.Add("邮箱：");
                        foreach (Match email in emails)
                        {
                            lstResults.Items.Add(email.Value);
                        }

                        lstResults.Items.Add("手机号：");
                        foreach (Match phone in phones)
                        {
                            lstResults.Items.Add(phone.Value);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("抓取失败：" + ex.Message);
            }
        }




    }
}
