using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchical_Menu_Assessment
{
	interface IUserService
	{
		public User GetUser(string name);

		public User Create(User user);

		public User Edit(User user, string username);
	}
}
