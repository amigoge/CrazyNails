using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrazyNails.Models
{
	public class Fix
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public decimal Price { get; set; }

		[StringLength(20)]
		public string Context { get; set; }

		public int NailArtId { get; set; }
		public virtual NailArt Nailart { get; set; }
	}
}