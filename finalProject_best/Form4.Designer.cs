﻿namespace finalProject_best
{
    partial class Form4
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
            this.心得richTextBox = new System.Windows.Forms.RichTextBox();
            this.課名label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 心得richTextBox
            // 
            this.心得richTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.心得richTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.心得richTextBox.Location = new System.Drawing.Point(25, 49);
            this.心得richTextBox.Name = "心得richTextBox";
            this.心得richTextBox.ReadOnly = true;
            this.心得richTextBox.Size = new System.Drawing.Size(469, 320);
            this.心得richTextBox.TabIndex = 1;
            this.心得richTextBox.Text = "";
            this.心得richTextBox.TextChanged += new System.EventHandler(this.心得richTextBox_TextChanged);
            // 
            // 課名label
            // 
            this.課名label.AutoSize = true;
            this.課名label.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.課名label.Location = new System.Drawing.Point(30, 9);
            this.課名label.Name = "課名label";
            this.課名label.Size = new System.Drawing.Size(62, 31);
            this.課名label.TabIndex = 2;
            this.課名label.Text = "課名";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 395);
            this.Controls.Add(this.課名label);
            this.Controls.Add(this.心得richTextBox);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox 心得richTextBox;
        private System.Windows.Forms.Label 課名label;
    }
}