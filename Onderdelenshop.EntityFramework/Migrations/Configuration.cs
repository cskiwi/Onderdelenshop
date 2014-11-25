using System.Data.Entity.Migrations;
using System.Security.Cryptography;
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

			var user1 = new User
			{
				Name = "Isaac Asimov",
				Username = "Steve",
				Email = "Steve@gmail.com",
				Password = "test"
			};
			context.Users.AddOrUpdate(
				p => p.Name,
				user1,
				new User{
					Name = "Thomas More",
					Username = "ItchyGamer",
					Email = "ItchyGamer@gmail.com",
					Password = "test"
				},
				new User{
					Name = "George Orwell",
					Username = "FastGamer",
					Email = "FastGamer@gmail.com",
					Password = "test"
				},
				new User{
					Name = "Douglas Adams",
					Username = "ItchyGamer",
					Email = "FlutteringGamer@gmail.com",
					Password = "test"
				}
				);

			context.Parts.AddOrUpdate(p => p.Title,
				new Part{
					Title = "Some awesome part",
					Description = "This is an awesome part with some more awesome description",
					UserId = user1.Id
				},
				new Part{
					Title = "Some awesome part2",
					Description = "This is an awesome part2 with some more awesome description",
					UserId = user1.Id
				}
				);
		}
	}
}