using CrazyNails.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CrazyNails.DAL
{
	public class MaintainCategoryMap : EntityTypeConfiguration<MaintainCategory>
	{
	
		public MaintainCategoryMap()
		{
			Property(p=>p.Name)
				.HasMaxLength(30);

			HasMany(p=>p.Maintain)
				.WithRequired(o=>o.MaintainCategory)
				.HasForeignKey(o=>o.MaintainCategoryId)
				.WillCascadeOnDelete(false);
		}
	}
}