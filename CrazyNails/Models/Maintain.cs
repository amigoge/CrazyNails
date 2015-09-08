using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrazyNails.Models
{
	public class Maintain
	{
		public int Id { get; set; }
		public bool Beeswax { get; set; }
		public decimal Price { get; set; }

		public int MaintainCategoryId { get; set; }
		public virtual MaintainCategory MaintainCategory { get; set; }

		public int TransactionId { get; set; }
		public virtual Transaction Transaction { get; set; }
	}
}