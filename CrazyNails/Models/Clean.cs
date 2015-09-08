using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrazyNails.Models
{
	public class Clean
	{
		public int Id { get; set; }
		public decimal Price { get; set; }

		public int CleanCategoryId { get; set; }
		public virtual CleanCategory CleanCategory { get; set; }

		public int TransactionId { get; set; }
		public virtual Transaction Transaction { get; set; }
	}
}