﻿using DataAccess.Models;
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
    public partial class frmMembers : Form
    {
        public Member loginMember { get; set; }
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        public frmMembers()
        {
            InitializeComponent();
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            LoadMemberList();
            dgvMemberList.CellDoubleClick += DgvMemberList_CellDoubleClick;
        }

        private void DgvMemberList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            frmMemberInfo frmMemberInfo = new frmMemberInfo
            {
                Text = "Update car",
                InsertOrUpdate = true,
                MemberInfo = GetMemberObject(),
                LoginMember = loginMember,
                MemberRepository = memberRepository
            };
            frmMemberInfo.ShowDialog();
            LoadMemberList();
            source.Position = source.Count - 1;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMemberInfo frmMemberInfo = new frmMemberInfo
            {
                Text = "Create member",
                InsertOrUpdate = false,
                LoginMember = loginMember, 
                MemberRepository = memberRepository
            };
            frmMemberInfo.ShowDialog();
            LoadMemberList();
            source.Position = source.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetMemberObject();
                memberRepository.DeleteMember(member);
                LoadMemberList();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete member");
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void ClearText()
        {
            txtMemberId.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private Member GetMemberObject()
        {
            Member member = null;
            try
            {
                member = new Member
                {
                    MemberId = Int32.Parse(txtMemberId.Text),
                    Email = txtEmail.Text,
                    CompanyName = txtCompanyName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Password = txtPassword.Text
                };
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member");
            }
            return member;
        }

        private void LoadMemberList()
        {
            var members = memberRepository.GetMemberList();
            try
            {
                source = new BindingSource();
                source.DataSource = members;

                txtMemberId.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtCompanyName.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtPassword.DataBindings.Clear();

                txtMemberId.DataBindings.Add("Text", source, "MemberId");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtPassword.DataBindings.Add("Text", source, "Password");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;

                if (members.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                } else
                {
                    btnDelete.Enabled = true;
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }
    }
}
