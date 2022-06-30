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
        public Member GetMemberByID(int memID)
        {
            throw new NotImplementedException();
        }
        public void InsertMember(Member member) => MemberDAO.Instance.InsertMember(member);
        public void UpdateMember(Member member)
        {

        }
        public void DeleteMember(Member member)
        {
            throw new NotImplementedException();
        }
    }
}
