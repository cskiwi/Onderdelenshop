using System.Collections.Generic;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper;
using Onderdelenshop.Parts.Dtos;
using Onderdelenshop.Users;

namespace Onderdelenshop.Parts{
	public class PartAppService : OnderdelenshopAppServiceBase, IPartAppService
	{
		private readonly IPartRepository _partRepository;
		private readonly IRepository<User> _userRepository;

		public PartAppService(IPartRepository partRepository, IRepository<User> userRepository)
		{
			_partRepository = partRepository;
			_userRepository = userRepository;
		}

		public GetPartsOutput GetParts(GetPartsInput input){
			var parts = _partRepository.GetAllWithUsers(input.UserId, input.State);
			return new GetPartsOutput{
				Parts = Mapper.Map<List<PartDto>>(parts)
			};
		}

		public void UpdatePart(UpdatePartInput input){
			Logger.Info("Updating a part for input: " + input);

			var part = _partRepository.Get(input.PartId);

			if (input.State.HasValue){
				part.State = input.State.Value;
			}
			if (input.UserId.HasValue){
				part.User = _userRepository.Load(input.UserId.Value);
			}
		}

		public void CreatePart(CreatePartInput input){
			Logger.Info("Creating a part for input: " + input);
			var part = new Part{
				Description = input.Description,
				Title = input.Title
			};
			if (input.UserId.HasValue){
				part.User = _userRepository.Load(input.UserId.Value);
			}

			_partRepository.Insert(part);
		}
	}
}