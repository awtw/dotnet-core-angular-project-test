using Microsoft.EntityFrameworkCore;
using App.Api.Models;

namespace App.Api.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }
		public DbSet<Value> Values { get; set; }
	}
}