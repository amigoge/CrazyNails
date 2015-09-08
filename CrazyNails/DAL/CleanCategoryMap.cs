using CrazyNails.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CrazyNails.DAL
{
	public class CleanCategoryMap : EntityTypeConfiguration<CleanCategory>
	{
		public CleanCategoryMap() 
		{
			Property(p => p.Name)
				.HasMaxLength(30);
			HasMany(p => p.Clean)
				.WithRequired(o => o.CleanCategory)
				.HasForeignKey(o => o.CleanCategoryId)
				.WillCascadeOnDelete(false);
		}
	}
}