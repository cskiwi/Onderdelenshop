using System.Collections.Generic;
using Abp.Application.Services.Dto;

namespace Onderdelenshop.Users.Dtos{
	public class GetAllPeopleOutput : IOutputDto{
		public List<UserDto> Users { get; set; }
	}
}