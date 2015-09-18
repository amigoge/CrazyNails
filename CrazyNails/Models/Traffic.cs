using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrazyNails.Models
{
	public class Traffic
	{
		public int Id { get; set; }

		[StringLength(20)]
		public string TrafficWay { get; set; }

		public virtual ICollection<Transaction> transactions { get; set; }
	}
}