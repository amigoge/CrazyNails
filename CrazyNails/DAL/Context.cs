using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CrazyNails.Models;
namespace CrazyNails.DAL
{
	public class Context:DbContext
	{
		public Context() : base("name=CrazyNails") 
		{
			
		}
		public DbSet<NailSpecialist> NailSpecialists { get; set; }
		public DbSet<Client> Clients { get; set; }
		public DbSet<Source> Sources { get; set; }
		public DbSet<Area> Area { get; set; }
		public DbSet<Transaction> Transactions { get; set; }
		public DbSet<Traffic> Traffics { get; set; }
		public DbSet<Clean> Cleans { get; set; }
		public DbSet<CleanCategory> CleanCategories { get; set; }
		public DbSet<Gel> Gels { get; set; }
		public DbSet<GelCategory> GelCategories { get; set; }
		public DbSet<Crystal> Crystals { get; set; }
		public DbSet<CrystalCategory> CrystalCategories { get; set; }
		public DbSet<Adornment> Adornments { get; set; }
		public DbSet<AdornmentCategory> AdornmentCategories { get; set; }
		public DbSet<Fix> Fixes { get; set; }
		public DbSet<Style> Styles { get; set; }
		public DbSet<Maintain> Maintains { get; set; }
		public DbSet<MaintainCategory> MaintainCategories { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new AdornmentMap());
			modelBuilder.Configurations.Add(new CleanCategoryMap());
			modelBuilder.Configurations.Add(new ClientMap());
			modelBuilder.Configurations.Add(new CrystalMap());
			modelBuilder.Configurations.Add(new GelMap());
			modelBuilder.Configurations.Add(new MaintainCategoryMap());
			modelBuilder.Configurations.Add(new NailArtMap());
			modelBuilder.Configurations.Add(new TransactionMap());
		}
	}
}