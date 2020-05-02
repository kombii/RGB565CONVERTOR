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
            this.REDVALUE = new System.Windows.Forms.TextBox();
            this.GREENVALUE = new System.Windows.Forms.TextBox();
            this.BLUEVALUE = new System.Windows.Forms.TextBox();
            this.NoUseLabel = new System.Windows.Forms.Label();
            this.RGB565BOX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RGB888BOX = new System.Windows.Forms.TextBox();
            this.RGB565COPY = new System.Windows.Forms.Button();
            this.COLORCODECOPY = new System.Windows.Forms.Button();
            this.NOTIFY = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.REDBAR.Location = new System.Drawing.Point(66, 100);
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
            this.BLUEBAR.Location = new System.Drawing.Point(66, 190);
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
            this.GREENBAR.Location = new System.Drawing.Point(66, 145);
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
            this.label2.Location = new System.Drawing.Point(3, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "红色";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("等线", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "绿色";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("等线", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "蓝色";
            // 
            // REDVALUE
            // 
            this.REDVALUE.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.REDVALUE.Location = new System.Drawing.Point(521, 106);
            this.REDVALUE.MaxLength = 3;
            this.REDVALUE.Name = "REDVALUE";
            this.REDVALUE.Size = new System.Drawing.Size(100, 34);
            this.REDVALUE.TabIndex = 12;
            this.REDVALUE.TextChanged += new System.EventHandler(this.REDVALUE_TextChanged);
            this.REDVALUE.GotFocus += new System.EventHandler(this.REDVALUE_GotFocus);
            this.REDVALUE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.REDVALUE_KeyPress);
            this.REDVALUE.LostFocus += new System.EventHandler(this.REDVALUE_LostFocus);
            // 
            // GREENVALUE
            // 
            this.GREENVALUE.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GREENVALUE.Location = new System.Drawing.Point(521, 151);
            this.GREENVALUE.MaxLength = 3;
            this.GREENVALUE.Name = "GREENVALUE";
            this.GREENVALUE.Size = new System.Drawing.Size(100, 34);
            this.GREENVALUE.TabIndex = 13;
            this.GREENVALUE.TextChanged += new System.EventHandler(this.GREENVALUE_TextChanged);
            this.GREENVALUE.GotFocus += new System.EventHandler(this.GREENVALUE_GotFocus);
            this.GREENVALUE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GREENVALUE_KeyPress);
            this.GREENVALUE.LostFocus += new System.EventHandler(this.GREENVALUE_LostFocus);
            // 
            // BLUEVALUE
            // 
            this.BLUEVALUE.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BLUEVALUE.Location = new System.Drawing.Point(521, 196);
            this.BLUEVALUE.MaxLength = 3;
            this.BLUEVALUE.Name = "BLUEVALUE";
            this.BLUEVALUE.Size = new System.Drawing.Size(100, 34);
            this.BLUEVALUE.TabIndex = 14;
            this.BLUEVALUE.TextChanged += new System.EventHandler(this.BLUEVALUE_TextChanged);
            this.BLUEVALUE.GotFocus += new System.EventHandler(this.BLUEVALUE_GotFocus);
            this.BLUEVALUE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BLUEVALUE_KeyPress);
            this.BLUEVALUE.LostFocus += new System.EventHandler(this.BLUEVALUE_LostFocus);
            // 
            // NoUseLabel
            // 
            this.NoUseLabel.AutoSize = true;
            this.NoUseLabel.BackColor = System.Drawing.Color.Transparent;
            this.NoUseLabel.Location = new System.Drawing.Point(621, 9);
            this.NoUseLabel.Name = "NoUseLabel";
            this.NoUseLabel.Size = new System.Drawing.Size(0, 12);
            this.NoUseLabel.TabIndex = 15;
            // 
            // RGB565BOX
            // 
            this.RGB565BOX.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.RGB565BOX.Location = new System.Drawing.Point(103, 8);
            this.RGB565BOX.Name = "RGB565BOX";
            this.RGB565BOX.Size = new System.Drawing.Size(346, 34);
            this.RGB565BOX.TabIndex = 16;
            this.RGB565BOX.Text = "0X";
            this.RGB565BOX.TextChanged += new System.EventHandler(this.RGB565BOX_TextChanged);
            this.RGB565BOX.GotFocus += new System.EventHandler(this.RGB565BOX_GotFocus);
            this.RGB565BOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RGB565BOX_KeyPress);
            this.RGB565BOX.LostFocus += new System.EventHandler(this.RGB565BOX_LostFocus);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("等线", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "RGB565";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("等线", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(3, 57);
            this.label7.Margin = new System.Windows.Forms.Padding(20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "RGB888";
            // 
            // RGB888BOX
            // 
            this.RGB888BOX.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.RGB888BOX.Location = new System.Drawing.Point(103, 52);
            this.RGB888BOX.Name = "RGB888BOX";
            this.RGB888BOX.Size = new System.Drawing.Size(346, 34);
            this.RGB888BOX.TabIndex = 24;
            this.RGB888BOX.Text = "0X";
            this.RGB888BOX.TextChanged += new System.EventHandler(this.RGB888BOX_TextChanged);
            this.RGB888BOX.GotFocus += new System.EventHandler(this.RGB888BOX_GotFocus);
            this.RGB888BOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RGB888BOX_KeyPress);
            this.RGB888BOX.LostFocus += new System.EventHandler(this.RGB888BOX_LostFocus);
            // 
            // RGB565COPY
            // 
            this.RGB565COPY.Font = new System.Drawing.Font("等线", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RGB565COPY.Location = new System.Drawing.Point(455, 8);
            this.RGB565COPY.Name = "RGB565COPY";
            this.RGB565COPY.Size = new System.Drawing.Size(112, 39);
            this.RGB565COPY.TabIndex = 27;
            this.RGB565COPY.Text = "复制数据";
            this.RGB565COPY.UseVisualStyleBackColor = true;
            this.RGB565COPY.Click += new System.EventHandler(this.RGB565COPY_Click);
            // 
            // COLORCODECOPY
            // 
            this.COLORCODECOPY.Font = new System.Drawing.Font("等线", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.COLORCODECOPY.Location = new System.Drawing.Point(455, 52);
            this.COLORCODECOPY.Name = "COLORCODECOPY";
            this.COLORCODECOPY.Size = new System.Drawing.Size(112, 38);
            this.COLORCODECOPY.TabIndex = 29;
            this.COLORCODECOPY.Text = "复制数据";
            this.COLORCODECOPY.UseVisualStyleBackColor = true;
            this.COLORCODECOPY.Click += new System.EventHandler(this.RGB888COPY_Click);
            // 
            // NOTIFY
            // 
            this.NOTIFY.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NOTIFY.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NOTIFY.Location = new System.Drawing.Point(0, 245);
            this.NOTIFY.Name = "NOTIFY";
            this.NOTIFY.Size = new System.Drawing.Size(635, 20);
            this.NOTIFY.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(580, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 33;
            this.label6.Text = "label6";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 265);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NOTIFY);
            this.Controls.Add(this.COLORCODECOPY);
            this.Controls.Add(this.RGB565COPY);
            this.Controls.Add(this.RGB888BOX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RGB565BOX);
            this.Controls.Add(this.NoUseLabel);
            this.Controls.Add(this.BLUEVALUE);
            this.Controls.Add(this.GREENVALUE);
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
            this.Activated += new System.EventHandler(this.form1_Activated);
            this.Deactivate += new System.EventHandler(this.form1_Deactivate);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form1_MouseMove);
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
        internal System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox REDVALUE;
        private System.Windows.Forms.TextBox GREENVALUE;
        private System.Windows.Forms.TextBox BLUEVALUE;
        private System.Windows.Forms.Label NoUseLabel;
        private System.Windows.Forms.TextBox RGB565BOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RGB888BOX;
        private System.Windows.Forms.Button RGB565COPY;
        private System.Windows.Forms.Button COLORCODECOPY;
        private System.Windows.Forms.Label NOTIFY;
        private System.Windows.Forms.Label label6;
    }
}

