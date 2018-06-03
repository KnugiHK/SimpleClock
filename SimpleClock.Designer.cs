namespace SimpleClock
{
    partial class SimpleClock
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lab_unix = new System.Windows.Forms.Label();
            this.lab_readable = new System.Windows.Forms.Label();
            this.readable = new System.Windows.Forms.Label();
            this.unixtime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.copy_readable = new System.Windows.Forms.Button();
            this.copy_unix = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_unix
            // 
            this.lab_unix.AutoSize = true;
            this.lab_unix.Location = new System.Drawing.Point(12, 43);
            this.lab_unix.Name = "lab_unix";
            this.lab_unix.Size = new System.Drawing.Size(82, 12);
            this.lab_unix.TabIndex = 0;
            this.lab_unix.Text = "Unix Timestamp";
            // 
            // lab_readable
            // 
            this.lab_readable.AutoSize = true;
            this.lab_readable.Location = new System.Drawing.Point(12, 9);
            this.lab_readable.Name = "lab_readable";
            this.lab_readable.Size = new System.Drawing.Size(109, 12);
            this.lab_readable.TabIndex = 1;
            this.lab_readable.Text = "Human-readable Time";
            // 
            // readable
            // 
            this.readable.AutoSize = true;
            this.readable.Location = new System.Drawing.Point(14, 25);
            this.readable.Name = "readable";
            this.readable.Size = new System.Drawing.Size(0, 12);
            this.readable.TabIndex = 2;
            // 
            // unixtime
            // 
            this.unixtime.AutoSize = true;
            this.unixtime.Location = new System.Drawing.Point(16, 59);
            this.unixtime.Name = "unixtime";
            this.unixtime.Size = new System.Drawing.Size(0, 12);
            this.unixtime.TabIndex = 3;
            // 
            // copy_readable
            // 
            this.copy_readable.Location = new System.Drawing.Point(145, 4);
            this.copy_readable.Name = "copy_readable";
            this.copy_readable.Size = new System.Drawing.Size(75, 23);
            this.copy_readable.TabIndex = 4;
            this.copy_readable.Text = "Copy";
            this.copy_readable.UseVisualStyleBackColor = true;
            this.copy_readable.Click += new System.EventHandler(this.copy_readable_Click);
            // 
            // copy_unix
            // 
            this.copy_unix.Location = new System.Drawing.Point(145, 38);
            this.copy_unix.Name = "copy_unix";
            this.copy_unix.Size = new System.Drawing.Size(75, 23);
            this.copy_unix.TabIndex = 5;
            this.copy_unix.Text = "Copy";
            this.copy_unix.UseVisualStyleBackColor = true;
            this.copy_unix.Click += new System.EventHandler(this.copy_unix_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(117, 74);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 16);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Unix TimeStamp";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(6, 74);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(105, 16);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Human-Readable";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(88, 96);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(56, 24);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // SimpleClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 126);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.copy_unix);
            this.Controls.Add(this.copy_readable);
            this.Controls.Add(this.unixtime);
            this.Controls.Add(this.readable);
            this.Controls.Add(this.lab_readable);
            this.Controls.Add(this.lab_unix);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "SimpleClock";
            this.Opacity = 0.8D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleClock";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.TopMost = true;

        }

        #endregion

        private System.Windows.Forms.Label lab_unix;
        private System.Windows.Forms.Label lab_readable;
        private System.Windows.Forms.Label readable;
        private System.Windows.Forms.Label unixtime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button copy_readable;
        private System.Windows.Forms.Button copy_unix;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btn_exit;
    }
}

