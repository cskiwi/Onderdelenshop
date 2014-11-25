using Abp.Application.Services.Dto;

namespace Onderdelenshop.Parts.Dtos{
	public class GetPartsInput : IInputDto{
		public PartState? State { get; set; }
		public int? UserId { get; set; }
	}
}