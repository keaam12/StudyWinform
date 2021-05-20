using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class FM_Login : Form
    {
        private SqlConnection Connect = null; // 데이터 베이스 접속 정보
        private SqlTransaction Tran; // 데이터 베이스 관리 권한
        private SqlCommand cmd = new SqlCommand(); // 데이터 베이스 명령 전달

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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string strCon = "Data Source=61.105.9.203;Initial Catalog=AppDev; User ID=kfqs;Password=1234";
            Connect = new SqlConnection(strCon);
            Connect.Open(); 
            if (Connect.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("데이터 베이스 연결에 실패하였습니다.");
                return;
            }
            
            string Loginid = string.Empty; 
            string sPassword = string.Empty;

            Loginid = txtUserID.Text;
            sPassword = txtUserPW.Text;

            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT PW FROM TB_USER_HGU WHERE USERID = '" + Loginid + "'", Connect);
            DataTable DtTemp = new DataTable();
            Adapter.Fill(DtTemp);
                if (DtTemp.Rows.Count == 0)
                {
                    MessageBox.Show("등록되지 않은 사용자 입니다");
                    return;
                }

                if (DtTemp.Rows[0]["PW"].ToString() == sPassword)
                {
                    MessageBox.Show("로그인에 성공하셨습니다.");
                    return;
                }
                else MessageBox.Show("비밀번호가 일치하지 않습니다.");
                return;
            }
        }
    }
}
