using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-FCK5R8M\\SQLEXPRESS; database=CoreApiProjeKampi; integrated security=true;");
        }
        public DbSet<Employe> Employes { get; set; }
    }
}
