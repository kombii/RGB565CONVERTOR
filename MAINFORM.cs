using System;
using System.Drawing;
using System.Windows.Forms;

namespace RGB565CONVERTOR
{
    public partial class form1 : Form
    {
        private Color aimcolor = Color.FromArgb(unchecked((int)0xFFFFFFFF));

        public form1()
        {
            InitializeComponent();
        }

        //将控件的焦点转移到label标签，保证点击控件不会出现线框
        private void Control_Lose_Focus()    
        {
            NoUseLabel.Focus();
        }

        //更新所有控件的颜色和状态
        private void Updateall()
        {
            //颜色显示区域颜色
            this.BackColor = aimcolor;
            REDBAR.BackColor = Color.FromArgb(aimcolor.R, 0, 0);
            GREENBAR.BackColor = Color.FromArgb(0, aimcolor.G, 0);
            BLUEBAR.BackColor = Color.FromArgb(0, 0, aimcolor.B);
            //三个拖动条进度
            REDBAR.Value = aimcolor.R;
            GREENBAR.Value = aimcolor.G;
            BLUEBAR.Value = aimcolor.B;
            //三个颜色数值显示器
            REDVALUE.Text = Convert.ToString(aimcolor.R);
            GREENVALUE.Text = Convert.ToString(aimcolor.G);
            BLUEVALUE.Text = Convert.ToString(aimcolor.B);
            //8位色码

            //6位色码
        }

        //从拖动条更新目标颜色
        private void UpdateColorFromBar()
        {
            aimcolor = Color.FromArgb(REDBAR.Value, GREENBAR.Value, BLUEBAR.Value);
        }

        //从数字色码更新目标颜色，1更新红色，2更新绿色，3更新蓝色
        private void UpdateColorFromNumWord(int inputnum)
        {
            switch (inputnum)
            {
                case 1:
                    aimcolor = Color.FromArgb(
                        Int16.Parse(REDVALUE.Text),
                        aimcolor.G,
                        aimcolor.B
                        );
                    break;

                case 2:
                    aimcolor = Color.FromArgb(
                        aimcolor.R,
                        Int16.Parse(GREENVALUE.Text),
                        aimcolor.B
                    );
                    break;

                case 3:
                    aimcolor = Color.FromArgb(
                        aimcolor.R,
                        aimcolor.G,
                        Int16.Parse(BLUEVALUE.Text)
                    );
                    break;

                default:
                    break;
            }
        }

        //从6字节色码更新目标颜色
        private void UpdateColorFrom6Word()
        {
            aimcolor = Color.FromArgb(REDBAR.Value, GREENBAR.Value, BLUEBAR.Value);
        }

        //从8字节色码（包含不生效的透明度）更新目标颜色
        private void UpdateColorFrom8Word()
        {
            aimcolor = Color.FromArgb(REDBAR.Value, GREENBAR.Value, BLUEBAR.Value);
        }

        //使用定时器触发界面更新
        private void timer1_Tick(object sender, EventArgs e)
        {
            Updateall();
        }

        private void REDBAR_Scroll(object sender, EventArgs e)
        {
            //设定目标颜色红色分值
            UpdateColorFromBar();
        }

        private void BLUEBAR_Scroll(object sender, EventArgs e)
        {
            //设定目标颜色蓝色分值
            UpdateColorFromBar();
        }

        private void GREENBAR_Scroll(object sender, EventArgs e)
        {
            //设定目标颜色绿色分值
            UpdateColorFromBar();
        }

        private void REDVALUE_GotFocus(object sender, EventArgs e)
        {
            //手动设定目标颜色，取消刷新
            timer1.Enabled = false;
        }

        private void GREENVALUE_GotFocus(object sender, EventArgs e)
        {
            //手动设定目标颜色，取消刷新
            timer1.Enabled = false;
        }

        private void BLUEVALUE_GotFocus(object sender, EventArgs e)
        {
            //手动设定目标颜色，取消刷新
            timer1.Enabled = false;
        }

