using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrazyNails.Models
{
	public class Transaction
	{
		public Transaction() 
		{

		}
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public decimal Amount { get; set; }
		
		//public int? CleanId { get; set; }
		public virtual  Clean clean { get; set; }
		
		//public int? NailArtId { get; set; }
		public virtual NailArt Nailart { get; set; }

		//public int? MaintainId { get; set; }
		public virtual Maintain Maintain { get; set; }

		public int TrafficId { get; set; }
		public virtual  Traffic Traffic { get; set; }

		public int ClientId { get; set; }
		public virtual Client Client { get; set; }
	}
}