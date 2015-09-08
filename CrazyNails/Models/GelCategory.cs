using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrazyNails.Models
{
	public class GelCategory
	{
		public int Id { get; set; }

		[StringLength(20)]
		public string Name { get; set; }

		public virtual ICollection<Gel> Gels { get; set; }
	}
}