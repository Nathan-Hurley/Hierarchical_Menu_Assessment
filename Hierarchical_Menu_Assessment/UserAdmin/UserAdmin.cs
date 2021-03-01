using System.Collections.Generic;
using System.Linq;

namespace Hierarchical_Menu_Assessment
{
	public class UserAdmin : IUserService
	{
		public List<User> users;

		public UserAdmin()
		{
			users = new List<User>();
		}

		public User GetUser(string name)
		{
			return users.SingleOrDefault(r => r.Name == name);
		}

		public User Create(User user)
		{
			users.Add(user);
			return user;
		}

		public User Edit(User user, string username)
		{
			var newUser = users.FirstOrDefault(x => x.Name == user.Name);
			newUser.Name = username;
			return newUser;
		}
	}
}