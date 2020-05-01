namespace RGB565CONVERTOR
{
    partial class form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.REDBAR = new System.Windows.Forms.TrackBar();
            this.BLUEBAR = new System.Windows.Forms.TrackBar();
            this.GREENBAR = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.REDVALUE = new System.Windows.Forms.Label();
            this.GREENVLAUE = new System.Windows.Forms.Label();
            this.BLUEVALUE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.REDBAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BLUEBAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GREENBAR)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // REDBAR
            // 
            this.REDBAR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.REDBAR.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.REDBAR.Location = new System.Drawing.Point(66, 238);
            this.REDBAR.Margin = new System.Windows.Forms.Padding(0);
            this.REDBAR.Maximum = 255;
            this.REDBAR.Name = "REDBAR";
            this.REDBAR.Size = new System.Drawing.Size(452, 45);
            this.REDBAR.TabIndex = 1;
            this.REDBAR.TickStyle = System.Windows.Forms.TickStyle.None;
            this.REDBAR.Scroll += new System.EventHandler(this.REDBAR_Scroll);
            // 
            // BLUEBAR
            // 
            this.BLUEBAR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BLUEBAR.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BLUEBAR.Location = new System.Drawing.Point(66, 328);
            this.BLUEBAR.Margin = new System.Windows.Forms.Padding(0);
            this.BLUEBAR.Maximum = 255;
            this.BLUEBAR.Name = "BLUEBAR";
            this.BLUEBAR.Size = new System.Drawing.Size(452, 45);
            this.BLUEBAR.TabIndex = 4;
            this.BLUEBAR.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BLUEBAR.Scroll += new System.EventHandler(this.BLUEBAR_Scroll);
            // 
            // GREENBAR
            // 
            this.GREENBAR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GREENBAR.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GREENBAR.Location = new System.Drawing.Point(66, 283);
            this.GREENBAR.Margin = new System.Windows.Forms.Padding(0);
            this.GREENBAR.Maximum = 255;
            this.GREENBAR.Name = "GREENBAR";
            this.GREENBAR.Size = new System.Drawing.Size(452, 45);
            this.GREENBAR.TabIndex = 5;
            this.GREENBAR.TickStyle = System.Windows.Forms.TickStyle.None;
            this.GREENBAR.Scroll += new System.EventHandler(this.GREENBAR_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("等线", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "红色";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("等线", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "绿色";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("等线", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "蓝色";
            // 
            // REDVALUE
            // 
            this.REDVALUE.AutoSize = true;
            this.REDVALUE.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.REDVALUE.Location = new System.Drawing.Point(521, 238);
            this.REDVALUE.Name = "REDVALUE";
            this.REDVALUE.Size = new System.Drawing.Size(106, 39);
            this.REDVALUE.TabIndex = 9;
            this.REDVALUE.Text = "label5";
            // 
            // GREENVLAUE
            // 
            this.GREENVLAUE.AutoSize = true;
            this.GREENVLAUE.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GREENVLAUE.Location = new System.Drawing.Point(521, 283);
            this.GREENVLAUE.Name = "GREENVLAUE";
            this.GREENVLAUE.Size = new System.Drawing.Size(106, 39);
            this.GREENVLAUE.TabIndex = 10;
            this.GREENVLAUE.Text = "label6";
            // 
            // BLUEVALUE
            // 
            this.BLUEVALUE.AutoSize = true;
            this.BLUEVALUE.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BLUEVALUE.Location = new System.Drawing.Point(521, 328);
            this.BLUEVALUE.Name = "BLUEVALUE";
            this.BLUEVALUE.Size = new System.Drawing.Size(106, 39);
            this.BLUEVALUE.TabIndex = 11;
            this.BLUEVALUE.Text = "label7";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 380);
            this.Controls.Add(this.BLUEVALUE);
            this.Controls.Add(this.GREENVLAUE);
            this.Controls.Add(this.REDVALUE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GREENBAR);
            this.Controls.Add(this.BLUEBAR);
            this.Controls.Add(this.REDBAR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "form1";
            this.Text = "RGB取色器";
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.REDBAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BLUEBAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GREENBAR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar REDBAR;
        private System.Windows.Forms.TrackBar BLUEBAR;
        private System.Windows.Forms.TrackBar GREENBAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label REDVALUE;
        private System.Windows.Forms.Label GREENVLAUE;
        private System.Windows.Forms.Label BLUEVALUE;
        internal System.Windows.Forms.Timer timer1;
    }
}

