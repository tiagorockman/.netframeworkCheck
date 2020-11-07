namespace checkNetFramework
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkText = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.richTextResult = new System.Windows.Forms.RichTextBox();
            this.githubButton = new System.Windows.Forms.Button();
            this.linkedinButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(84, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = ".NET FRAMEWORK VERSION CHECK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // checkText
            // 
            this.checkText.AutoSize = true;
            this.checkText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkText.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkText.Location = new System.Drawing.Point(46, 94);
            this.checkText.Name = "checkText";
            this.checkText.Size = new System.Drawing.Size(162, 21);
            this.checkText.TabIndex = 2;
            this.checkText.Text = "Verificando registro";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.AliceBlue;
            this.close.Location = new System.Drawing.Point(767, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 23);
            this.close.TabIndex = 3;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // richTextResult
            // 
            this.richTextResult.BackColor = System.Drawing.SystemColors.ControlText;
            this.richTextResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextResult.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextResult.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextResult.Location = new System.Drawing.Point(41, 136);
            this.richTextResult.MaximumSize = new System.Drawing.Size(676, 285);
            this.richTextResult.Name = "richTextResult";
            this.richTextResult.ReadOnly = true;
            this.richTextResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextResult.Size = new System.Drawing.Size(676, 232);
            this.richTextResult.TabIndex = 4;
            this.richTextResult.Text = "";
            // 
            // githubButton
            // 
            this.githubButton.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.githubButton.BackgroundImage = global::checkNetFramework.Properties.Resources.pngegg;
            this.githubButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.githubButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.githubButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.githubButton.ForeColor = System.Drawing.Color.Black;
            this.githubButton.Image = global::checkNetFramework.Properties.Resources.pngegg;
            this.githubButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.githubButton.Location = new System.Drawing.Point(608, 377);
            this.githubButton.Name = "githubButton";
            this.githubButton.Size = new System.Drawing.Size(75, 61);
            this.githubButton.TabIndex = 5;
            this.githubButton.UseVisualStyleBackColor = false;
            this.githubButton.Click += new System.EventHandler(this.githubButton_Click);
            // 
            // linkedinButton
            // 
            this.linkedinButton.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.linkedinButton.BackgroundImage = global::checkNetFramework.Properties.Resources.linkedin;
            this.linkedinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.linkedinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkedinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linkedinButton.ForeColor = System.Drawing.Color.Black;
            this.linkedinButton.Location = new System.Drawing.Point(713, 377);
            this.linkedinButton.Name = "linkedinButton";
            this.linkedinButton.Size = new System.Drawing.Size(67, 61);
            this.linkedinButton.TabIndex = 6;
            this.linkedinButton.UseVisualStyleBackColor = false;
            this.linkedinButton.Click += new System.EventHandler(this.linkedinButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkedinButton);
            this.Controls.Add(this.githubButton);
            this.Controls.Add(this.richTextResult);
            this.Controls.Add(this.close);
            this.Controls.Add(this.checkText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Framework Check";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label checkText;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.RichTextBox richTextResult;
        private System.Windows.Forms.Button githubButton;
        private System.Windows.Forms.Button linkedinButton;
    }
}

