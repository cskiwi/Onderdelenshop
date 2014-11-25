using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace Onderdelenshop.Users{
	[Table("osUser")]
	public class User : Entity{
		public virtual string Name { get; set; }
	}
}