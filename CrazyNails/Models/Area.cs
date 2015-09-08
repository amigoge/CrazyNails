using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrazyNails.Models
{
	public class Area
	{
		public int Id { get; set; }

		[StringLength(20)]
		public string AreaName { get; set; }

		public virtual ICollection<Client> Cleints { get; set; }
	}
}