using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrazyNails.Models
{
	public class NailSpecialist
	{
		public NailSpecialist()
		{
			Clients = new HashSet<Client>();
		}
		public int Id { get; set; }
		public string Passwrod { get; set; }
		public string Name { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }

		public virtual ICollection<Client> Clients { get; set; }
	}
}