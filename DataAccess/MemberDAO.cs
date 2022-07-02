using DataAccess.Models;

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
                foreach(Member member2 in fStore.Members.ToList())
                {
                    member.Add(member2);
                }
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
                var m = GetMemberByID(member);
                m.Email = member.Email;
                m.City = member.City;
                m.Country = member.Country;
                m.CompanyName = member.CompanyName;
                Context.Members.Update(m);
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
    }
}