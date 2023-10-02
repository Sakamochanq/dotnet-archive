namespace AnalogClock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Source));
            this.AnalogClockBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AnalogClockBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AnalogClockBox
            // 
            this.AnalogClockBox.BackColor = System.Drawing.Color.White;
            this.AnalogClockBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnalogClockBox.Location = new System.Drawing.Point(13, 13);
            this.AnalogClockBox.Name = "AnalogClockBox";
            this.AnalogClockBox.Size = new System.Drawing.Size(500, 500);
            this.AnalogClockBox.TabIndex = 0;
            this.AnalogClockBox.TabStop = false;
            this.AnalogClockBox.Paint += new System.Windows.Forms.PaintEventHandler(this.AnalogClockBox_Paint);
            // 
            // Source
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(526, 524);
            this.Controls.Add(this.AnalogClockBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Source";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analog Clock   |   Sakamochanq";
            ((System.ComponentModel.ISupportInitialize)(this.AnalogClockBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AnalogClockBox;
    }
}

