using CrazyNails.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CrazyNails.DAL
{
	public class TransactionMap : EntityTypeConfiguration<Transaction>
	{
		public TransactionMap()
		{
			HasKey(p => p.Id);

			HasOptional(p => p.clean)			// 描述與卸甲服務的關係
				.WithRequired(o => o.Transaction)
				.WillCascadeOnDelete(false);

			HasOptional(p => p.Nailart)			// 描述與指甲彩繪服務的關係
				.WithRequired(o => o.Transaction)
				.WillCascadeOnDelete(false);

			HasOptional(p => p.Maintain)		// 描述與保養服務的關係
				.WithRequired(p => p.Transaction)
				.WillCascadeOnDelete(false);

			HasRequired(p => p.Traffic)			// 描述與交通方式的關係
				.WithMany(s=>s.transactions)
				.HasForeignKey(p => p.TrafficId)
				.WillCascadeOnDelete(false);

			//HasRequired(p => p.Client)			// 由於在客戶端已描述
			//	.WithMany(o=>o.Transactions)
			//	.HasForeignKey(p => p.ClientId)
			//	.WillCascadeOnDelete(false);
		}
	}
}