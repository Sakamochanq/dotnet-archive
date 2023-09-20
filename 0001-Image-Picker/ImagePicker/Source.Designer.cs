namespace ImagePicker
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
            this.ResultScreenBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CaptureButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ColorPickButton = new System.Windows.Forms.Button();
            this.PickColorPanel = new System.Windows.Forms.Panel();
            this.HTMLColorBox = new System.Windows.Forms.TextBox();
            this.TopMostCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowRGBCheckBox = new System.Windows.Forms.CheckBox();
            this.RGBLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ResultScreenBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultScreenBox
            // 
            this.ResultScreenBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ResultScreenBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultScreenBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResultScreenBox.Location = new System.Drawing.Point(12, 12);
            this.ResultScreenBox.Name = "ResultScreenBox";
            this.ResultScreenBox.Size = new System.Drawing.Size(679, 442);
            this.ResultScreenBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ResultScreenBox.TabIndex = 0;
            this.ResultScreenBox.TabStop = false;
            this.ResultScreenBox.Click += new System.EventHandler(this.ResultScreenBox_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.RGBLabel);
            this.panel1.Controls.Add(this.ShowRGBCheckBox);
            this.panel1.Controls.Add(this.TopMostCheckBox);
            this.panel1.Controls.Add(this.HTMLColorBox);
            this.panel1.Controls.Add(this.PickColorPanel);
            this.panel1.Controls.Add(this.CaptureButton);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.ColorPickButton);
            this.panel1.Controls.Add(this.ResultScreenBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 466);
            this.panel1.TabIndex = 1;
            // 
            // CaptureButton
            // 
            this.CaptureButton.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CaptureButton.Location = new System.Drawing.Point(698, 12);
            this.CaptureButton.Name = "CaptureButton";
            this.CaptureButton.Size = new System.Drawing.Size(252, 70);
            this.CaptureButton.TabIndex = 3;
            this.CaptureButton.Text = "Capture (&C)";
            this.CaptureButton.UseVisualStyleBackColor = true;
            this.CaptureButton.Click += new System.EventHandler(this.CaptureButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SaveButton.Location = new System.Drawing.Point(698, 165);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(252, 70);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save (&S)";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ColorPickButton
            // 
            this.ColorPickButton.BackColor = System.Drawing.Color.White;
            this.ColorPickButton.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ColorPickButton.Location = new System.Drawing.Point(698, 89);
            this.ColorPickButton.Name = "ColorPickButton";
            this.ColorPickButton.Size = new System.Drawing.Size(252, 70);
            this.ColorPickButton.TabIndex = 1;
            this.ColorPickButton.Text = "ColorPick (&P)";
            this.ColorPickButton.UseVisualStyleBackColor = false;
            this.ColorPickButton.Click += new System.EventHandler(this.ColorPickButton_Click);
            // 
            // PickColorPanel
            // 
            this.PickColorPanel.BackColor = System.Drawing.Color.White;
            this.PickColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PickColorPanel.Location = new System.Drawing.Point(699, 353);
            this.PickColorPanel.Name = "PickColorPanel";
            this.PickColorPanel.Size = new System.Drawing.Size(70, 70);
            this.PickColorPanel.TabIndex = 4;
            // 
            // HTMLColorBox
            // 
            this.HTMLColorBox.Location = new System.Drawing.Point(698, 429);
            this.HTMLColorBox.Name = "HTMLColorBox";
            this.HTMLColorBox.ReadOnly = true;
            this.HTMLColorBox.Size = new System.Drawing.Size(253, 25);
            this.HTMLColorBox.TabIndex = 5;
            this.HTMLColorBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TopMostCheckBox
            // 
            this.TopMostCheckBox.AutoSize = true;
            this.TopMostCheckBox.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TopMostCheckBox.Location = new System.Drawing.Point(699, 250);
            this.TopMostCheckBox.Name = "TopMostCheckBox";
            this.TopMostCheckBox.Size = new System.Drawing.Size(115, 24);
            this.TopMostCheckBox.TabIndex = 6;
            this.TopMostCheckBox.Text = "TopMost";
            this.TopMostCheckBox.UseVisualStyleBackColor = true;
            this.TopMostCheckBox.CheckedChanged += new System.EventHandler(this.TopMostCheckBox_CheckedChanged);
            // 
            // ShowRGBCheckBox
            // 
            this.ShowRGBCheckBox.AutoSize = true;
            this.ShowRGBCheckBox.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ShowRGBCheckBox.Location = new System.Drawing.Point(699, 280);
            this.ShowRGBCheckBox.Name = "ShowRGBCheckBox";
            this.ShowRGBCheckBox.Size = new System.Drawing.Size(134, 24);
            this.ShowRGBCheckBox.TabIndex = 7;
            this.ShowRGBCheckBox.Text = "Show RGB";
            this.ShowRGBCheckBox.UseVisualStyleBackColor = true;
            this.ShowRGBCheckBox.CheckedChanged += new System.EventHandler(this.ShowRGBCheckBox_CheckedChanged);
            // 
            // RGBLabel
            // 
            this.RGBLabel.AutoSize = true;
            this.RGBLabel.Location = new System.Drawing.Point(779, 405);
            this.RGBLabel.Name = "RGBLabel";
            this.RGBLabel.Size = new System.Drawing.Size(35, 18);
            this.RGBLabel.TabIndex = 8;
            this.RGBLabel.Text = "***";
            // 
            // Source
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 466);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Source";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Picker   |   Sakamochanq";
            ((System.ComponentModel.ISupportInitialize)(this.ResultScreenBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ResultScreenBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ColorPickButton;
        private System.Windows.Forms.Button CaptureButton;
        private System.Windows.Forms.Panel PickColorPanel;
        private System.Windows.Forms.TextBox HTMLColorBox;
        private System.Windows.Forms.CheckBox ShowRGBCheckBox;
        private System.Windows.Forms.CheckBox TopMostCheckBox;
        private System.Windows.Forms.Label RGBLabel;
    }
}

