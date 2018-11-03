namespace ZUOT
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.ShuLiang = new System.Windows.Forms.TextBox();
            this.JinJia = new System.Windows.Forms.TextBox();
            this.ShouJia = new System.Windows.Forms.TextBox();
            this.YinHuaLv = new System.Windows.Forms.TextBox();
            this.YongJinLv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.YinHuae = new System.Windows.Forms.TextBox();
            this.YongJine = new System.Windows.Forms.TextBox();
            this.LiRun = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重置SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShuLiang
            // 
            this.ShuLiang.Location = new System.Drawing.Point(89, 5);
            this.ShuLiang.Name = "ShuLiang";
            this.ShuLiang.Size = new System.Drawing.Size(68, 21);
            this.ShuLiang.TabIndex = 2;
            this.ShuLiang.Text = "10000";
            this.ShuLiang.TextChanged += new System.EventHandler(this.ShuLiang_TextChanged);
            this.ShuLiang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShuLiang_KeyPress);
            // 
            // JinJia
            // 
            this.JinJia.Location = new System.Drawing.Point(89, 32);
            this.JinJia.Name = "JinJia";
            this.JinJia.Size = new System.Drawing.Size(68, 21);
            this.JinJia.TabIndex = 3;
            this.JinJia.Text = "8.97";
            this.JinJia.TextChanged += new System.EventHandler(this.JinJia_TextChanged);
            this.JinJia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JinJia_KeyPress);
            // 
            // ShouJia
            // 
            this.ShouJia.Location = new System.Drawing.Point(89, 59);
            this.ShouJia.Name = "ShouJia";
            this.ShouJia.Size = new System.Drawing.Size(68, 21);
            this.ShouJia.TabIndex = 4;
            this.ShouJia.Text = "12.34";
            this.ShouJia.TextChanged += new System.EventHandler(this.ShouJia_TextChanged);
            this.ShouJia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShouJia_KeyPress);
            // 
            // YinHuaLv
            // 
            this.YinHuaLv.Location = new System.Drawing.Point(89, 86);
            this.YinHuaLv.MaxLength = 4;
            this.YinHuaLv.Name = "YinHuaLv";
            this.YinHuaLv.Size = new System.Drawing.Size(68, 21);
            this.YinHuaLv.TabIndex = 5;
            this.YinHuaLv.Text = "1";
            this.YinHuaLv.TextChanged += new System.EventHandler(this.YinHuaLv_TextChanged);
            this.YinHuaLv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YinHuaLv_KeyPress);
            // 
            // YongJinLv
            // 
            this.YongJinLv.Location = new System.Drawing.Point(89, 113);
            this.YongJinLv.MaxLength = 4;
            this.YongJinLv.Name = "YongJinLv";
            this.YongJinLv.Size = new System.Drawing.Size(68, 21);
            this.YongJinLv.TabIndex = 6;
            this.YongJinLv.Text = "0.3";
            this.YongJinLv.TextChanged += new System.EventHandler(this.YongJinLv_TextChanged);
            this.YongJinLv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YongJinLv_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "交易数量(股):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(5, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "买入价格(元);";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(5, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "卖出价格(元):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(5, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "印花税率(‰);";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(5, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "佣金税率(‰):";
            // 
            // YinHuae
            // 
            this.YinHuae.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.YinHuae.Location = new System.Drawing.Point(89, 140);
            this.YinHuae.Name = "YinHuae";
            this.YinHuae.Size = new System.Drawing.Size(68, 21);
            this.YinHuae.TabIndex = 12;
            this.YinHuae.Text = "123.4";
            this.YinHuae.TextChanged += new System.EventHandler(this.YinHuae_TextChanged);
            this.YinHuae.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YinHuae_KeyPress);
            // 
            // YongJine
            // 
            this.YongJine.Location = new System.Drawing.Point(89, 167);
            this.YongJine.Name = "YongJine";
            this.YongJine.Size = new System.Drawing.Size(68, 21);
            this.YongJine.TabIndex = 13;
            this.YongJine.Text = "63.93";
            this.YongJine.TextChanged += new System.EventHandler(this.YongJine_TextChanged);
            this.YongJine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YongJine_KeyPress);
            // 
            // LiRun
            // 
            this.LiRun.Location = new System.Drawing.Point(89, 194);
            this.LiRun.Name = "LiRun";
            this.LiRun.Size = new System.Drawing.Size(68, 21);
            this.LiRun.TabIndex = 14;
            this.LiRun.Text = "33512.67";
            this.LiRun.TextChanged += new System.EventHandler(this.LiRun_TextChanged);
            this.LiRun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LiRun_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(5, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "印花税额(元):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(5, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "佣金税额(元):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(5, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "本次利润(元):";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.计算ToolStripMenuItem,
            this.重置SToolStripMenuItem,
            this.退出AToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 92);
            // 
            // 计算ToolStripMenuItem
            // 
            this.计算ToolStripMenuItem.Name = "计算ToolStripMenuItem";
            this.计算ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.计算ToolStripMenuItem.Text = "计算(&J)";
            this.计算ToolStripMenuItem.Click += new System.EventHandler(this.计算ToolStripMenuItem_Click);
            // 
            // 重置SToolStripMenuItem
            // 
            this.重置SToolStripMenuItem.Name = "重置SToolStripMenuItem";
            this.重置SToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.重置SToolStripMenuItem.Text = "重置(&C)";
            this.重置SToolStripMenuItem.Click += new System.EventHandler(this.重置SToolStripMenuItem_Click);
            // 
            // 退出AToolStripMenuItem
            // 
            this.退出AToolStripMenuItem.Name = "退出AToolStripMenuItem";
            this.退出AToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.退出AToolStripMenuItem.Text = "退出(&E)";
            this.退出AToolStripMenuItem.Click += new System.EventHandler(this.关于AToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.关于ToolStripMenuItem.Text = "关于(&A)";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.小枫作品ToolStripMenuItem_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(10, 222);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(149, 12);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Tag = "";
            this.linkLabel1.Text = "股市有风险，入市需谨慎！";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 241);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LiRun);
            this.Controls.Add(this.YongJine);
            this.Controls.Add(this.YinHuae);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YongJinLv);
            this.Controls.Add(this.YinHuaLv);
            this.Controls.Add(this.ShouJia);
            this.Controls.Add(this.ShuLiang);
            this.Controls.Add(this.JinJia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T+0计算器-By:Pking 20170813";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ShuLiang;
        private System.Windows.Forms.TextBox JinJia;
        private System.Windows.Forms.TextBox ShouJia;
        private System.Windows.Forms.TextBox YinHuaLv;
        private System.Windows.Forms.TextBox YongJinLv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox YinHuae;
        private System.Windows.Forms.TextBox YongJine;
        private System.Windows.Forms.TextBox LiRun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 重置SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算ToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

