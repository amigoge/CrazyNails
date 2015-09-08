using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrazyNails.Models
{
	public class CleanCategory
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public virtual ICollection<Clean> Clean { get; set; }
	}
}