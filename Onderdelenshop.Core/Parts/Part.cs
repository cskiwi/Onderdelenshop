using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Onderdelenshop.Users;

namespace Onderdelenshop.Parts{
	[Table("osParts")]
	public class Part : Entity<long>, IHasCreationTime{
		public Part(){
			CreationTime = DateTime.Now;
			State = PartState.Available;
		}

		[ForeignKey("UserId")]
		public virtual User User { get; set; }

		public virtual int? UserId { get; set; }

		public virtual string Title { get; set; }

		public virtual string Description { get; set; }
		public virtual PartState State { get; set; }
		public virtual DateTime CreationTime { get; set; }
	}
}