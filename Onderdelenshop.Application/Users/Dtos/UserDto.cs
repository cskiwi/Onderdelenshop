using Abp.Application.Services.Dto;

namespace Onderdelenshop.Users.Dtos{
	public class UserDto : EntityDto{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Username { get; set; }
		public string Email { get; set; }
	}
}