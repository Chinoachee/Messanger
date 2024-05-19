using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messanger.Model.User
{
    public class User
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		private string firstName;

		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}
		private string secondName;

		public string SecondName
		{
			get { return secondName; }
			set { secondName = value; }
		}
		private int myVar;

		private string login;

		public string Login
		{
			get { return login; }
			set { login = value; }
		}
		private string password;

		public string Password
		{
			get { return password; }
			set { password = value; }
		}





	}
}
