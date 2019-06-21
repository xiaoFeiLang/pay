namespace CardRecharge
{
    partial class Form_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPsw = new System.Windows.Forms.TextBox();
            this.tbEmpid = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "工号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // tbPsw
            // 
            this.tbPsw.Location = new System.Drawing.Point(215, 116);
            this.tbPsw.Name = "tbPsw";
            this.tbPsw.Size = new System.Drawing.Size(100, 21);
            this.tbPsw.TabIndex = 2;
            // 
            // tbEmpid
            // 
            this.tbEmpid.Location = new System.Drawing.Point(215, 73);
            this.tbEmpid.Name = "tbEmpid";
            this.tbEmpid.Size = new System.Drawing.Size(100, 21);
            this.tbEmpid.TabIndex = 3;
            // 
            // Login
            // 
            this.Login.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Login.Location = new System.Drawing.Point(215, 163);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 4;
            this.Login.Text = "登录";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 295);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.tbEmpid);
            this.Controls.Add(this.tbPsw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Login";
            this.Text = "Form_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPsw;
        private System.Windows.Forms.TextBox tbEmpid;
        private System.Windows.Forms.Button Login;
    }
}