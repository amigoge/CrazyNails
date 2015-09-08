using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CrazyNails.Models;
using System.Data.Entity.ModelConfiguration;
namespace CrazyNails.DAL
{
	public class ClientMap : EntityTypeConfiguration<Client>
	{
		public ClientMap() 
		{
			HasKey(p => p.Id);
			Property(p => p.Name)
				.HasMaxLength(10);
			Property(p => p.Birthday)
				.HasColumnType("datetime2");
			Property(p => p.BuildDate)
				.HasColumnType("datetime2");

			HasRequired(p => p.Area)			// 描述與居住區域的關係
				.WithMany(o => o.Cleints)
				.HasForeignKey(p => p.AreaId)
				.WillCascadeOnDelete(false);

			HasRequired(p => p.Specialist)		// 描述與美甲師的關係
				.WithMany(o => o.Clients)
				.HasForeignKey(o => o.SpecialistId)
				.WillCascadeOnDelete(false);

			HasMany(p => p.Transactions)		// 描述與交易紀錄的關係
				.WithRequired(o => o.Client)
				.HasForeignKey(o => o.ClientId)
				.WillCascadeOnDelete(false);

			HasRequired(p => p.Source)			// 描述與資訊來源的關係
				.WithMany(o => o.Clients)
				.HasForeignKey(p => p.SourceId)
				.WillCascadeOnDelete(false);
		}
	}
}