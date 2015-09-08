using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrazyNails.Models
{
	public abstract class NailArt
	{
		public NailArt() 
		{
			Adornments = new HashSet<Adornment>();
			Fixes = new HashSet<Fix>();
		}
		public int Id { get; set;}
		public decimal Price { get; set; }

		public int TransactionId { get; set; }
		public virtual Transaction Transaction { get; set; }
		
		public int StyleId { get; set; }
		public virtual Style Style { get; set; }

		public virtual ICollection<Adornment> Adornments { get; set; }
		public virtual ICollection<Fix> Fixes { get; set; }
	}
}