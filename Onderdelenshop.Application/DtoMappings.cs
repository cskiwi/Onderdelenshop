using AutoMapper;
using Onderdelenshop.Parts;
using Onderdelenshop.Parts.Dtos;
using Onderdelenshop.Users;
using Onderdelenshop.Users.Dtos;

namespace Onderdelenshop{
	internal static class DtoMappings{
		public static void Map(){
			Mapper.CreateMap<Part, PartDto>().ForMember(t => t.UserId, opts => opts.MapFrom(d => d.User.Id));
			Mapper.CreateMap<User, UserDto>();
		}
	}
}
