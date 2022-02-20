using InlämningsUppgiftAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace InlämningsUppgiftAPI.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public virtual DbSet<ProductEntities> Products { get; set; }

        public virtual DbSet<CategoryEntities> Categories { get; set; }
    }
}
