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
                member = fStore.Members.ToList();
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return member;
        }
        public void InsertMember(Member member)
        {
            try
            {
                FStoreASM2Context Context = new FStoreASM2Context();
                Context.Members.Add(member);
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}