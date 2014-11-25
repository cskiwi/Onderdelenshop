using System;
using Abp.Application.Services.Dto;

namespace Onderdelenshop.Parts.Dtos{
	public class PartDto : EntityDto<long>{
		public int? UserId { get; set; }
		public string Title { get; set; }
		public string UserName { get; set; }
		public string Description { get; set; }
		public DateTime CreationTime { get; set; }
		public byte State { get; set; }
	}
}