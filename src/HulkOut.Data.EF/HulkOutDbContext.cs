using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using HulkOut.Core.Models;
using HulkOut.Models.Data;

namespace HulkOut.Data.EF
{
	public class HulkOutDbContext : DbContext
	{
		public HulkOutDbContext() : base("HulkOutDbConnectionString")
		{
			var context = ((IObjectContextAdapter) this).ObjectContext;
			context.SavingChanges += ContextOnSavingChanges;
		}

		public DbSet<Audit> Audits { get; set; }

		public DbSet<Incident> Incidents { get; set; }
		public DbSet<IncidentCategory> IncidentCategories { get; set; }
		public DbSet<IncidentTracker> IncidentTrackers { get; set; }
		public DbSet<IncidentTrackerLog> IncidentTrackerLogs { get; set; }

		public DbSet<User> Users { get; set; }

		private static void ContextOnSavingChanges(object sender, EventArgs eventArgs)
		{
			var context = (ObjectContext) sender;
			{
				var userId = new Guid();
				var date = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Utc);

				foreach (var entry in context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified))
				{
					var baseModel = (BaseModel) entry.Entity;

					baseModel.LastUpdatedDate = date;
					baseModel.LastUpdatedByUserId = userId;

					if (entry.State != EntityState.Added) continue;

					baseModel.CreatedDate = date;
					baseModel.CreatedByUserId = userId;
				}
			}
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			//Configure domain classes using Fluent API here

			base.OnModelCreating(modelBuilder);
		}
	}
}