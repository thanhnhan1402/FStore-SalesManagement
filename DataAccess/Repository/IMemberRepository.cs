
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetMemberList();
        Member GetMemberByID(Member member);
        void InsertMember(Member member);
        void UpdateMember(Member member);
        void DeleteMember(Member member);
        Member CheckLogin(string email, string password);
    }
}
