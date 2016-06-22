namespace finalProject_best
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.帳號label = new System.Windows.Forms.Label();
            this.密碼label = new System.Windows.Forms.Label();
            this.帳號textBox = new System.Windows.Forms.TextBox();
            this.密碼textBox = new System.Windows.Forms.TextBox();
            this.登入button = new System.Windows.Forms.Button();
            this.註冊button = new System.Windows.Forms.Button();
            this.下一步button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 帳號label
            // 
            this.帳號label.AutoSize = true;
            this.帳號label.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.帳號label.Location = new System.Drawing.Point(111, 53);
            this.帳號label.Name = "帳號label";
            this.帳號label.Size = new System.Drawing.Size(69, 35);
            this.帳號label.TabIndex = 0;
            this.帳號label.Text = "帳號";
            // 
            // 密碼label
            // 
            this.密碼label.AutoSize = true;
            this.密碼label.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.密碼label.Location = new System.Drawing.Point(111, 105);
            this.密碼label.Name = "密碼label";
            this.密碼label.Size = new System.Drawing.Size(69, 35);
            this.密碼label.TabIndex = 1;
            this.密碼label.Text = "密碼";
            // 
            // 帳號textBox
            // 
            this.帳號textBox.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.帳號textBox.Location = new System.Drawing.Point(182, 53);
            this.帳號textBox.Name = "帳號textBox";
            this.帳號textBox.Size = new System.Drawing.Size(166, 43);
            this.帳號textBox.TabIndex = 2;
            // 
            // 密碼textBox
            // 
            this.密碼textBox.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.密碼textBox.Location = new System.Drawing.Point(182, 105);
            this.密碼textBox.Name = "密碼textBox";
            this.密碼textBox.PasswordChar = '*';
            this.密碼textBox.Size = new System.Drawing.Size(166, 43);
            this.密碼textBox.TabIndex = 3;
            // 
            // 登入button
            // 
            this.登入button.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.登入button.Location = new System.Drawing.Point(375, 75);
            this.登入button.Name = "登入button";
            this.登入button.Size = new System.Drawing.Size(121, 53);
            this.登入button.TabIndex = 4;
            this.登入button.Text = "登入";
            this.登入button.UseVisualStyleBackColor = true;
            this.登入button.Click += new System.EventHandler(this.登入button_Click);
            // 
            // 註冊button
            // 
            this.註冊button.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.註冊button.Location = new System.Drawing.Point(182, 154);
            this.註冊button.Name = "註冊button";
            this.註冊button.Size = new System.Drawing.Size(90, 35);
            this.註冊button.TabIndex = 5;
            this.註冊button.Text = "註冊新帳號";
            this.註冊button.UseVisualStyleBackColor = true;
            this.註冊button.Click += new System.EventHandler(this.註冊button_Click);
            // 
            // 下一步button
            // 
            this.下一步button.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.下一步button.Location = new System.Drawing.Point(13, 13);
            this.下一步button.Name = "下一步button";
            this.下一步button.Size = new System.Drawing.Size(92, 41);
            this.下一步button.TabIndex = 6;
            this.下一步button.Text = "下一步";
            this.下一步button.UseVisualStyleBackColor = true;
            this.下一步button.Click += new System.EventHandler(this.下一步button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 294);
            this.Controls.Add(this.下一步button);
            this.Controls.Add(this.註冊button);
            this.Controls.Add(this.登入button);
            this.Controls.Add(this.密碼textBox);
            this.Controls.Add(this.帳號textBox);
            this.Controls.Add(this.密碼label);
            this.Controls.Add(this.帳號label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.form1_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 帳號label;
        private System.Windows.Forms.Label 密碼label;
        private System.Windows.Forms.Button 登入button;
        private System.Windows.Forms.Button 註冊button;
        private System.Windows.Forms.Button 下一步button;
        public System.Windows.Forms.TextBox 帳號textBox;
        public System.Windows.Forms.TextBox 密碼textBox;
    }
}

