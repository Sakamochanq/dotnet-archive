namespace StopMotionCapture
{
    partial class Source
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Source));
            this.CaptureBox = new System.Windows.Forms.PictureBox();
            this.StopButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PlayButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StopMotionTick = new System.Windows.Forms.Timer(this.components);
            this.RetryButton = new System.Windows.Forms.Button();
            this.TopMostCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CaptureBox
            // 
            this.CaptureBox.BackColor = System.Drawing.Color.White;
            this.CaptureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CaptureBox.Location = new System.Drawing.Point(3, 3);
            this.CaptureBox.Name = "CaptureBox";
            this.CaptureBox.Size = new System.Drawing.Size(678, 445);
            this.CaptureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CaptureBox.TabIndex = 0;
            this.CaptureBox.TabStop = false;
            // 
            // StopButton
            // 
            this.StopButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StopButton.BackgroundImage")));
            this.StopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StopButton.Location = new System.Drawing.Point(12, 11);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(50, 50);
            this.StopButton.TabIndex = 2;
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TopMostCheckBox);
            this.panel1.Controls.Add(this.RetryButton);
            this.panel1.Controls.Add(this.PlayButton);
            this.panel1.Controls.Add(this.StopButton);
            this.panel1.Location = new System.Drawing.Point(12, 481);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 73);
            this.panel1.TabIndex = 3;
            // 
            // PlayButton
            // 
            this.PlayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayButton.BackgroundImage")));
            this.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayButton.Location = new System.Drawing.Point(73, 11);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(50, 50);
            this.PlayButton.TabIndex = 3;
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.CaptureBox);
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 451);
            this.panel2.TabIndex = 4;
            // 
            // StopMotionTick
            // 
            this.StopMotionTick.Interval = 1;
            this.StopMotionTick.Tick += new System.EventHandler(this.StopMotionTick_Tick);
            // 
            // RetryButton
            // 
            this.RetryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RetryButton.BackgroundImage")));
            this.RetryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RetryButton.Location = new System.Drawing.Point(134, 11);
            this.RetryButton.Name = "RetryButton";
            this.RetryButton.Size = new System.Drawing.Size(50, 50);
            this.RetryButton.TabIndex = 4;
            this.RetryButton.UseVisualStyleBackColor = true;
            this.RetryButton.Click += new System.EventHandler(this.RetryButton_Click);
            // 
            // TopMostCheckBox
            // 
            this.TopMostCheckBox.AutoSize = true;
            this.TopMostCheckBox.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TopMostCheckBox.Location = new System.Drawing.Point(200, 27);
            this.TopMostCheckBox.Name = "TopMostCheckBox";
            this.TopMostCheckBox.Size = new System.Drawing.Size(22, 21);
            this.TopMostCheckBox.TabIndex = 5;
            this.TopMostCheckBox.UseVisualStyleBackColor = true;
            this.TopMostCheckBox.CheckedChanged += new System.EventHandler(this.TopMostCheckBox_CheckedChanged);
            // 
            // Source
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(712, 568);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Source";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stop Motion Capture   |   Sakamochanq";
            ((System.ComponentModel.ISupportInitialize)(this.CaptureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CaptureBox;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer StopMotionTick;
        private System.Windows.Forms.Button RetryButton;
        private System.Windows.Forms.CheckBox TopMostCheckBox;
    }
}

