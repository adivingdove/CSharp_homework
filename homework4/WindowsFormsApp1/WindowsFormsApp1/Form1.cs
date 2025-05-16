using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void buttonBrowse1_Click(object sender, EventArgs e)
        {
            // 创建打开文件对话框
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // 设置文件过滤器
            openFileDialog.Filter = "文本文件|*.txt|所有文件|*.*";

            // 显示对话框并检查用户是否点击了OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 将选择的文件路径显示在文本框中
                textBoxFile1.Text = openFileDialog.FileName;
            }
        }

        private void buttonBrowse2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "文本文件|*.txt|所有文件|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFile2.Text = openFileDialog.FileName;
            }
        }

        private void buttonMerge_Click(object sender, EventArgs e)
        {
            // 检查是否选择了两个文件
            if (string.IsNullOrWhiteSpace(textBoxFile1.Text) ||
                string.IsNullOrWhiteSpace(textBoxFile2.Text))
            {
                labelStatus.Text = "请先选择两个文件";
                return;
            }

            // 检查文件是否存在
            if (!File.Exists(textBoxFile1.Text) || !File.Exists(textBoxFile2.Text))
            {
                labelStatus.Text = "一个或两个文件不存在";
                return;
            }

            try
            {
                // 显示正在处理的提示
                labelStatus.Text = "正在处理文件...";

                // 强制刷新界面，立即显示状态
                Application.DoEvents();

                // 读取第一个文件内容
                string content1 = File.ReadAllText(textBoxFile1.Text);

                // 读取第二个文件内容
                string content2 = File.ReadAllText(textBoxFile2.Text);

                // 合并内容，中间加两个空行分隔
                string mergedContent = content1 + Environment.NewLine + Environment.NewLine + content2;

                // 确保Data目录存在
                string dataDir = Path.Combine(Application.StartupPath, "Data");
                if (!Directory.Exists(dataDir))
                {
                    Directory.CreateDirectory(dataDir);
                }

                // 创建新文件路径，使用时间戳确保文件名唯一
                string newFileName = $"merged_{DateTime.Now:yyyyMMddHHmmss}.txt";
                string newFilePath = Path.Combine(dataDir, newFileName);

                // 写入合并后的内容
                File.WriteAllText(newFilePath, mergedContent);

                // 显示成功消息
                labelStatus.Text = $"文件合并成功！保存为: {newFileName}";

                // 可选：打开资源管理器显示文件
                // System.Diagnostics.Process.Start("explorer.exe", dataDir);
            }
            catch (Exception ex)
            {
                labelStatus.Text = $"错误: {ex.Message}";
            }
        }

        private void textBoxFile2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
