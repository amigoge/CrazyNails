using CrazyNails.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CrazyNails.DAL
{
	public class NailArtMap : EntityTypeConfiguration<NailArt>
	{
		public NailArtMap() 
		{
			HasKey(p => p.Id);

			HasRequired(p => p.Style)			// 描述與風格的關係
				.WithMany(s=>s.NailArts)
				.HasForeignKey(p => p.StyleId)
				.WillCascadeOnDelete(false);

			HasMany(p => p.Adornments)			// 描述與裝飾的關係
				.WithRequired(o => o.NailArt)
				.HasForeignKey(o=>o.NailArtId)
				.WillCascadeOnDelete(false);

			HasMany(p => p.Fixes)				// 描述與修補的關係
				.WithRequired(o => o.Nailart)
				.HasForeignKey(o => o.NailArtId)
				.WillCascadeOnDelete(false);
		}
	}
}