        private void REDVALUE_LostFocus(object sender, EventArgs e)
        {
            //焦点变化，启动刷新
            timer1.Enabled = true;
        }

        private void GREENVALUE_LostFocus(object sender, EventArgs e)
        {
            //焦点变化，启动刷新
            timer1.Enabled = true;
        }

        private void BLUEVALUE_LostFocus(object sender, EventArgs e)
        {
            //焦点变化，启动刷新
            timer1.Enabled = true;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
            Control_Lose_Focus();//失去焦点，防止输入完立即点击背景无法自动启动刷新
            //打开系统颜色选择器，等待用户选择需要的颜色
            ColorDialog ColorForm = new ColorDialog();
            if (ColorForm.ShowDialog() == DialogResult.OK)
            {
                aimcolor = ColorForm.Color;
            }
        }

        private void REDVALUE_KeyPress(object sender, KeyPressEventArgs e)
        {
            //限制输入仅为数字和.
            if (e.KeyChar == '.' && (REDVALUE.Text.Contains(".") || REDVALUE.Text == ""))
            {
                e.Handled = true;
            }
            if (REDVALUE.Text == "")
            {
                if (e.KeyChar <= '0' || e.KeyChar > '9')
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void GREENVALUE_KeyPress(object sender, KeyPressEventArgs e)
        {
            //限制输入仅为数字和.
            if (e.KeyChar == '.' && (REDVALUE.Text.Contains(".") || REDVALUE.Text == ""))
            {
                e.Handled = true;
            }
            if (REDVALUE.Text == "")
            {
                if (e.KeyChar <= '0' || e.KeyChar > '9')
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void BLUEVALUE_KeyPress(object sender, KeyPressEventArgs e)
        {
            //限制输入仅为数字和.
            if (e.KeyChar == '.' && (REDVALUE.Text.Contains(".") || REDVALUE.Text == ""))
            {
                e.Handled = true;
            }
            if (REDVALUE.Text == "")
            {
                if (e.KeyChar <= '0' || e.KeyChar > '9')
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void REDVALUE_TextChanged(object sender, EventArgs e)
        {
            //转换输入内容，在窗口初始化的时候可以为空（null）需处理异常
            Int32 answer;
            try
            {
                answer = int.Parse(REDVALUE.Text);
            }
            catch (FormatException)
            {
                return;
            }
            //判断输入数字范围
            if (answer > 255 || answer < 0)
            {
                MessageBox.Show("超过限值");
            }
            else
            {
                UpdateColorFromNumWord(1);//仅更新自己对应的颜色
                timer1.Enabled = true;//更新完毕启动刷新
            }
        }

        private void GREENVALUE_TextChanged(object sender, EventArgs e)
        {
            //转换输入内容，在窗口初始化的时候可以为空（null）需处理异常
            Int32 answer;
            try
            {
                answer = int.Parse(GREENVALUE.Text);
            }
            catch (FormatException)
            {
                return;
            }
            //判断输入数字范围
            if (answer > 255 || answer < 0)
            {
                MessageBox.Show("超过限值");
            }
            else
            {
                UpdateColorFromNumWord(2);//仅更新自己对应的颜色
                timer1.Enabled = true;//更新完毕启动刷新
            }
        }

        private void BLUEVALUE_TextChanged(object sender, EventArgs e)
        {
            //转换输入内容，在窗口初始化的时候可以为空（null）需处理异常
            Int32 answer;
            try
            {
                answer = int.Parse(BLUEVALUE.Text);
            }
            catch (FormatException)
            {
                return;
            }
            //判断输入数字范围
            if (answer > 255 || answer < 0)
            {
                MessageBox.Show("超过限值");
            }
            else
            {
                UpdateColorFromNumWord(3);//仅更新自己对应的颜色
                timer1.Enabled = true;//更新完毕启动刷新
            }
        }
    }
}