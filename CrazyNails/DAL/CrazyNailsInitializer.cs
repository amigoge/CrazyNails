using CrazyNails.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrazyNails.DAL
{
	public class CrazyNailsInitializer : DropCreateDatabaseIfModelChanges<Context>
	{
		protected override void Seed(Context context)
		{
			var NailSpecialist = new List<NailSpecialist>			// 建立美甲師資料
			{
				new NailSpecialist{
					Name="Karen",Phone="0960-592808",Email="damigo0@yahoo.com.tw",Passwrod="crazy123"
				}
			};
			NailSpecialist.ForEach(s => context.NailSpecialists.Add(s));
			context.SaveChanges();

			var Source = new List<Source>			// 建立曝光來源資料
			{
				new Source{SourceName="Facebook"},
				new Source{SourceName="Instagram"},
				new Source{SourceName="朋友介紹"},
				new Source{SourceName="美甲櫥窗"},
				new Source{SourceName="其他廣告"},
			};
			Source.ForEach(s => context.Sources.Add(s));
			context.SaveChanges();

			var Area = new List<Area>			// 建立地區資料
			{
				new Area{AreaName="新北市"},
				new Area{AreaName="台北市"},
				new Area{AreaName="其他"},
			};
			Area.ForEach(s => context.Area.Add(s));
			context.SaveChanges();

			var Traffic = new List<Traffic>			// 建立交通方式資料
			{ 
				new Traffic{TrafficWay="捷運"},
				new Traffic{TrafficWay="步行"},
				new Traffic{TrafficWay="機車"},
				new Traffic{TrafficWay="公車"},
				new Traffic{TrafficWay="汽車"},
			};
			Traffic.ForEach(s => context.Traffics.Add(s));
			context.SaveChanges();

			var CleanCategory = new List<CleanCategory>		// 建立卸甲種類資料
			{
				new CleanCategory{Name="本店卸甲"},
				new CleanCategory{Name="他店卸甲"},
			};
			CleanCategory.ForEach(s => context.CleanCategories.Add(s));
			context.SaveChanges();

			var GelCategory = new List<GelCategory>			// 建立凝膠種類資料
			{ 
				new GelCategory{Name="單色"},
				new GelCategory{Name="漸層"},
				new GelCategory{Name="法式"},
				new GelCategory{Name="雜誌款"},
				new GelCategory{Name="設計款"},
			};
			GelCategory.ForEach(s => context.GelCategories.Add(s));
			context.SaveChanges();

			var MaintainCategory = new List<MaintainCategory>	// 建立保養種類資料
			{
				new MaintainCategory{Name="基礎保養"},
				new MaintainCategory{Name="深層保養"},
			};
			MaintainCategory.ForEach(s => context.MaintainCategories.Add(s));
			context.SaveChanges();

			var CrystallCategory=new List<CrystalCategory>		// 建立水晶種類資料
			{
				new CrystalCategory{Name="單色"},
				new CrystalCategory{Name="漸層"},
				new CrystalCategory{Name="法式"},
				new CrystalCategory{Name="設計款"},
			};
			CrystallCategory.ForEach(s => context.CrystalCategories.Add(s));
			context.SaveChanges();

			var Style = new List<Style>					// 建立風格資料
			{
				new Style{Name="個性"},
				new Style{Name="手繪"},
				new Style{Name="簡單"},
				new Style{Name="甜美"},
			};
			Style.ForEach(s => context.Styles.Add(s));
			context.SaveChanges();

			var AdornmentCategory=new List<AdornmentCategory>		// 建立裝飾資料
			{
				new AdornmentCategory{Name="合金鑽"},
				new AdornmentCategory{Name="粉雕"},
			};
			AdornmentCategory.ForEach(s => context.AdornmentCategories.Add(s));
			context.SaveChanges();

			var Client = new List<Client>				// 建立客戶資料
			{
				new Client	
				{
					Name="孫小美",
					Phone="0986-073731",
					Birthday=new DateTime(1987,3,31),
					BuildDate=new DateTime(2015,8,1),

					SourceId=context.Sources.Where(s=>s.SourceName=="Facebook").Single().Id,
					SpecialistId=context.NailSpecialists.Where(s=>s.Phone=="0960-592808").Single().Id,
					AreaId=context.Area.Where(s=>s.AreaName=="新北市").Single().Id,
				},
				new Client
				{
					Name="錢夫人",
					Phone="0986-123321",
					Birthday=new DateTime(1969,1,11),
					BuildDate=new DateTime(2015,7,1),

					SourceId=context.Sources.Where(s=>s.SourceName=="朋友介紹").Single().Id,
					SpecialistId=context.NailSpecialists.Where(s=>s.Phone=="0960-592808").Single().Id,
					AreaId=context.Area.Where(s=>s.AreaName=="台北市").Single().Id
				},
				new Client
				{
					Name="金貝貝",
					Phone="0960-123321",
					Birthday=new DateTime(1989,6,3),
					BuildDate=new DateTime(2015,6,1),

					SourceId=context.Sources.Where(s=>s.SourceName=="Instagram").Single().Id,
					SpecialistId=context.NailSpecialists.Where(s=>s.Phone=="0960-592808").Single().Id,
					AreaId=context.Area.Where(s=>s.AreaName=="其他").Single().Id
				},
			};
			Client.ForEach(s => context.Clients.Add(s));
			context.SaveChanges();

			// 建立交易紀錄
			var transaction = new Transaction
			{
				Date=DateTime.Now,
				Amount=0,
				TrafficId=context.Traffics.Where(s=>s.TrafficWay=="機車").Single().Id,
				ClientId=context.Clients.Where(s=>s.Name=="金貝貝").Single().Id,
			};
			context.Transactions.Add(transaction);
			context.SaveChanges();

			// 建立交易紀錄中的保養=record
			var maintain = new Maintain 
			{
				MaintainCategoryId=context.MaintainCategories.Where(s=>s.Name=="基礎保養").Single().Id,
				Beeswax=true,
				Price=400,
				Transaction=transaction,
			};
			context.Maintains.Add(maintain);
			context.SaveChanges();

			// 建立交易紀錄中的卸甲record
			var clean = new Clean 
			{
				CleanCategoryId=context.CleanCategories.Where(s=>s.Name=="本店卸甲").Single().Id,
				Price=300,
				Transaction=transaction,
			};
			context.Cleans.Add(clean);
			context.SaveChanges();

			// 建立交易紀錄中的彩繪
			var gel = new Gel
			{
				GelCategoryId=context.GelCategories.Where(s=>s.Name=="單色").Single().Id,
				StyleId=context.Styles.Where(s=>s.Name=="手繪").Single().Id,
				Extension=true,
				Price=1000,
				Transaction=transaction,
			};
			context.Gels.Add(gel);
			context.SaveChanges();

			// 建立交易紀錄中的彩繪的裝飾
			var adornment = new Adornment 
			{
				AdornmentCategoryId=context.AdornmentCategories.Where(s=>s.Name=="粉雕").Single().Id,
				Name="蝴蝶結",
				NailArt=gel,
			};
			context.Adornments.Add(adornment);
			context.SaveChanges();

			// 建立交易紀錄中的彩繪的修補
			var fix = new Fix 
			{ 
				Date=DateTime.Now,
				Price=300,
				Context="手48；腳2",
				Nailart=gel,
			};
			context.Fixes.Add(fix);
			context.SaveChanges();

		}
	}
}