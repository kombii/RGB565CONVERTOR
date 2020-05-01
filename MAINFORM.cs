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
            GREENVLAUE.Text = Convert.ToString(aimcolor.G);
            BLUEVALUE.Text = Convert.ToString(aimcolor.B);
            //8位色码

            //6位色码
        }

        //从拖动条更新目标颜色
        private void UpdateColorFromBar()
        {
            aimcolor = Color.FromArgb(REDBAR.Value, GREENBAR.Value, BLUEBAR.Value);
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

        private void Form1_Click(object sender, EventArgs e)
        {
            //打开系统颜色选择器，等待用户选择需要的颜色
            ColorDialog ColorForm = new ColorDialog();
            if (ColorForm.ShowDialog() == DialogResult.OK)
            {
                aimcolor = ColorForm.Color;
            }
        }
    }
}