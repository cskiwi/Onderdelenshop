using System.Collections.Generic;
using Abp.Application.Services.Dto;

namespace Onderdelenshop.Parts.Dtos{
	public class GetPartsOutput : IOutputDto{
		public List<PartDto> Parts { get; set; }
	}
}