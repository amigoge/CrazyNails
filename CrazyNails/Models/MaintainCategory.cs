using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrazyNails.Models
{
	public class MaintainCategory
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public virtual ICollection<Maintain> Maintain { get; set; }
	}
}