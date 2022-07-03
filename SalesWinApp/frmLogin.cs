using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
            string Password = txtPassword.Text;          
            if(Email.Trim().Equals("") || Password.Trim().Equals(""))
            {
                MessageBox.Show("Email and Password can't be empty", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var loginMember = memberRepository.CheckLogin(Email, Password);
                if (loginMember == null)
                {
                    MessageBox.Show("Invalid Email or Password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if ("admin@fstore.com".Equals(loginMember.Email))
                    {
                        frmMain frmMain = new frmMain
                        {
                            loginMember = loginMember
                        };
                        frmMain.Closed += (s, args) => this.Show();
                        this.Hide();
                        frmMain.ShowDialog();
                    }
                    else
                    {
                        frmMemberInfo frmMemberInfo = new frmMemberInfo
                        {
                            Text = "Member Info",
                            MemberInfo = loginMember,
                            InsertOrUpdate = true,
                            MemberRepository = memberRepository
                        };
                        frmMemberInfo.Closed += (s, args) => this.Show();
                        this.Hide();
                        frmMemberInfo.ShowDialog();
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();
    }
}
