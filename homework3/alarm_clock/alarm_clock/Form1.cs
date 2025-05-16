using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alarm_clock
{
    public partial class Form1: Form
    {
        private DateTime alarmTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void btnSetAlarm_Click(object sender, EventArgs e)
        {
            // 设置闹钟为 5 秒后
            alarmTime = DateTime.Now.AddSeconds(5);
            MessageBox.Show($"闹钟已设置，目标时间: {alarmTime:HH:mm:ss}", "闹钟设置");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 设置定时器
            timerClock.Tick += timerClock_Tick; // 绑定 Tick 事件
            timerClock.Start();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            // 更新当前时间
            lblTime.Text = "当前时间: " + DateTime.Now.ToString("HH:mm:ss");

            // 判断闹钟是否触发
            if (DateTime.Now >= alarmTime && alarmTime != DateTime.MinValue)
            {
                timerClock.Stop(); // 停止定时器
                MessageBox.Show("闹钟响了! ", "闹钟提醒");
            }
        }
    }
}
