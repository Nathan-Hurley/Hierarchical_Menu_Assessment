using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchical_Menu_Assessment
{
	public class Administration
	{
		private IUserService userService;

		public Administration(UserAdmin userAdmin)
		{
			userService = userAdmin;
		}

		public UserAdmin CreateAdminUser(string userName)
		{
			User user = new User()
			{
				Name = userName
			};

			userService.Create(user);
			return (UserAdmin)userService;
		}

		public UserAdmin EditAdminUser(string userName, string newUserName)
		{
			var currentUser = userService.Get(userName);
			userService.Edit(currentUser, newUserName);
			return (UserAdmin)userService;
		}
	}
}
