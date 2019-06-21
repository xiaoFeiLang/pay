namespace CardRecharge
{
    partial class Form_ChangePwd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_OldPsw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Submmit = new System.Windows.Forms.Button();
            this.tb_Newpsw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_NewPswCofirm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_OldPsw
            // 
            this.tb_OldPsw.Location = new System.Drawing.Point(165, 55);
            this.tb_OldPsw.Name = "tb_OldPsw";
            this.tb_OldPsw.Size = new System.Drawing.Size(100, 21);
            this.tb_OldPsw.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "原密码";
            // 
            // Submmit
            // 
            this.Submmit.Location = new System.Drawing.Point(190, 157);
            this.Submmit.Name = "Submmit";
            this.Submmit.Size = new System.Drawing.Size(75, 23);
            this.Submmit.TabIndex = 2;
            this.Submmit.Text = "提交";
            this.Submmit.UseVisualStyleBackColor = true;
            this.Submmit.Click += new System.EventHandler(this.Submmit_Click);
            // 
            // tb_Newpsw
            // 
            this.tb_Newpsw.Location = new System.Drawing.Point(165, 87);
            this.tb_Newpsw.Name = "tb_Newpsw";
            this.tb_Newpsw.Size = new System.Drawing.Size(100, 21);
            this.tb_Newpsw.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码";
            // 
            // tb_NewPswCofirm
            // 
            this.tb_NewPswCofirm.Location = new System.Drawing.Point(165, 120);
            this.tb_NewPswCofirm.Name = "tb_NewPswCofirm";
            this.tb_NewPswCofirm.Size = new System.Drawing.Size(100, 21);
            this.tb_NewPswCofirm.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "确认密码";
            // 
            // Form_ChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 235);
            this.Controls.Add(this.Submmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_NewPswCofirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Newpsw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_OldPsw);
            this.Name = "Form_ChangePwd";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_OldPsw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Submmit;
        private System.Windows.Forms.TextBox tb_Newpsw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_NewPswCofirm;
        private System.Windows.Forms.Label label3;
    }
}