using API.models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        
        //Lista de propriedades que vão virar tabelas no banco.

        public DbSet<Automovel> Automoveis { get; set; }
    }
}