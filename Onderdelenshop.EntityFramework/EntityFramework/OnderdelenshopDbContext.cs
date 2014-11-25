using System.Data.Entity;
using Abp.EntityFramework;
using Onderdelenshop.Parts;
using Onderdelenshop.Users;

namespace Onderdelenshop.EntityFramework
{
    public class OnderdelenshopDbContext : AbpDbContext
    {
		public virtual IDbSet<Part> Parts { get; set; }

		public virtual IDbSet<User> Users { get; set; }

        public OnderdelenshopDbContext()
            : base("Default")
        {

        }

        public OnderdelenshopDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }
    }
}
