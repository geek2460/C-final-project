namespace finalProject_best
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.註冊成功button = new System.Windows.Forms.Button();
            this.帳號textBox = new System.Windows.Forms.TextBox();
            this.密碼textBox = new System.Windows.Forms.TextBox();
            this.帳號label = new System.Windows.Forms.Label();
            this.密碼label = new System.Windows.Forms.Label();
            this.系所label = new System.Windows.Forms.Label();
            this.年級label = new System.Windows.Forms.Label();
            this.註冊button = new System.Windows.Forms.Button();
            this.系所listBox = new System.Windows.Forms.ListBox();
            this.年級listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // 註冊成功button
            // 
            this.註冊成功button.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.註冊成功button.Location = new System.Drawing.Point(12, 12);
            this.註冊成功button.Name = "註冊成功button";
            this.註冊成功button.Size = new System.Drawing.Size(170, 64);
            this.註冊成功button.TabIndex = 0;
            this.註冊成功button.Text = "註冊成功";
            this.註冊成功button.UseVisualStyleBackColor = true;
            this.註冊成功button.Click += new System.EventHandler(this.註冊成功button_Click);
            // 
            // 帳號textBox
            // 
            this.帳號textBox.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.帳號textBox.Location = new System.Drawing.Point(339, 53);
            this.帳號textBox.MaxLength = 10;
            this.帳號textBox.Name = "帳號textBox";
            this.帳號textBox.Size = new System.Drawing.Size(177, 43);
            this.帳號textBox.TabIndex = 1;
            // 
            // 密碼textBox
            // 
            this.密碼textBox.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.密碼textBox.Location = new System.Drawing.Point(339, 117);
            this.密碼textBox.MaxLength = 20;
            this.密碼textBox.Name = "密碼textBox";
            this.密碼textBox.Size = new System.Drawing.Size(177, 43);
            this.密碼textBox.TabIndex = 2;
            // 
            // 帳號label
            // 
            this.帳號label.AutoSize = true;
            this.帳號label.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.帳號label.Location = new System.Drawing.Point(264, 61);
            this.帳號label.Name = "帳號label";
            this.帳號label.Size = new System.Drawing.Size(69, 35);
            this.帳號label.TabIndex = 3;
            this.帳號label.Text = "帳號";
            // 
            // 密碼label
            // 
            this.密碼label.AutoSize = true;
            this.密碼label.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.密碼label.Location = new System.Drawing.Point(264, 125);
            this.密碼label.Name = "密碼label";
            this.密碼label.Size = new System.Drawing.Size(69, 35);
            this.密碼label.TabIndex = 4;
            this.密碼label.Text = "密碼";
            // 
            // 系所label
            // 
            this.系所label.AutoSize = true;
            this.系所label.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.系所label.Location = new System.Drawing.Point(138, 184);
            this.系所label.Name = "系所label";
            this.系所label.Size = new System.Drawing.Size(195, 35);
            this.系所label.TabIndex = 5;
            this.系所label.Text = "系所(記得點選)";
            // 
            // 年級label
            // 
            this.年級label.AutoSize = true;
            this.年級label.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.年級label.Location = new System.Drawing.Point(138, 237);
            this.年級label.Name = "年級label";
            this.年級label.Size = new System.Drawing.Size(195, 35);
            this.年級label.TabIndex = 6;
            this.年級label.Text = "年級(記得點選)";
            // 
            // 註冊button
            // 
            this.註冊button.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.註冊button.Location = new System.Drawing.Point(294, 294);
            this.註冊button.Name = "註冊button";
            this.註冊button.Size = new System.Drawing.Size(190, 52);
            this.註冊button.TabIndex = 7;
            this.註冊button.Text = "註冊";
            this.註冊button.UseVisualStyleBackColor = true;
            this.註冊button.Click += new System.EventHandler(this.註冊button_Click);
            // 
            // 系所listBox
            // 
            this.系所listBox.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.系所listBox.FormattingEnabled = true;
            this.系所listBox.ItemHeight = 35;
            this.系所listBox.Items.AddRange(new object[] {
            "資訊系",
            "機械系",
            "台文系"});
            this.系所listBox.Location = new System.Drawing.Point(339, 180);
            this.系所listBox.Name = "系所listBox";
            this.系所listBox.Size = new System.Drawing.Size(177, 39);
            this.系所listBox.TabIndex = 8;
            // 
            // 年級listBox
            // 
            this.年級listBox.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.年級listBox.FormattingEnabled = true;
            this.年級listBox.ItemHeight = 35;
            this.年級listBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.年級listBox.Location = new System.Drawing.Point(339, 237);
            this.年級listBox.Name = "年級listBox";
            this.年級listBox.Size = new System.Drawing.Size(177, 39);
            this.年級listBox.TabIndex = 9;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 382);
            this.Controls.Add(this.年級listBox);
            this.Controls.Add(this.系所listBox);
            this.Controls.Add(this.註冊button);
            this.Controls.Add(this.年級label);
            this.Controls.Add(this.系所label);
            this.Controls.Add(this.密碼label);
            this.Controls.Add(this.帳號label);
            this.Controls.Add(this.密碼textBox);
            this.Controls.Add(this.帳號textBox);
            this.Controls.Add(this.註冊成功button);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 註冊成功button;
        private System.Windows.Forms.TextBox 帳號textBox;
        private System.Windows.Forms.TextBox 密碼textBox;
        private System.Windows.Forms.Label 帳號label;
        private System.Windows.Forms.Label 密碼label;
        private System.Windows.Forms.Label 系所label;
        private System.Windows.Forms.Label 年級label;
        private System.Windows.Forms.Button 註冊button;
        private System.Windows.Forms.ListBox 系所listBox;
        private System.Windows.Forms.ListBox 年級listBox;
    }
}