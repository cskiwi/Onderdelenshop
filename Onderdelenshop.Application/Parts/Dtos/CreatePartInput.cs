using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace Onderdelenshop.Parts.Dtos{
	public class CreatePartInput : IInputDto{
		public int? UserId { get; set; }

		[Required]
		public string Description { get; set; }
		[Required]
		public string Title { get; set; }

		public override string ToString(){
			return string.Format("[CreateTaskInput > UserId = {0}, Description = {1}, Title = {2}]", UserId, Description, Title);
		}
	}
}