using CrazyNails.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CrazyNails.DAL
{
	public class CrystalMap : EntityTypeConfiguration<Crystal>
	{
		public CrystalMap() 
		{
			HasRequired(p => p.CrystalCategory)
				.WithMany(o => o.Crystal)
				.HasForeignKey(p => p.CrystalCategoryId)
				.WillCascadeOnDelete(false);
		}
	}
}