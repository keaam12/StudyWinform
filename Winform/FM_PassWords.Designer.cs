
namespace Winform
{
    partial class FM_PassWords
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
            this.BtnChange = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.UserID = new System.Windows.Forms.Label();
            this.PastPW = new System.Windows.Forms.Label();
            this.ChangePW = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtpPW = new System.Windows.Forms.TextBox();
            this.txtcPW = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnChange
            // 
            this.BtnChange.Location = new System.Drawing.Point(443, 272);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(94, 29);
            this.BtnChange.TabIndex = 0;
            this.BtnChange.Text = "변경 등록";
            this.BtnChange.UseVisualStyleBackColor = true;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(587, 272);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(94, 29);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "닫기";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Location = new System.Drawing.Point(169, 84);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(74, 20);
            this.UserID.TabIndex = 2;
            this.UserID.Text = "사용자 ID";
            // 
            // PastPW
            // 
            this.PastPW.AutoSize = true;
            this.PastPW.Location = new System.Drawing.Point(169, 142);
            this.PastPW.Name = "PastPW";
            this.PastPW.Size = new System.Drawing.Size(67, 20);
            this.PastPW.TabIndex = 3;
            this.PastPW.Text = "이전 PW";
            // 
            // ChangePW
            // 
            this.ChangePW.AutoSize = true;
            this.ChangePW.Location = new System.Drawing.Point(169, 204);
            this.ChangePW.Name = "ChangePW";
            this.ChangePW.Size = new System.Drawing.Size(67, 20);
            this.ChangePW.TabIndex = 4;
            this.ChangePW.Text = "변경 PW";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(252, 84);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(285, 27);
            this.txtUserID.TabIndex = 5;
            // 
            // txtpPW
            // 
            this.txtpPW.Location = new System.Drawing.Point(252, 139);
            this.txtpPW.Name = "txtpPW";
            this.txtpPW.Size = new System.Drawing.Size(285, 27);
            this.txtpPW.TabIndex = 6;
            // 
            // txtcPW
            // 
            this.txtcPW.Location = new System.Drawing.Point(252, 204);
            this.txtcPW.Name = "txtcPW";
            this.txtcPW.Size = new System.Drawing.Size(285, 27);
            this.txtcPW.TabIndex = 7;
            // 
            // FM_PassWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcPW);
            this.Controls.Add(this.txtpPW);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.ChangePW);
            this.Controls.Add(this.PastPW);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnChange);
            this.Name = "FM_PassWords";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Label PastPW;
        private System.Windows.Forms.Label ChangePW;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtpPW;
        private System.Windows.Forms.TextBox txtcPW;
    }
}