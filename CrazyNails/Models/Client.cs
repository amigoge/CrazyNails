using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrazyNails.Models
{
	public class Client
	{
		public Client() 
		{
			Transactions = new HashSet<Transaction>();
		}
		public int Id { get; set; }
		public string Name { get; set; }

		[DisplayFormat(DataFormatString="{0:####-######}")]
		public string Phone { get; set; }

		public DateTime Birthday { get; set; }
		public DateTime BuildDate { get; set; }			// 建立帳號的日期

		public int AreaId { get; set; }
		public virtual Area Area { get; set; }

		public int SourceId { get; set; }				// 是從哪裡得到資訊
		public virtual Source Source { get; set; }

		public int SpecialistId { get; set; }
		public virtual NailSpecialist Specialist { get; set; }

		public virtual ICollection<Transaction> Transactions { get; set; }
	}
}