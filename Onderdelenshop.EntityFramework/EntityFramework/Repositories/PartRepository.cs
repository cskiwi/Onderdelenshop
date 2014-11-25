using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Onderdelenshop.Parts;

namespace Onderdelenshop.EntityFramework.Repositories{
	public class PartRepository : OnderdelenshopRepositoryBase<Part, long>, IPartRepository{
		public List<Part> GetAllWithUsers(int? userId, PartState? state){
			var query = GetAll();

			if (userId.HasValue){
				query = query.Where(part => part.User.Id == userId.Value);
			}

			if (state.HasValue){
				query = query.Where(part => part.State == state);
			}
			return query
				.OrderByDescending(part => part.CreationTime)
				.Include(part => part.User)
				.ToList();
		}
	}
}