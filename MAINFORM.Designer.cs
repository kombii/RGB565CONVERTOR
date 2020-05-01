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
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RGB888BOX = new System.Windows.Forms.TextBox();
            this.COLORCODEBOX = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
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
            this.label2.Location = new System.Drawing.Point(3, 242);
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
            this.label3.Location = new System.Drawing.Point(3, 288);
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
            this.label4.Location = new System.Drawing.Point(3, 334);
            this.label4.Margin = new System.Windows.Forms.Padding(20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "蓝色";
            // 
            // REDVALUE
            // 
            this.REDVALUE.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.REDVALUE.Location = new System.Drawing.Point(521, 244);
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
            this.GREENVALUE.Location = new System.Drawing.Point(521, 289);
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
            this.BLUEVALUE.Location = new System.Drawing.Point(521, 334);
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
            this.NoUseLabel.Location = new System.Drawing.Point(281, 32);
            this.NoUseLabel.Name = "NoUseLabel";
            this.NoUseLabel.Size = new System.Drawing.Size(0, 12);
            this.NoUseLabel.TabIndex = 15;
            // 
            // RGB565BOX
            // 
            this.RGB565BOX.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.RGB565BOX.Location = new System.Drawing.Point(103, 10);
            this.RGB565BOX.Name = "RGB565BOX";
            this.RGB565BOX.Size = new System.Drawing.Size(346, 34);
            this.RGB565BOX.TabIndex = 16;
            this.RGB565BOX.GotFocus += new System.EventHandler(this.RGB565BOX_GotFocus);
            this.RGB565BOX.LostFocus += new System.EventHandler(this.RGB565BOX_LostFocus);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("等线", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "RGB565";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("等线", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "红色";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("等线", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(3, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "色码";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("等线", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(3, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "RGB888";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("等线", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(3, 150);
            this.label9.Margin = new System.Windows.Forms.Padding(20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "红色";
            // 
            // RGB888BOX
            // 
            this.RGB888BOX.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.RGB888BOX.Location = new System.Drawing.Point(103, 55);
            this.RGB888BOX.Name = "RGB888BOX";
            this.RGB888BOX.Size = new System.Drawing.Size(346, 34);
            this.RGB888BOX.TabIndex = 23;
            this.RGB888BOX.GotFocus += new System.EventHandler(this.RGB888BOX_GotFocus);
            this.RGB888BOX.LostFocus += new System.EventHandler(this.RGB888BOX_LostFocus);
            // 
            // COLORCODEBOX
            // 
            this.COLORCODEBOX.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.COLORCODEBOX.Location = new System.Drawing.Point(103, 100);
            this.COLORCODEBOX.Name = "COLORCODEBOX";
            this.COLORCODEBOX.Size = new System.Drawing.Size(346, 34);
            this.COLORCODEBOX.TabIndex = 24;
            this.COLORCODEBOX.GotFocus += new System.EventHandler(this.COLORCODEBOX_GotFocus);
            this.COLORCODEBOX.LostFocus += new System.EventHandler(this.COLORCODEBOX_LostFocus);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.textBox4.Location = new System.Drawing.Point(103, 145);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(346, 34);
            this.textBox4.TabIndex = 25;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.textBox5.Location = new System.Drawing.Point(103, 190);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(346, 34);
            this.textBox5.TabIndex = 26;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 380);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.COLORCODEBOX);
            this.Controls.Add(this.RGB888BOX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
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
        internal System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox REDVALUE;
        private System.Windows.Forms.TextBox GREENVALUE;
        private System.Windows.Forms.TextBox BLUEVALUE;
        private System.Windows.Forms.Label NoUseLabel;
        private System.Windows.Forms.TextBox RGB565BOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox RGB888BOX;
        private System.Windows.Forms.TextBox COLORCODEBOX;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}

