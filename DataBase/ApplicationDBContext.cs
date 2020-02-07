using Microsoft.EntityFrameworkCore;
using CrudLoja.Models;

namespace CrudLoja.DataBase
{    
    public class ApplicationDBContext : DbContext
    {

        public DbSet<Produto> Produtos {get; set;}
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options){}
       
    }
}