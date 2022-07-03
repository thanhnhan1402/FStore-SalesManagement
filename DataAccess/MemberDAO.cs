using DataAccess.Models;
using Microsoft.Extensions.Configuration;

namespace DataAccess
{
    public class MemberDAO
    {
        private static MemberDAO instance { get; set; }
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Member> GetMemberList()
        {
            var member = new List<Member>();
            try
            {
                using FStoreASM2Context fStore = new FStoreASM2Context();
                member = fStore.Members.ToList();
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return member;
        }
        public Member GetMemberByID(Member member)
        {
            Member? mem;
            try
            {
                using FStoreASM2Context context = new();
                mem = context.Members.SingleOrDefault(m => m.MemberId == member.MemberId);
                if(mem == null)
                {
                    throw new Exception("This member does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return mem;
        }
        public void InsertMember(Member member)
        {
            try
            {
                using FStoreASM2Context Context = new FStoreASM2Context();
                Context.Members.Add(member);
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateMember(Member member)
        {
            try
            {
                using FStoreASM2Context Context = new FStoreASM2Context();
                Context.Entry<Member>(member).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteMember(Member member)
        {
            try
            {
                using FStoreASM2Context Context = new FStoreASM2Context();
                //find member by id
                var mem = GetMemberByID(member);
                Context.Members.Remove(mem);
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Member GetDefaultAccount()
        {
            Member account = null;
            IConfiguration config = new ConfigurationBuilder()
                                          .SetBasePath(Directory.GetCurrentDirectory())
                                          .AddJsonFile("appsettings.json", true, true)
                                          .Build();
            string email = config["account:email"];
            string password = config["account:password"];
            account = new Member
            {
                MemberId = 0,
                Email = email,
                CompanyName = "",
                City = "",
                Country = "",
                Password = password
            };
            return account;
        }
        public Member CheckLogin(string email, string password)
        {
            Member member = null;
            Member admin = GetDefaultAccount();
            if(admin.Email.Equals(email) && admin.Password.Equals(password))
            {
                member = admin;
            }
            else
            {
                using FStoreASM2Context context = new FStoreASM2Context();
                member = context.Members.SingleOrDefault(m => m.Email.Equals(email) && m.Password.Equals(password));
            }
            return member;
        }
    }
}