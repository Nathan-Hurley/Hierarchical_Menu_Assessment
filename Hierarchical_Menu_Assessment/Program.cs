using System;

namespace Hierarchical_Menu_Assessment
{
	class Program
	{
		static void Main(string[] args)
		{
			var userAdmin = new UserAdmin();
			var admin = new Administration(userAdmin);
			
			admin.CreateAdminUser("Nathan");
			admin.EditAdminUser("Nathan", "Matthew");

			Console.WriteLine("Administration");
			Console.WriteLine("User Admin");
			Console.ReadKey();

		}
	}
}
