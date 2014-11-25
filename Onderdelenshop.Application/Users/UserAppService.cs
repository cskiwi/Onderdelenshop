using System.Collections.Generic;
using Abp.Domain.Repositories;
using AutoMapper;
using Onderdelenshop.Users.Dtos;

namespace Onderdelenshop.Users{
	public class UserAppService : IUserAppService{
		private readonly IRepository<User> _userRepository;

		public UserAppService(IRepository<User> personRepository){
			_userRepository = personRepository;
		}

		public GetAllPeopleOutput GetAllPeople(){
			return new GetAllPeopleOutput{
				Users = Mapper.Map<List<UserDto>>(_userRepository.GetAllList())
			};
		}
	}
}