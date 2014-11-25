using System.Collections.Generic;
using Abp.Domain.Repositories;

namespace Onderdelenshop.Parts{
	public interface IPartRepository : IRepository<Part, long>{
		List<Part> GetAllWithUsers(int? userId, PartState? state);
	}
}