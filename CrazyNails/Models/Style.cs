using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrazyNails.Models
{
	public class Style
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public virtual ICollection<NailArt> NailArts { get; set; }	//可能會是水晶或凝膠
	}
}