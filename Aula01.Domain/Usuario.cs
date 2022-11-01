using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01.Domain
{
	public  class Usuario : Entity
	{
		public Usuario(string userName, string password)
		{
			UserName = userName;
			Password = password;
		}

		public string UserName { get; set; }
		public string Password { get; set; }
	}
}
