using infra.Entities;
using Microsoft.EntityFrameworkCore;

namespace infra.Data
{
    public partial class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options){}


        public virtual DbSet<User> User { get;set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(user => user.HasKey(x => x.Id));

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);


    }
}
