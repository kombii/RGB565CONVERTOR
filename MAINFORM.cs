using System;
using System.Drawing;
using System.Windows.Forms;

namespace RGB565CONVERTOR
{
    public partial class form1 : Form
    {
        private Color aimcolor = Color.FromArgb(unchecked((int)0xFFFFFFFF));
        private int Color565;
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
            //RGB888
            RGB888BOX.Text = ColorTranslator.ToHtml(aimcolor);
            //RGB565
            Color565 = ((aimcolor.R >> 3) & 0x1F) << 11  //r
                     | ((aimcolor.G >> 2) & 0x3F) << 5   //g
                     | ((aimcolor.B >> 3) & 0x1F) << 0;  //b
            //转换888到565
            string Texttemp = Convert.ToString(Color565, 16).ToUpper();
            //转换为16进制表示的文本，并且大写
            if (Texttemp.Length < 4)
            {
                int j = 4 - Texttemp.Length;
                for (int i = 0; i < j; i++)
                {
                    Texttemp = "0" + Texttemp;
                }
            }
            //补全4位
            RGB565BOX.Text = "0X" + Texttemp;
            //加上0X
        }

        // 处理剪贴板
        private void CPBoardProcess()
        {
            //TODO处理剪贴板数据，自动更新颜色
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
            aimcolor = ColorTranslator.FromHtml(RGB888BOX.Text);
        }

        //使用定时器触发界面更新
        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Enabled = !label6.Enabled;
            Updateall();
        }

        //拖动事件
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

        //获得焦点
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

        private void RGB565BOX_GotFocus(object sender, EventArgs e)
        {
            //手动设定目标颜色，取消刷新
            timer1.Enabled = false;
        }

        private void RGB888BOX_GotFocus(object sender, EventArgs e)
        {
            //手动设定目标颜色，取消刷新
            timer1.Enabled = false;
        }

        //失去焦点
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

        private void RGB565BOX_LostFocus(object sender, EventArgs e)
        {
            //焦点变化，启动刷新
            timer1.Enabled = true;
        }

        private void RGB888BOX_LostFocus(object sender, EventArgs e)
        {
            //焦点变化，启动刷新
            timer1.Enabled = true;
        }

        //底色点击事件
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

        //按键按下
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

        private void RGB565BOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            //限制输入仅为数字和A-F
            if (e.KeyChar == 'X' && (RGB565BOX.Text.Contains("X") || RGB565BOX.Text == ""))
            {
                e.Handled = true;
            }
            else if ((e.KeyChar < '0' || e.KeyChar > 'F') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (RGB565BOX.Text.Length >= 6 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void RGB888BOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '#' && RGB888BOX.Text == "")
            {
                e.Handled = true;
            }
            //空时只允许输入#，
            if (e.KeyChar == '#' && RGB888BOX.Text.Contains("#"))
            {
                e.Handled = true;
            }
            //有#时不可以再输入一个
            if (e.KeyChar >= 'a' && e.KeyChar <= 'f')
            {
                e.KeyChar = (char)(e.KeyChar - ('a' - 'A'));
            }
            //小写转大写
            if ((e.KeyChar < '0' || e.KeyChar > 'F') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            //限制输入仅为数字和A-F，并且允许按下删除键
        }

        //文本变化
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
                Updateall();//仅刷新一次，防止卡死
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
                Updateall();//仅刷新一次，防止卡死
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
                Updateall();//仅刷新一次，防止卡死
            }
        }

        private void RGB565BOX_TextChanged(object sender, EventArgs e)
        {
            if (RGB565BOX.Text == "" || RGB565BOX.Text == "0")
            {
                RGB565BOX.Text = "0X";
                RGB565BOX.Select(2, 0);
            }
        }

        private void RGB888BOX_TextChanged(object sender, EventArgs e)
        {
            if (RGB888BOX.Text == "" || !RGB888BOX.Text.Contains("#"))
            {
                RGB888BOX.Text = "#";
                RGB888BOX.Select(1, 0);
            }
            if (RGB888BOX.Text.Length == 7)
            {
                UpdateColorFrom6Word();
                Updateall();//仅刷新一次，防止卡死
            }
        }

        private void RGB565COPY_Click(object sender, EventArgs e)
        {
            if (RGB565BOX.Text != "")
            {
                Clipboard.SetDataObject(RGB565BOX.Text.Trim());
                NOTIFY.Text = "RGB565 复制成功";
            }
        }

        private void RGB888COPY_Click(object sender, EventArgs e)
        {
            if (RGB888BOX.Text != "")
            {
                Clipboard.SetDataObject(RGB888BOX.Text.Trim());
                NOTIFY.Text = "RGB888 复制成功";
            }
        }

        private void form1_MouseMove(object sender, MouseEventArgs e)
        {
            NOTIFY.Text = "准备就绪.....点击任何空白区域/拖动条/数据区以手动指定颜色";
        }

        private void form1_Activated(object sender, EventArgs e)
        {
            NOTIFY.Text = "切换到前台...准备处理剪贴板数据...";
            CPBoardProcess();
        }

        private void form1_Deactivate(object sender, EventArgs e)
        {
            NOTIFY.Text = "切换到后台...等待操作中...";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
    }
}