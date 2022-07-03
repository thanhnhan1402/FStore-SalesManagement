using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public IEnumerable<Member> GetMemberList() => MemberDAO.Instance.GetMemberList();
        public Member GetMemberByID(Member member) => MemberDAO.Instance.GetMemberByID(member);
        public void InsertMember(Member member) => MemberDAO.Instance.InsertMember(member);
        public void UpdateMember(Member member) => MemberDAO.Instance.UpdateMember(member);
        public void DeleteMember(Member member) => MemberDAO.Instance.DeleteMember(member);
        public Member CheckLogin(string email, string password) => MemberDAO.Instance.CheckLogin(email, password);
    }
}
