using Microsoft.EntityFrameworkCore;
using Vendinha.Models;

namespace Vendinha.Data {

    namespace Vendinha.Data
{
    public class VendinhaContext : DbContext
    {
        public VendinhaContext(DbContextOptions<VendinhaContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes {get; set;}
    }
}
