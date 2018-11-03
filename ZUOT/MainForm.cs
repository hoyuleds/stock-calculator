/*
 * 功能：计算股票做T时的利润
 * 日期：20160820
 * 作者：曹小枫
 * QQ：6086119
 * E-mail：ol@xiaofeng.org
*/
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ZUOT
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //定义类型
            double iyinhuae, iyongjine, iyongjines, iyongjinej, ilirun;
            double ishuliang = double.Parse(ShuLiang.Text);
            double ijinjia = double.Parse(JinJia.Text);
            double ishoujia = double.Parse(ShouJia.Text);
            double iyinhualv = double.Parse(YinHuaLv.Text);
            double iyongjinlv = double.Parse(YongJinLv.Text);
            //计算印花税额：股票数量*售价*税率
            iyinhuae = ishuliang * ishoujia * iyinhualv / 1000;
            iyinhuae = Math.Round(iyinhuae, 3);
            //股票卖出时佣金金额：股票数量*售价*佣金率
            iyongjines = ishuliang * ishoujia * iyongjinlv / 1000;
            //佣金金额有最低5元限制
            if (iyongjines <= 5)
            {
                iyongjines = 5;
            }
            //股票购买时佣金金额：股票数量*进价*佣金率
            iyongjinej = ishuliang * ijinjia * iyongjinlv / 1000;
            //佣金金额有最低5元限制
            if (iyongjinej <= 5)
            {
                iyongjinej = 5;
            }
            //佣金金额=购进佣金额+卖出佣金额
            iyongjine = iyongjinej + iyongjines;
            //保留3位小数
            iyongjine = Math.Round(iyongjine, 3);
            //利润率：股票数量*（售价-进价）- 印花税额 - 佣金金额
            ilirun = (ishuliang * (ishoujia - ijinjia) - iyinhuae - iyongjine);
            //保留3位小数
            ilirun = Math.Round(ilirun, 3);
            //数字转换成字符串，输出
            string slirun = ilirun.ToString();
            string syinhuae = iyinhuae.ToString();
            string syongjine = iyongjine.ToString();
            LiRun.Text = slirun;
            YongJine.Text = syongjine;
            YinHuae.Text = syinhuae;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //重置数据，并清除利润额、佣金额、印花税额
            ShuLiang.Text = "1";
            JinJia.Text = "1";
            ShouJia.Text = "1";
            LiRun.Clear();
            YongJine.Clear();
            YinHuae.Clear();
            LiRun.Clear();
        }

        private void 重置SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //重置数据，并清除利润额、佣金额、印花税额
            ShuLiang.Text = "1";
            JinJia.Text = "1";
            ShouJia.Text = "1";
            LiRun.Clear();
            YongJine.Clear();
            YinHuae.Clear();
            LiRun.Clear();
        }

        private void 计算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //定义类型
            double iyinhuae, iyongjine, iyongjines, iyongjinej, ilirun;
            double ishuliang = double.Parse(ShuLiang.Text);
            double ijinjia = double.Parse(JinJia.Text);
            double ishoujia = double.Parse(ShouJia.Text);
            double iyinhualv = double.Parse(YinHuaLv.Text);
            double iyongjinlv = double.Parse(YongJinLv.Text);
            //计算印花税额：股票数量*售价*税率
            iyinhuae = ishuliang * ishoujia * iyinhualv / 1000;
            iyinhuae = Math.Round(iyinhuae, 3);
            //股票卖出时佣金金额：股票数量*售价*佣金率
            iyongjines = ishuliang * ishoujia * iyongjinlv / 1000;
            //佣金金额有最低5元限制
            if (iyongjines <= 5)
            {
                iyongjines = 5;
            }
            //股票购买时佣金金额：股票数量*进价*佣金率
            iyongjinej = ishuliang * ijinjia * iyongjinlv / 1000;
            //佣金金额有最低5元限制
            if (iyongjinej <= 5)
            {
                iyongjinej = 5;
            }
            //佣金金额=购进佣金额+卖出佣金额
            iyongjine = iyongjinej + iyongjines;
            //保留3位小数
            iyongjine = Math.Round(iyongjine, 3);
            //利润率：股票数量*（售价-进价）- 印花税额 - 佣金金额
            ilirun = (ishuliang * (ishoujia - ijinjia) - iyinhuae - iyongjine);
            //保留3位小数
            ilirun = Math.Round(ilirun, 3);
            //数字转换成字符串，输出
            string slirun = ilirun.ToString();
            string syinhuae = iyinhuae.ToString();
            string syongjine = iyongjine.ToString();
            LiRun.Text = slirun;
            YongJine.Text = syongjine;
            YinHuae.Text = syinhuae;
        }
        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //退出程序
            this.Close(); ;
        }

        private void 小枫作品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打开小枫客栈
            string url = "http://www.xiaofeng.org";
            Process.Start(url);
        }

        private void ShuLiang_KeyPress(object sender, KeyPressEventArgs e)
        {
            //IsNumber的作用是判断输入的按键是否为数字
            //(char)8 是退格键的键值，可允许用户敲退格键对输入的数字进行修改
            //针对其他按键输入则提示错误
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void JinJia_KeyPress(object sender, KeyPressEventArgs e)
        {
            //IsNumber的作用是判断输入的按键是否为数字
            //(char)8 是退格键的键值，可允许用户敲退格键对输入的数字进行修改
            //针对其他按键输入则提示错误
            bool IsContainsDot = this.JinJia.Text.Contains("."); //定义小数点.的类型
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8 && e.KeyChar != (char)46)
            {
                e.Handled = true;
            }
            else if (IsContainsDot && (e.KeyChar == 46))
            {
                e.Handled=true; //如果已经输入一个小数点.，再次输入时
            }
        }

        private void ShouJia_KeyPress(object sender, KeyPressEventArgs e)
        {
            //IsNumber的作用是判断输入的按键是否为数字
            //(char)8 是退格键的键值，可允许用户敲退格键对输入的数字进行修改
            //针对其他按键输入则提示错误
            bool IsContainsDot = this.ShouJia.Text.Contains("."); //定义小数点.的类型
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8 && e.KeyChar != (char)46)
            {
                e.Handled = true;
            }
            else if (IsContainsDot && (e.KeyChar == 46))
            {
                e.Handled = true; //如果已经输入一个小数点.，再次输入时
            }
        }

        private void YinHuaLv_KeyPress(object sender, KeyPressEventArgs e)
        {
            //IsNumber的作用是判断输入的按键是否为数字
            //(char)8 是退格键的键值，可允许用户敲退格键对输入的数字进行修改
            //针对其他按键输入则提示错误
            bool IsContainsDot = this.YinHuaLv.Text.Contains("."); //定义小数点.的类型
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8 && e.KeyChar != (char)46)
            {
                e.Handled = true;
            }
            else if (IsContainsDot && (e.KeyChar == 46))
            {
                e.Handled = true; //如果已经输入一个小数点.，再次输入时
            }
        }

        private void YongJinLv_KeyPress(object sender, KeyPressEventArgs e)
        {
            //IsNumber的作用是判断输入的按键是否为数字
            //(char)8 是退格键的键值，可允许用户敲退格键对输入的数字进行修改
            //针对其他按键输入则提示错误
            //IsNumber的作用是判断输入的按键是否为数字
            //(char)8 是退格键的键值，可允许用户敲退格键对输入的数字进行修改
            //针对其他按键输入则提示错误
            bool IsContainsDot = this.YongJinLv.Text.Contains("."); //定义小数点.的类型
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8 && e.KeyChar != (char)46)
            {
                e.Handled = true;
            }
            else if (IsContainsDot && (e.KeyChar == 46))
            {
                e.Handled = true; //如果已经输入一个小数点.，再次输入时
            }
        }

        private void YinHuae_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            //(char)8 是退格键的键值，可允许用户敲退格键对输入的数字进行修改
            //if (e.KeyChar != (char)8)
           // {
                e.Handled = true;
           // }
        }

        private void YongJine_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            //(char)8 是退格键的键值，可允许用户敲退格键对输入的数字进行修改
            /*if (e.KeyChar != (char)8)
            {
                e.Handled = true;
            }*/
        }

        private void LiRun_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            //(char)8 是退格键的键值，可允许用户敲退格键对输入的数字进行修改
           /* if (e.KeyChar != (char)8)
            {
                e.Handled = true;
            }*/
        }

        private void YinHuae_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShuLiang_TextChanged(object sender, EventArgs e)
        {
            //判断是否为空，为空就置1
            if (string.IsNullOrEmpty(ShuLiang.Text))
            {
                ShuLiang.Text = "1";
            }
            //定义类型
            double iyinhuae, iyongjine, iyongjines, iyongjinej, ilirun;
            double ishuliang = double.Parse(ShuLiang.Text);
            double ijinjia = double.Parse(JinJia.Text);
            double ishoujia = double.Parse(ShouJia.Text);
            double iyinhualv = double.Parse(YinHuaLv.Text);
            double iyongjinlv = double.Parse(YongJinLv.Text);
            //计算印花税额：股票数量*售价*税率
            iyinhuae = ishuliang * ishoujia * iyinhualv / 1000;
            iyinhuae = Math.Round(iyinhuae, 3);
            //股票卖出时佣金金额：股票数量*售价*佣金率
            iyongjines = ishuliang * ishoujia * iyongjinlv / 1000;
            //佣金金额有最低5元限制
            if (iyongjines <= 5)
            {
                iyongjines = 5;
            }
            //股票购买时佣金金额：股票数量*进价*佣金率
            iyongjinej = ishuliang * ijinjia * iyongjinlv / 1000;
            //佣金金额有最低5元限制
            if (iyongjinej <= 5)
            {
                iyongjinej = 5;
            }
            //佣金金额=购进佣金额+卖出佣金额
            iyongjine = iyongjinej + iyongjines;
            //保留3位小数
            iyongjine = Math.Round(iyongjine, 3);
            //利润率：股票数量*（售价-进价）- 印花税额 - 佣金金额
            ilirun = (ishuliang * (ishoujia - ijinjia) - iyinhuae - iyongjine);
            //保留3位小数
            ilirun = Math.Round(ilirun, 3);
            //数字转换成字符串，输出
            string slirun = ilirun.ToString();
            string syinhuae = iyinhuae.ToString();
            string syongjine = iyongjine.ToString();
            LiRun.Text = slirun;
            YongJine.Text = syongjine;
            YinHuae.Text = syinhuae;

        }

        private void ShouJia_TextChanged(object sender, EventArgs e)
        {
            //判断是否为空，为空就置1
            if (string.IsNullOrEmpty(ShouJia.Text))
            {
                ShouJia.Text = "1";
            }
            //定义类型
            double iyinhuae, iyongjine, iyongjines, iyongjinej, ilirun;
            double ishuliang = double.Parse(ShuLiang.Text);
            double ijinjia = double.Parse(JinJia.Text);
            double ishoujia = double.Parse(ShouJia.Text);
            double iyinhualv = double.Parse(YinHuaLv.Text);
            double iyongjinlv = double.Parse(YongJinLv.Text);
            //计算印花税额：股票数量*售价*税率
            iyinhuae = ishuliang * ishoujia * iyinhualv / 1000;
            iyinhuae = Math.Round(iyinhuae, 3);
            //股票卖出时佣金金额：股票数量*售价*佣金率
            iyongjines = ishuliang * ishoujia * iyongjinlv / 1000;
            //佣金金额有最低5元限制
            if (iyongjines <= 5)
            {
                iyongjines = 5;
            }
            //股票购买时佣金金额：股票数量*进价*佣金率
            iyongjinej = ishuliang * ijinjia * iyongjinlv / 1000;
            //佣金金额有最低5元限制
            if (iyongjinej <= 5)
            {
                iyongjinej = 5;
            }
            //佣金金额=购进佣金额+卖出佣金额
            iyongjine = iyongjinej + iyongjines;
            //保留3位小数
            iyongjine = Math.Round(iyongjine, 3);
            //利润率：股票数量*（售价-进价）- 印花税额 - 佣金金额
            ilirun = (ishuliang * (ishoujia - ijinjia) - iyinhuae - iyongjine);
            //保留3位小数
            ilirun = Math.Round(ilirun, 3);
            //数字转换成字符串，输出
            string slirun = ilirun.ToString();
            string syinhuae = iyinhuae.ToString();
            string syongjine = iyongjine.ToString();
            LiRun.Text = slirun;
            YongJine.Text = syongjine;
            YinHuae.Text = syinhuae;

        }

        private void JinJia_TextChanged(object sender, EventArgs e)
        {
            //判断是否为空，为空就置1
            if (string.IsNullOrEmpty(JinJia.Text))
            {
                JinJia.Text = "1";
            }
            //定义类型
            double iyinhuae, iyongjine, iyongjines, iyongjinej, ilirun;
            double ishuliang = double.Parse(ShuLiang.Text);
            double ijinjia = double.Parse(JinJia.Text);
            double ishoujia = double.Parse(ShouJia.Text);
            double iyinhualv = double.Parse(YinHuaLv.Text);
            double iyongjinlv = double.Parse(YongJinLv.Text);
            //计算印花税额：股票数量*售价*税率
            iyinhuae = ishuliang * ishoujia * iyinhualv / 1000;
            iyinhuae = Math.Round(iyinhuae, 3);
            //股票卖出时佣金金额：股票数量*售价*佣金率
            iyongjines = ishuliang * ishoujia * iyongjinlv / 1000;
            //佣金金额有最低5元限制
            if (iyongjines <= 5)
            {
                iyongjines = 5;
            }
            //股票购买时佣金金额：股票数量*进价*佣金率
            iyongjinej = ishuliang * ijinjia * iyongjinlv / 1000;
            //佣金金额有最低5元限制
            if (iyongjinej <= 5)
            {
                iyongjinej = 5;
            }
            //佣金金额=购进佣金额+卖出佣金额
            iyongjine = iyongjinej + iyongjines;
            //保留3位小数
            iyongjine = Math.Round(iyongjine, 3);
            //利润率：股票数量*（售价-进价）- 印花税额 - 佣金金额
            ilirun = (ishuliang * (ishoujia - ijinjia) - iyinhuae - iyongjine);
            //保留3位小数
            ilirun = Math.Round(ilirun, 3);
            //数字转换成字符串，输出
            string slirun = ilirun.ToString();
            string syinhuae = iyinhuae.ToString();
            string syongjine = iyongjine.ToString();
            LiRun.Text = slirun;
            YongJine.Text = syongjine;
            YinHuae.Text = syinhuae;
        }

        private void YinHuaLv_TextChanged(object sender, EventArgs e)
        {
            //判断是否为空，为空就置1
            if (string.IsNullOrEmpty(YinHuaLv.Text))
            {
                YinHuaLv.Text = "1";
            }
            //定义类型
            double iyinhuae, iyongjine, iyongjines, iyongjinej, ilirun;
            double ishuliang = double.Parse(ShuLiang.Text);
            double ijinjia = double.Parse(JinJia.Text);
            double ishoujia = double.Parse(ShouJia.Text);
            double iyinhualv = double.Parse(YinHuaLv.Text);
            double iyongjinlv = double.Parse(YongJinLv.Text);
            //计算印花税额：股票数量*售价*税率
            iyinhuae = ishuliang * ishoujia * iyinhualv / 1000;
            iyinhuae = Math.Round(iyinhuae, 3);
            //股票卖出时佣金金额：股票数量*售价*佣金率
            iyongjines = ishuliang * ishoujia * iyongjinlv / 1000;
            //佣金金额有最低5元限制
            if (iyongjines <= 5)
            {
                iyongjines = 5;
            }
            //股票购买时佣金金额：股票数量*进价*佣金率
            iyongjinej = ishuliang * ijinjia * iyongjinlv / 1000;
            //佣金金额有最低5元限制
            if (iyongjinej <= 5)
            {
                iyongjinej = 5;
            }
            //佣金金额=购进佣金额+卖出佣金额
            iyongjine = iyongjinej + iyongjines;
            //保留3位小数
            iyongjine = Math.Round(iyongjine, 3);
            //利润率：股票数量*（售价-进价）- 印花税额 - 佣金金额
            ilirun = (ishuliang * (ishoujia - ijinjia) - iyinhuae - iyongjine);
            //保留3位小数
            ilirun = Math.Round(ilirun, 3);
            //数字转换成字符串，输出
            string slirun = ilirun.ToString();
            string syinhuae = iyinhuae.ToString();
            string syongjine = iyongjine.ToString();
            LiRun.Text = slirun;
            YongJine.Text = syongjine;
            YinHuae.Text = syinhuae;
        }

        private void YongJinLv_TextChanged(object sender, EventArgs e)
        {
            //判断是否为空，为空就置1
            if (string.IsNullOrEmpty(YongJinLv.Text))
            {
                YongJinLv.Text = "1";
            }
            //定义类型
            double iyinhuae, iyongjine, iyongjines, iyongjinej, ilirun;
            double ishuliang = double.Parse(ShuLiang.Text);
            double ijinjia = double.Parse(JinJia.Text);
            double ishoujia = double.Parse(ShouJia.Text);
            double iyinhualv = double.Parse(YinHuaLv.Text);
            double iyongjinlv = double.Parse(YongJinLv.Text);
            //计算印花税额：股票数量*售价*税率
            iyinhuae = ishuliang * ishoujia * iyinhualv / 1000;
            iyinhuae = Math.Round(iyinhuae, 3);
            //股票卖出时佣金金额：股票数量*售价*佣金率
            iyongjines = ishuliang * ishoujia * iyongjinlv / 1000;
            //佣金金额有最低5元限制
            if (iyongjines <= 5)
            {
                iyongjines = 5;
            }
            //股票购买时佣金金额：股票数量*进价*佣金率
            iyongjinej = ishuliang * ijinjia * iyongjinlv / 1000;
            //佣金金额有最低5元限制
            if (iyongjinej <= 5)
            {
                iyongjinej = 5;
            }
            //佣金金额=购进佣金额+卖出佣金额
            iyongjine = iyongjinej + iyongjines;
            //保留3位小数
            iyongjine = Math.Round(iyongjine, 3);
            //利润率：股票数量*（售价-进价）- 印花税额 - 佣金金额
            ilirun = (ishuliang * (ishoujia - ijinjia) - iyinhuae - iyongjine);
            //保留3位小数
            ilirun = Math.Round(ilirun, 3);
            //数字转换成字符串，输出
            string slirun = ilirun.ToString();
            string syinhuae = iyinhuae.ToString();
            string syongjine = iyongjine.ToString();
            LiRun.Text = slirun;
            YongJine.Text = syongjine;
            YinHuae.Text = syinhuae;
        }

        private void YongJine_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //打开小枫客栈
            string url = "http://www.xiaofeng.org";
            Process.Start(url);
        }

        private void LiRun_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
