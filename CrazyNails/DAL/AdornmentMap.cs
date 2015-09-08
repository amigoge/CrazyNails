using CrazyNails.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CrazyNails.DAL
{
	public class AdornmentMap : EntityTypeConfiguration<Adornment>
	{
		public AdornmentMap() 
		{

			HasRequired(p => p.AdornmentCategory)
				.WithMany(o => o.Adornment)
				.HasForeignKey(p => p.AdornmentCategoryId)
				.WillCascadeOnDelete(false);

		}
	}
}