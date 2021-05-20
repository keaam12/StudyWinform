
using System;

namespace Winform
{
    partial class FM_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnLogin = new System.Windows.Forms.Button();
            this.UserID = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.UserPW = new System.Windows.Forms.Label();
            this.txtUserPW = new System.Windows.Forms.TextBox();
            this.BtnPW = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(573, 200);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(94, 29);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "로그인";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Location = new System.Drawing.Point(227, 77);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(74, 20);
            this.UserID.TabIndex = 1;
            this.UserID.Text = "사용자 ID";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(307, 74);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(225, 27);
            this.txtUserID.TabIndex = 2;
            // 
            // UserPW
            // 
            this.UserPW.AutoSize = true;
            this.UserPW.Location = new System.Drawing.Point(219, 129);
            this.UserPW.Name = "UserPW";
            this.UserPW.Size = new System.Drawing.Size(82, 20);
            this.UserPW.TabIndex = 1;
            this.UserPW.Text = "사용자 PW";
            // 
            // txtUserPW
            // 
            this.txtUserPW.Location = new System.Drawing.Point(307, 126);
            this.txtUserPW.Name = "txtUserPW";
            this.txtUserPW.Size = new System.Drawing.Size(225, 27);
            this.txtUserPW.TabIndex = 2;
            // 
            // BtnPW
            // 
            this.BtnPW.Location = new System.Drawing.Point(400, 200);
            this.BtnPW.Name = "BtnPW";
            this.BtnPW.Size = new System.Drawing.Size(148, 29);
            this.BtnPW.TabIndex = 0;
            this.BtnPW.Text = "비밀번호변경";
            this.BtnPW.UseVisualStyleBackColor = true;
            this.BtnPW.Click += new System.EventHandler(this.BtnPW_Click);
            // 
            // FM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUserPW);
            this.Controls.Add(this.UserPW);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.BtnPW);
            this.Controls.Add(this.BtnLogin);
            this.Name = "FM_Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label UserPW;
        private System.Windows.Forms.TextBox txtUserPW;
        private System.Windows.Forms.Button BtnPW;
    }
}

