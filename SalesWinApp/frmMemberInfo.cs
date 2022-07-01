using DataAccess.Models;
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
    public partial class frmMemberInfo : Form
    {
        public frmMemberInfo()
        {
            InitializeComponent();
        }

        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; } //False : Insert, True : Update
        public Member MemberInfo { get; set; }

        private void frmMemberInfo_Load(object sender, EventArgs e)
        {
            txtMemberId.Enabled = false;
            if (InsertOrUpdate)
            {
                txtMemberId.Text = MemberInfo.MemberId.ToString();
                txtEmail.Text = MemberInfo.Email;
                txtCity.Text = MemberInfo.CompanyName;
                txtCity.Text = MemberInfo.City;
                txtCountry.Text = MemberInfo.Country;
                txtPassword.Text = MemberInfo.Password;
            } else
            {
                btnSave.Text = "Create";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool flag = true;
            try
            {
                if (InsertOrUpdate)
                {
                    var member_update = new Member()
                    {
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
    }
}
