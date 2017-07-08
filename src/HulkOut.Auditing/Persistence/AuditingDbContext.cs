using HulkOut.Shared.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace HulkOut.Auditing.Persistence
{
	public class AuditingDbContext : DbContext
	{
		public DbSet<Audit> Audits { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyDatabase;Trusted_Connection=True;");
		}
	}
}