using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrazyNails.Models
{
	public class Crystal:NailArt
	{
		public int CrystalCategoryId { get; set; }
		public virtual CrystalCategory CrystalCategory { get; set; }
	}
}