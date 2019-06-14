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
            this.QueryUserInfo = new System.Windows.Forms.Button();
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.lblBt = new System.Windows.Forms.Label();
            this.lblCz = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // QueryUserInfo
            // 
            this.QueryUserInfo.Location = new System.Drawing.Point(316, 83);
            this.QueryUserInfo.Name = "QueryUserInfo";
            this.QueryUserInfo.Size = new System.Drawing.Size(100, 36);
            this.QueryUserInfo.TabIndex = 0;
            this.QueryUserInfo.Text = "查询个人信息";
            this.QueryUserInfo.UseVisualStyleBackColor = true;
            this.QueryUserInfo.Click += new System.EventHandler(this.QueryUserInfo_Click);
            // 
            // WIDout_request_no
            // 
            this.WIDout_request_no.Location = new System.Drawing.Point(185, 124);
            this.WIDout_request_no.Name = "WIDout_request_no";
            this.WIDout_request_no.Size = new System.Drawing.Size(100, 21);
            this.WIDout_request_no.TabIndex = 1;
            // 
            // WIDtotal_fee
            // 
            this.WIDtotal_fee.Location = new System.Drawing.Point(185, 204);
            this.WIDtotal_fee.Name = "WIDtotal_fee";
            this.WIDtotal_fee.Size = new System.Drawing.Size(100, 21);
            this.WIDtotal_fee.TabIndex = 2;
            this.WIDtotal_fee.Text = "0.2";
            // 
            // WIDsubject
            // 
            this.WIDsubject.Location = new System.Drawing.Point(185, 166);
            this.WIDsubject.Name = "WIDsubject";
            this.WIDsubject.Size = new System.Drawing.Size(100, 21);
            this.WIDsubject.TabIndex = 3;
            this.WIDsubject.Text = "餐卡充值";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(185, 244);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 165);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "订单号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "充值类型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "支付码";
            // 
            // TbWorkid
            // 
            this.TbWorkid.Location = new System.Drawing.Point(185, 83);
            this.TbWorkid.Name = "TbWorkid";
            this.TbWorkid.Size = new System.Drawing.Size(100, 21);
            this.TbWorkid.TabIndex = 6;
            this.TbWorkid.Text = "0062815";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "工号";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 34);
            this.button2.TabIndex = 0;
            this.button2.Text = "生成支付码";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "充值金额";
            // 
            // TbEmpName
            // 
            this.TbEmpName.AutoSize = true;
            this.TbEmpName.Location = new System.Drawing.Point(494, 149);
            this.TbEmpName.Name = "TbEmpName";
            this.TbEmpName.Size = new System.Drawing.Size(0, 12);
            this.TbEmpName.TabIndex = 7;
            // 
            // TbDeptName
            // 
            this.TbDeptName.AutoSize = true;
            this.TbDeptName.Location = new System.Drawing.Point(494, 193);
            this.TbDeptName.Name = "TbDeptName";
            this.TbDeptName.Size = new System.Drawing.Size(0, 12);
            this.TbDeptName.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(237, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "餐卡充值系统";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "查询充值记录";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(494, 86);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(41, 12);
            this.lblRemark.TabIndex = 10;
            this.lblRemark.Text = "label7";
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSuccess.ForeColor = System.Drawing.Color.Lime;
            this.lblSuccess.Location = new System.Drawing.Point(183, 268);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(0, 24);
            this.lblSuccess.TabIndex = 11;
            // 
            // lblBt
            // 
            this.lblBt.AutoSize = true;
            this.lblBt.Location = new System.Drawing.Point(183, 305);
            this.lblBt.Name = "lblBt";
            this.lblBt.Size = new System.Drawing.Size(0, 12);
            this.lblBt.TabIndex = 11;
            // 
            // lblCz
            // 
            this.lblCz.AutoSize = true;
            this.lblCz.Location = new System.Drawing.Point(183, 338);
            this.lblCz.Name = "lblCz";
            this.lblCz.Size = new System.Drawing.Size(0, 12);
            this.lblCz.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.lblCz);
            this.Controls.Add(this.lblBt);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.QueryUserInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button QueryUserInfo;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Label lblBt;
        private System.Windows.Forms.Label lblCz;
    }
}

