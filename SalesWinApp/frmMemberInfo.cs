using DataAccess.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMemberInfo : Form
    {
        public frmMemberInfo()
        {
            InitializeComponent();
        }

        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; } //False : Insert, True : Update
        public Member MemberInfo { get; set; }
        public Member LoginMember { get; set; }

        private void frmMemberInfo_Load(object sender, EventArgs e)
        {
            txtMemberId.Enabled = false;
            if (LoginMember.Email.Equals("admin@fstore.com"))
            {
                btnHistory.Enabled = false;
            }
            if (InsertOrUpdate)
            {
                txtMemberId.Text = MemberInfo.MemberId.ToString();
                txtEmail.Text = MemberInfo.Email;
                txtCompanyName.Text = MemberInfo.CompanyName;
                txtCity.Text = MemberInfo.City;
                txtCountry.Text = MemberInfo.Country;
                txtPassword.Text = MemberInfo.Password;
            }
            else
            {
                  btnSave.Text = "Create";
            }                    
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (txtCompanyName.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || txtCountry.Text == "" || txtCity.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            else if (!Regex.Match(txtCompanyName.Text, "^[a-zA-Z\\s]*$").Success)
            {
                MessageBox.Show("Invalid Company name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCompanyName.Focus();
                flag = false;
            }
            else if (!Regex.Match(txtEmail.Text, "^\\S+@\\S+\\.\\S+$").Success)
            {
                MessageBox.Show("Invalid email", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                flag = false;
            }
            else if (!Regex.Match(txtCity.Text, "^[a-zA-Z\\s]*$").Success)
            {
                MessageBox.Show("Invalid city", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCity.Focus();
                flag = false;
            }
            else if (!Regex.Match(txtCountry.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
            {
                MessageBox.Show("Invalid country", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCountry.Focus();
                flag = false;
            }
            try
            {
                if (InsertOrUpdate)
                {
                    var member_update = new Member()
                    {
                        MemberId = int.Parse(txtMemberId.Text),
                        Email = txtEmail.Text,
                        CompanyName = txtCompanyName.Text,
                        City = txtCity.Text,
                        Country = txtCountry.Text,
                        Password = txtPassword.Text
                    };
                    if (flag)
                    {
                        MemberRepository.UpdateMember(member_update);
                        MessageBox.Show("Update successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                } else
                {
                    var new_member = new Member()
                    {
                        Email=txtEmail.Text,
                        CompanyName=txtCompanyName.Text,
                        City=txtCity.Text,
                        Country=txtCountry.Text,
                        Password=txtPassword.Text
                    };
                    if (flag)
                    {
                        MemberRepository.InsertMember(new_member);
                        MessageBox.Show("Create successfully", "Message", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new member" : "Update a member");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void btnHistory_Click(object sender, EventArgs e)
        {
            frmHistory frmHistory = new frmHistory()
            {
                MemberId = MemberInfo.MemberId
            };
            frmHistory.ShowDialog();
        }
    }
}
