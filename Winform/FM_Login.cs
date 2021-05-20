using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class FM_Login : Form
    {
        public FM_Login()
        {
            InitializeComponent();
        }


        private void BtnPW_Click(object sender, EventArgs e)
        {
            this.Visible = false; // 로그인 화면을 보이지 않게 한다.
            // 비밀번호 변경 화면 판업으 호출한다.
            FM_PassWords FmPassword = new FM_PassWords();
            FmPassword.ShowDialog();
            this.Visible = true; // 로그인 화면을 보이게 한다.

        }


    }
}
