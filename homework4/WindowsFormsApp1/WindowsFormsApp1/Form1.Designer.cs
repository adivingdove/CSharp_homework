namespace WindowsFormsApp1
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
            this.buttonBrowse1 = new System.Windows.Forms.Button();
            this.buttonBrowse2 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.textBoxFile1 = new System.Windows.Forms.TextBox();
            this.textBoxFile2 = new System.Windows.Forms.TextBox();
            this.buttonMerge = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBrowse1
            // 
            this.buttonBrowse1.Location = new System.Drawing.Point(528, 77);
            this.buttonBrowse1.Name = "buttonBrowse1";
            this.buttonBrowse1.Size = new System.Drawing.Size(100, 43);
            this.buttonBrowse1.TabIndex = 0;
            this.buttonBrowse1.Text = "浏览...";
            this.buttonBrowse1.UseVisualStyleBackColor = true;
            this.buttonBrowse1.Click += new System.EventHandler(this.buttonBrowse1_Click);
            // 
            // buttonBrowse2
            // 
            this.buttonBrowse2.Location = new System.Drawing.Point(528, 176);
            this.buttonBrowse2.Name = "buttonBrowse2";
            this.buttonBrowse2.Size = new System.Drawing.Size(100, 43);
            this.buttonBrowse2.TabIndex = 1;
            this.buttonBrowse2.Text = "浏览...";
            this.buttonBrowse2.UseVisualStyleBackColor = true;
            this.buttonBrowse2.Click += new System.EventHandler(this.buttonBrowse2_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("宋体", 12F);
            this.Label1.Location = new System.Drawing.Point(95, 87);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(79, 20);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "文件1：";
            this.Label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("宋体", 12F);
            this.Label2.Location = new System.Drawing.Point(95, 186);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(79, 20);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "文件2：";
            // 
            // textBoxFile1
            // 
            this.textBoxFile1.Font = new System.Drawing.Font("宋体", 12F);
            this.textBoxFile1.Location = new System.Drawing.Point(180, 84);
            this.textBoxFile1.Name = "textBoxFile1";
            this.textBoxFile1.Size = new System.Drawing.Size(321, 30);
            this.textBoxFile1.TabIndex = 4;
            // 
            // textBoxFile2
            // 
            this.textBoxFile2.Font = new System.Drawing.Font("宋体", 12F);
            this.textBoxFile2.Location = new System.Drawing.Point(180, 183);
            this.textBoxFile2.Name = "textBoxFile2";
            this.textBoxFile2.Size = new System.Drawing.Size(321, 30);
            this.textBoxFile2.TabIndex = 5;
            this.textBoxFile2.TextChanged += new System.EventHandler(this.textBoxFile2_TextChanged);
            // 
            // buttonMerge
            // 
            this.buttonMerge.Location = new System.Drawing.Point(180, 294);
            this.buttonMerge.Name = "buttonMerge";
            this.buttonMerge.Size = new System.Drawing.Size(124, 63);
            this.buttonMerge.TabIndex = 6;
            this.buttonMerge.Text = "合并文件";
            this.buttonMerge.UseVisualStyleBackColor = true;
            this.buttonMerge.Click += new System.EventHandler(this.buttonMerge_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(372, 318);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 15);
            this.labelStatus.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonMerge);
            this.Controls.Add(this.textBoxFile2);
            this.Controls.Add(this.textBoxFile1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.buttonBrowse2);
            this.Controls.Add(this.buttonBrowse1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBrowse1;
        private System.Windows.Forms.Button buttonBrowse2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox textBoxFile1;
        private System.Windows.Forms.TextBox textBoxFile2;
        private System.Windows.Forms.Button buttonMerge;
        private System.Windows.Forms.Label labelStatus;
    }
}

