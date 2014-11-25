using Abp.Application.Services;
using Onderdelenshop.Users.Dtos;

namespace Onderdelenshop.Users{
	public interface IUserAppService : IApplicationService{
		GetAllPeopleOutput GetAllPeople();
	}
}