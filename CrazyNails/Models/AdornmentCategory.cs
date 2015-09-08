using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrazyNails.Models
{
	public class AdornmentCategory
	{
		public int Id { get; set; }

		[StringLength(20)]
		public string Name { get; set; }

		public virtual ICollection<Adornment> Adornment { get; set; }
	}
}