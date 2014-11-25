using System.Data.Entity.Migrations;
using Onderdelenshop.EntityFramework;
using Onderdelenshop.Parts;
using Onderdelenshop.Users;

namespace Onderdelenshop.Migrations{
	internal sealed class Configuration : DbMigrationsConfiguration<OnderdelenshopDbContext>{
		public Configuration(){
			AutomaticMigrationsEnabled = false;
			ContextKey = "Onderdelenshop";
		}

		protected override void Seed(OnderdelenshopDbContext context){
			var user1 = new User{Name = "Isaac Asimov"};
			context.Users.AddOrUpdate(
				p => p.Name,
				user1,
				new User{Name = "Thomas More"},
				new User{Name = "George Orwell"},
				new User{Name = "Douglas Adams"}
				);

			context.Parts.AddOrUpdate(p => p.Title,
				new Part{
					Title = "Some awesome part",
					Description = "This is an awesome part with some more awesome description",
					User = user1
				},
				new Part{
					Title = "Some awesome part2",
					Description = "This is an awesome part2 with some more awesome description",
					User = user1
				}
				);
		}
	}
}