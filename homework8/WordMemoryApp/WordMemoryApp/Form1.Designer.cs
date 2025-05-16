namespace WordMemoryApp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblChinese = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChinese
            // 
            this.lblChinese.AutoSize = true;
            this.lblChinese.Font = new System.Drawing.Font("宋体", 14F);
            this.lblChinese.Location = new System.Drawing.Point(155, 117);
            this.lblChinese.Name = "lblChinese";
            this.lblChinese.Size = new System.Drawing.Size(202, 24);
            this.lblChinese.TabIndex = 0;
            this.lblChinese.Text = "（显示中文词义）";
            this.lblChinese.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChinese.Click += new System.EventHandler(this.lblChinese_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(156, 259);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(15, 15);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = " ";
            this.lblResult.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("宋体", 12F);
            this.txtEnglish.Location = new System.Drawing.Point(159, 195);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(198, 30);
            this.txtEnglish.TabIndex = 2;
            this.txtEnglish.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEnglish_KeyDown);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("宋体", 14F);
            this.btnNext.Location = new System.Drawing.Point(188, 308);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 44);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "下一词";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblChinese);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChinese;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Button btnNext;
    }
}

