namespace finalProject_best
{
    partial class Form5
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
            this.留下心得richTextBox = new System.Windows.Forms.RichTextBox();
            this.留下心得button = new System.Windows.Forms.Button();
            this.課名label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 留下心得richTextBox
            // 
            this.留下心得richTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.留下心得richTextBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.留下心得richTextBox.Location = new System.Drawing.Point(31, 64);
            this.留下心得richTextBox.MaxLength = 300;
            this.留下心得richTextBox.Name = "留下心得richTextBox";
            this.留下心得richTextBox.Size = new System.Drawing.Size(432, 277);
            this.留下心得richTextBox.TabIndex = 0;
            this.留下心得richTextBox.Text = "";
            this.留下心得richTextBox.TextChanged += new System.EventHandler(this.留下心得richTextBox_TextChanged);
            // 
            // 留下心得button
            // 
            this.留下心得button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.留下心得button.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.留下心得button.Location = new System.Drawing.Point(358, 22);
            this.留下心得button.Name = "留下心得button";
            this.留下心得button.Size = new System.Drawing.Size(105, 36);
            this.留下心得button.TabIndex = 1;
            this.留下心得button.Text = "送出";
            this.留下心得button.UseVisualStyleBackColor = false;
            this.留下心得button.Click += new System.EventHandler(this.留下心得button_Click);
            // 
            // 課名label
            // 
            this.課名label.AutoSize = true;
            this.課名label.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.課名label.Location = new System.Drawing.Point(31, 22);
            this.課名label.Name = "課名label";
            this.課名label.Size = new System.Drawing.Size(54, 26);
            this.課名label.TabIndex = 2;
            this.課名label.Text = "課名";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(500, 353);
            this.Controls.Add(this.課名label);
            this.Controls.Add(this.留下心得button);
            this.Controls.Add(this.留下心得richTextBox);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox 留下心得richTextBox;
        private System.Windows.Forms.Button 留下心得button;
        private System.Windows.Forms.Label 課名label;
    }
}