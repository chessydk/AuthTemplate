using Microsoft.AspNet.Identity.EntityFramework;

namespace AuthTemplate1
{
    public class AuthContext :  IdentityDbContext<IdentityUser>
    {
        public AuthContext() : base("AuthContext")
        {
        }
    }
}