using HulkOut.Shared.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace HulkOut.Data.EF
{
	public class HulkOutDbContext : DbContext
	{
		public DbSet<Audit> Audits { get; set; }

		public DbSet<Incident> Incidents { get; set; }
		public DbSet<IncidentCategory> IncidentCategories { get; set; }
		public DbSet<IncidentTracker> IncidentTrackers { get; set; }
		public DbSet<IncidentTrackerLog> IncidentTrackerLogs { get; set; }

		public DbSet<User> Users { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyDatabase;Trusted_Connection=True;");
		}

		//private static void ContextOnSavingChanges(object sender, EventArgs eventArgs)
		//{
		//	var context = (ObjectContext) sender;
		//	{
		//		var userId = new Guid();
		//		var date = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Utc);

		//		foreach (var entry in context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified))
		//		{
		//			var baseModel = (BaseModel) entry.Entity;

		//			baseModel.LastUpdatedDate = date;
		//			baseModel.LastUpdatedByUserId = userId;

		//			if (entry.State != EntityState.Added) continue;

		//			baseModel.CreatedDate = date;
		//			baseModel.CreatedByUserId = userId;
		//		}
		//	}
		//}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//Configure domain classes using Fluent API here

			base.OnModelCreating(modelBuilder);
		}
	}
}