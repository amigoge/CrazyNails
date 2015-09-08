using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrazyNails.Models
{
	public class Adornment
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public int NailArtId { get; set; }
		public virtual NailArt NailArt { get; set; }

		public int AdornmentCategoryId { get; set; }
		public virtual AdornmentCategory AdornmentCategory { get; set; }
	}
}