using Microsoft.EntityFrameworkCore;
using SindOnibus.model;

namespace SindOnibus.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        
        public DbSet<Cadastro> Cadastros { get; set; }
    }
}