using System.Data.Entity;
using HulkOut.Models.Data;

namespace HulkOut.Data.EF
{
	public class HulkOutDbContext : DbContext
	{
		public HulkOutDbContext() : base("HulkOutDbConnectionString")
		{
		}

		public DbSet<Audit> Audits { get; set; }

		public DbSet<Incident> Incidents { get; set; }
		public DbSet<IncidentCategory> IncidentCategories { get; set; }
		public DbSet<IncidentTracker> IncidentLogs { get; set; }

		public DbSet<User> Users { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			//Configure domain classes using Fluent API here

			base.OnModelCreating(modelBuilder);
		}
	}
}