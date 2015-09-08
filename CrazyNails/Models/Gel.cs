using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrazyNails.Models
{
	public class Gel:NailArt
	{

		public bool Extension { get; set; }

		public int GelCategoryId { get; set; }
		public virtual GelCategory GelCategory { get; set; }
	}
}