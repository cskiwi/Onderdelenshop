using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace Onderdelenshop.Users{
	[Table("osUser")]
	public class User : Entity{
		public virtual string Name { get; set; }
		public virtual string Username { get; set; }
		public virtual string Email { get; set; }
		public virtual string Password { get; set; }
	}
}