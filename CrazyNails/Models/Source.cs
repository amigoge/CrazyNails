using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrazyNails.Models
{
	public class Source
	{
		public int Id { get; set; }

		[StringLength(20)]
		public string SourceName { get; set; }

		public virtual ICollection<Client> Clients { get; set; }
	}
}