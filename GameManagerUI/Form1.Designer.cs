namespace GameManagerUI
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbllx = new System.Windows.Forms.Label();
            this.cmblx = new System.Windows.Forms.ComboBox();
            this.btnlxca = new System.Windows.Forms.Button();
            this.lblmc = new System.Windows.Forms.Label();
            this.txtmc = new System.Windows.Forms.TextBox();
            this.btnmc = new System.Windows.Forms.Button();
            this.dgvshow = new System.Windows.Forms.DataGridView();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pgs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblpid = new System.Windows.Forms.Label();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblyxlx = new System.Windows.Forms.Label();
            this.cmbyxlx = new System.Windows.Forms.ComboBox();
            this.lblgs = new System.Windows.Forms.Label();
            this.txtgs = new System.Windows.Forms.TextBox();
            this.lblqian = new System.Windows.Forms.Label();
            this.txtqian = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnxg = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsx = new System.Windows.Forms.Button();
            this.btnno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshow)).BeginInit();
            this.SuspendLayout();
            // 
            // lbllx
            // 
            this.lbllx.AutoSize = true;
            this.lbllx.Location = new System.Drawing.Point(27, 27);
            this.lbllx.Name = "lbllx";
            this.lbllx.Size = new System.Drawing.Size(53, 12);
            this.lbllx.TabIndex = 0;
            this.lbllx.Text = "游戏类型";
            // 
            // cmblx
            // 
            this.cmblx.FormattingEnabled = true;
            this.cmblx.Items.AddRange(new object[] {
            "网页游戏",
            "客户端游戏",
            "手机游戏"});
            this.cmblx.Location = new System.Drawing.Point(88, 18);
            this.cmblx.Name = "cmblx";
            this.cmblx.Size = new System.Drawing.Size(121, 20);
            this.cmblx.TabIndex = 1;
            // 
            // btnlxca
            // 
            this.btnlxca.Location = new System.Drawing.Point(230, 16);
            this.btnlxca.Name = "btnlxca";
            this.btnlxca.Size = new System.Drawing.Size(75, 23);
            this.btnlxca.TabIndex = 2;
            this.btnlxca.Text = "查询";
            this.btnlxca.UseVisualStyleBackColor = true;
            this.btnlxca.Click += new System.EventHandler(this.btnlxca_Click);
            // 
            // lblmc
            // 
            this.lblmc.AutoSize = true;
            this.lblmc.Location = new System.Drawing.Point(337, 25);
            this.lblmc.Name = "lblmc";
            this.lblmc.Size = new System.Drawing.Size(53, 12);
            this.lblmc.TabIndex = 3;
            this.lblmc.Text = "游戏名称";
            // 
            // txtmc
            // 
            this.txtmc.Location = new System.Drawing.Point(397, 16);
            this.txtmc.Name = "txtmc";
            this.txtmc.Size = new System.Drawing.Size(100, 21);
            this.txtmc.TabIndex = 4;
            // 
            // btnmc
            // 
            this.btnmc.Location = new System.Drawing.Point(526, 15);
            this.btnmc.Name = "btnmc";
            this.btnmc.Size = new System.Drawing.Size(75, 23);
            this.btnmc.TabIndex = 5;
            this.btnmc.Text = "查询";
            this.btnmc.UseVisualStyleBackColor = true;
            this.btnmc.Click += new System.EventHandler(this.btnmc_Click);
            // 
            // dgvshow
            // 
            this.dgvshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvshow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pid,
            this.pname,
            this.gname,
            this.pgs,
            this.pje});
            this.dgvshow.Location = new System.Drawing.Point(29, 57);
            this.dgvshow.Name = "dgvshow";
            this.dgvshow.RowTemplate.Height = 23;
            this.dgvshow.Size = new System.Drawing.Size(572, 150);
            this.dgvshow.TabIndex = 6;
            this.dgvshow.Click += new System.EventHandler(this.dgvshow_Click);
            // 
            // pid
            // 
            this.pid.DataPropertyName = "pid";
            this.pid.HeaderText = "卡号";
            this.pid.Name = "pid";
            // 
            // pname
            // 
            this.pname.DataPropertyName = "pname";
            this.pname.HeaderText = "游戏名称";
            this.pname.Name = "pname";
            // 
            // gname
            // 
            this.gname.DataPropertyName = "gname";
            this.gname.HeaderText = "游戏类型";
            this.gname.Name = "gname";
            // 
            // pgs
            // 
            this.pgs.DataPropertyName = "pgs";
            this.pgs.HeaderText = "游戏公司";
            this.pgs.Name = "pgs";
            // 
            // pje
            // 
            this.pje.DataPropertyName = "pje";
            this.pje.HeaderText = "充值金额";
            this.pje.Name = "pje";
            // 
            // lblpid
            // 
            this.lblpid.AutoSize = true;
            this.lblpid.Location = new System.Drawing.Point(29, 248);
            this.lblpid.Name = "lblpid";
            this.lblpid.Size = new System.Drawing.Size(41, 12);
            this.lblpid.TabIndex = 7;
            this.lblpid.Text = "卡号：";
            // 
            // txtpid
            // 
            this.txtpid.Location = new System.Drawing.Point(109, 245);
            this.txtpid.Name = "txtpid";
            this.txtpid.ReadOnly = true;
            this.txtpid.Size = new System.Drawing.Size(100, 21);
            this.txtpid.TabIndex = 8;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(309, 248);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(65, 12);
            this.lblname.TabIndex = 9;
            this.lblname.Text = "游戏名称：";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(397, 239);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 21);
            this.txtname.TabIndex = 10;
            // 
            // lblyxlx
            // 
            this.lblyxlx.AutoSize = true;
            this.lblyxlx.Location = new System.Drawing.Point(29, 300);
            this.lblyxlx.Name = "lblyxlx";
            this.lblyxlx.Size = new System.Drawing.Size(59, 12);
            this.lblyxlx.TabIndex = 11;
            this.lblyxlx.Text = "游戏类型:";
            // 
            // cmbyxlx
            // 
            this.cmbyxlx.FormattingEnabled = true;
            this.cmbyxlx.Items.AddRange(new object[] {
            "网页游戏",
            "客户端游戏",
            "手机游戏"});
            this.cmbyxlx.Location = new System.Drawing.Point(109, 291);
            this.cmbyxlx.Name = "cmbyxlx";
            this.cmbyxlx.Size = new System.Drawing.Size(100, 20);
            this.cmbyxlx.TabIndex = 12;
            // 
            // lblgs
            // 
            this.lblgs.AutoSize = true;
            this.lblgs.Location = new System.Drawing.Point(311, 300);
            this.lblgs.Name = "lblgs";
            this.lblgs.Size = new System.Drawing.Size(59, 12);
            this.lblgs.TabIndex = 13;
            this.lblgs.Text = "游戏公司:";
            // 
            // txtgs
            // 
            this.txtgs.Location = new System.Drawing.Point(397, 300);
            this.txtgs.Name = "txtgs";
            this.txtgs.Size = new System.Drawing.Size(100, 21);
            this.txtgs.TabIndex = 14;
            // 
            // lblqian
            // 
            this.lblqian.AutoSize = true;
            this.lblqian.Location = new System.Drawing.Point(31, 337);
            this.lblqian.Name = "lblqian";
            this.lblqian.Size = new System.Drawing.Size(53, 12);
            this.lblqian.TabIndex = 15;
            this.lblqian.Text = "充值金额";
            // 
            // txtqian
            // 
            this.txtqian.Location = new System.Drawing.Point(109, 327);
            this.txtqian.Name = "txtqian";
            this.txtqian.Size = new System.Drawing.Size(100, 21);
            this.txtqian.TabIndex = 16;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(33, 376);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 17;
            this.btnadd.Text = "添加";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnxg
            // 
            this.btnxg.Location = new System.Drawing.Point(154, 375);
            this.btnxg.Name = "btnxg";
            this.btnxg.Size = new System.Drawing.Size(75, 23);
            this.btnxg.TabIndex = 18;
            this.btnxg.Text = "修改";
            this.btnxg.UseVisualStyleBackColor = true;
            this.btnxg.Click += new System.EventHandler(this.btnxg_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(276, 375);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 19;
            this.btndelete.Text = "删除";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsx
            // 
            this.btnsx.Location = new System.Drawing.Point(397, 375);
            this.btnsx.Name = "btnsx";
            this.btnsx.Size = new System.Drawing.Size(75, 23);
            this.btnsx.TabIndex = 20;
            this.btnsx.Text = "刷新";
            this.btnsx.UseVisualStyleBackColor = true;
            this.btnsx.Click += new System.EventHandler(this.btnsx_Click);
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(506, 375);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(75, 23);
            this.btnno.TabIndex = 21;
            this.btnno.Text = "退出";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 418);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnsx);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnxg);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtqian);
            this.Controls.Add(this.lblqian);
            this.Controls.Add(this.txtgs);
            this.Controls.Add(this.lblgs);
            this.Controls.Add(this.cmbyxlx);
            this.Controls.Add(this.lblyxlx);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtpid);
            this.Controls.Add(this.lblpid);
            this.Controls.Add(this.dgvshow);
            this.Controls.Add(this.btnmc);
            this.Controls.Add(this.txtmc);
            this.Controls.Add(this.lblmc);
            this.Controls.Add(this.btnlxca);
            this.Controls.Add(this.cmblx);
            this.Controls.Add(this.lbllx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvshow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllx;
        private System.Windows.Forms.ComboBox cmblx;
        private System.Windows.Forms.Button btnlxca;
        private System.Windows.Forms.Label lblmc;
        private System.Windows.Forms.TextBox txtmc;
        private System.Windows.Forms.Button btnmc;
        private System.Windows.Forms.DataGridView dgvshow;
        private System.Windows.Forms.Label lblpid;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblyxlx;
        private System.Windows.Forms.ComboBox cmbyxlx;
        private System.Windows.Forms.Label lblgs;
        private System.Windows.Forms.TextBox txtgs;
        private System.Windows.Forms.Label lblqian;
        private System.Windows.Forms.TextBox txtqian;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnxg;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsx;
        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pname;
        private System.Windows.Forms.DataGridViewTextBoxColumn gname;
        private System.Windows.Forms.DataGridViewTextBoxColumn pgs;
        private System.Windows.Forms.DataGridViewTextBoxColumn pje;
    }
}

