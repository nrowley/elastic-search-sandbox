namespace ElasticSearch
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.methodBox = new System.Windows.Forms.ComboBox();
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.responseBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Method";
            // 
            // methodBox
            // 
            this.methodBox.FormattingEnabled = true;
            this.methodBox.Items.AddRange(new object[] {
            "GET",
            "PUT",
            "POST",
            "DELETE"});
            this.methodBox.Location = new System.Drawing.Point(68, 10);
            this.methodBox.Name = "methodBox";
            this.methodBox.Size = new System.Drawing.Size(121, 23);
            this.methodBox.TabIndex = 1;
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(13, 86);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(355, 395);
            this.messageBox.TabIndex = 2;
            this.messageBox.Text = "";
            // 
            // responseBox
            // 
            this.responseBox.Location = new System.Drawing.Point(433, 86);
            this.responseBox.Name = "responseBox";
            this.responseBox.Size = new System.Drawing.Size(355, 395);
            this.responseBox.TabIndex = 2;
            this.responseBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Response";
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(269, 10);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(179, 23);
            this.urlBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "URL";
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(357, 510);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 4;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.responseBox);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.methodBox);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Elastic Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox methodBox;
        private System.Windows.Forms.RichTextBox messageBox;
        private System.Windows.Forms.RichTextBox responseBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sendBtn;
    }
}

