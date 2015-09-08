using CrazyNails.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CrazyNails.DAL
{
	public class GelMap : EntityTypeConfiguration<Gel>
	{
		public GelMap() 
		{

			HasRequired(p => p.GelCategory)
				.WithMany(o => o.Gels)
				.HasForeignKey(p => p.GelCategoryId)
				.WillCascadeOnDelete(false);
		}
	}
}