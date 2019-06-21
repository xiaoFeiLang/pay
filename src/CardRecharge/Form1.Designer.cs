namespace CardRecharge
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
            this.WIDout_request_no = new System.Windows.Forms.TextBox();
            this.WIDtotal_fee = new System.Windows.Forms.TextBox();
            this.WIDsubject = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbWorkid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TbEmpName = new System.Windows.Forms.Label();
            this.TbDeptName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.lblBt = new System.Windows.Forms.Label();
            this.lblCz = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.餐卡充值ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemChangePwd = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WIDout_request_no
            // 
            this.WIDout_request_no.Enabled = false;
            this.WIDout_request_no.Location = new System.Drawing.Point(185, 137);
            this.WIDout_request_no.Name = "WIDout_request_no";
            this.WIDout_request_no.Size = new System.Drawing.Size(165, 21);
            this.WIDout_request_no.TabIndex = 1;
            // 
            // WIDtotal_fee
            // 
            this.WIDtotal_fee.Location = new System.Drawing.Point(185, 217);
            this.WIDtotal_fee.Name = "WIDtotal_fee";
            this.WIDtotal_fee.Size = new System.Drawing.Size(165, 21);
            this.WIDtotal_fee.TabIndex = 2;
            this.WIDtotal_fee.Text = "0.2";
            // 
            // WIDsubject
            // 
            this.WIDsubject.Enabled = false;
            this.WIDsubject.Location = new System.Drawing.Point(185, 179);
            this.WIDsubject.Name = "WIDsubject";
            this.WIDsubject.Size = new System.Drawing.Size(165, 21);
            this.WIDsubject.TabIndex = 3;
            this.WIDsubject.Text = "餐卡充值";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(185, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 165);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "订单号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "充值类型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "支付码";
            // 
            // TbWorkid
            // 
            this.TbWorkid.Enabled = false;
            this.TbWorkid.Location = new System.Drawing.Point(185, 96);
            this.TbWorkid.Name = "TbWorkid";
            this.TbWorkid.Size = new System.Drawing.Size(165, 21);
            this.TbWorkid.TabIndex = 6;
            this.TbWorkid.Text = "0062815";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "工号";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 61);
            this.button2.TabIndex = 0;
            this.button2.Text = "生成支付码";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "充值金额";
            // 
            // TbEmpName
            // 
            this.TbEmpName.AutoSize = true;
            this.TbEmpName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TbEmpName.Location = new System.Drawing.Point(382, 98);
            this.TbEmpName.Name = "TbEmpName";
            this.TbEmpName.Size = new System.Drawing.Size(0, 19);
            this.TbEmpName.TabIndex = 7;
            // 
            // TbDeptName
            // 
            this.TbDeptName.AutoSize = true;
            this.TbDeptName.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TbDeptName.Location = new System.Drawing.Point(382, 143);
            this.TbDeptName.Name = "TbDeptName";
            this.TbDeptName.Size = new System.Drawing.Size(0, 18);
            this.TbDeptName.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(359, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "餐卡充值";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRemark.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblRemark.Location = new System.Drawing.Point(372, 257);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(55, 15);
            this.lblRemark.TabIndex = 10;
            this.lblRemark.Text = "label7";
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSuccess.ForeColor = System.Drawing.Color.Lime;
            this.lblSuccess.Location = new System.Drawing.Point(183, 281);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(0, 24);
            this.lblSuccess.TabIndex = 11;
            // 
            // lblBt
            // 
            this.lblBt.AutoSize = true;
            this.lblBt.Location = new System.Drawing.Point(183, 318);
            this.lblBt.Name = "lblBt";
            this.lblBt.Size = new System.Drawing.Size(0, 12);
            this.lblBt.TabIndex = 11;
            // 
            // lblCz
            // 
            this.lblCz.AutoSize = true;
            this.lblCz.Location = new System.Drawing.Point(183, 351);
            this.lblCz.Name = "lblCz";
            this.lblCz.Size = new System.Drawing.Size(0, 12);
            this.lblCz.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.餐卡充值ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(876, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 餐卡充值ToolStripMenuItem
            // 
            this.餐卡充值ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemQuery,
            this.ItemChangePwd});
            this.餐卡充值ToolStripMenuItem.Name = "餐卡充值ToolStripMenuItem";
            this.餐卡充值ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.餐卡充值ToolStripMenuItem.Text = "系统";
            // 
            // ItemQuery
            // 
            this.ItemQuery.Name = "ItemQuery";
            this.ItemQuery.Size = new System.Drawing.Size(118, 22);
            this.ItemQuery.Text = "充值记录";
            this.ItemQuery.Click += new System.EventHandler(this.ItemQuery_Click);
            // 
            // ItemChangePwd
            // 
            this.ItemChangePwd.Name = "ItemChangePwd";
            this.ItemChangePwd.Size = new System.Drawing.Size(118, 22);
            this.ItemChangePwd.Text = "修改密码";
            this.ItemChangePwd.Click += new System.EventHandler(this.ItemChangePwd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.lblCz);
            this.Controls.Add(this.lblBt);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TbDeptName);
            this.Controls.Add(this.TbEmpName);
            this.Controls.Add(this.TbWorkid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.WIDsubject);
            this.Controls.Add(this.WIDtotal_fee);
            this.Controls.Add(this.WIDout_request_no);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "一卡通系统";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox WIDout_request_no;
        private System.Windows.Forms.TextBox WIDtotal_fee;
        private System.Windows.Forms.TextBox WIDsubject;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbWorkid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TbEmpName;
        private System.Windows.Forms.Label TbDeptName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Label lblBt;
        private System.Windows.Forms.Label lblCz;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 餐卡充值ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ItemQuery;
        private System.Windows.Forms.ToolStripMenuItem ItemChangePwd;
    }
}

