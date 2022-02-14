namespace Demo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picFPImg = new System.Windows.Forms.PictureBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.txtTemplate1 = new System.Windows.Forms.TextBox();
            this.txtTemplate2 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnImport = new System.Windows.Forms.Button();
            this.textRes = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFPImg)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picFPImg
            // 
            this.picFPImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picFPImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picFPImg.Location = new System.Drawing.Point(6, 6);
            this.picFPImg.Name = "picFPImg";
            this.picFPImg.Size = new System.Drawing.Size(267, 267);
            this.picFPImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFPImg.TabIndex = 8;
            this.picFPImg.TabStop = false;
            // 
            // btnOutput
            // 
            this.btnOutput.Enabled = false;
            this.btnOutput.Location = new System.Drawing.Point(145, 304);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(131, 25);
            this.btnOutput.TabIndex = 12;
            this.btnOutput.Text = "Output BMP";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btCaptureBmp_Click);
            // 
            // txtTemplate1
            // 
            this.txtTemplate1.Location = new System.Drawing.Point(14, 13);
            this.txtTemplate1.Name = "txtTemplate1";
            this.txtTemplate1.Size = new System.Drawing.Size(268, 20);
            this.txtTemplate1.TabIndex = 13;
            this.txtTemplate1.Text = resources.GetString("txtTemplate1.Text");
            // 
            // txtTemplate2
            // 
            this.txtTemplate2.Location = new System.Drawing.Point(14, 62);
            this.txtTemplate2.Name = "txtTemplate2";
            this.txtTemplate2.Size = new System.Drawing.Size(268, 20);
            this.txtTemplate2.TabIndex = 14;
            this.txtTemplate2.Text = resources.GetString("txtTemplate2.Text");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(321, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(287, 364);
            this.tabControl1.TabIndex = 16;
            this.tabControl1.Tag = "S";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnImport);
            this.tabPage1.Controls.Add(this.picFPImg);
            this.tabPage1.Controls.Add(this.btnOutput);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(279, 338);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Зураг хөрвүүлэх";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Enabled = false;
            this.btnImport.Location = new System.Drawing.Point(8, 304);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(131, 25);
            this.btnImport.TabIndex = 13;
            this.btnImport.Text = "Import BMP";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // textRes
            // 
            this.textRes.Location = new System.Drawing.Point(6, 384);
            this.textRes.Name = "textRes";
            this.textRes.Size = new System.Drawing.Size(595, 224);
            this.textRes.TabIndex = 17;
            this.textRes.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 612);
            this.Controls.Add(this.textRes);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtTemplate2);
            this.Controls.Add(this.txtTemplate1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Fingerprind reader OBORTECH";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFPImg)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picFPImg;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.TextBox txtTemplate1;
        private System.Windows.Forms.TextBox txtTemplate2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.RichTextBox textRes;
    }
}

