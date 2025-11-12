using Microsoft.EntityFrameworkCore;
using BaghaleMahal.Models;
namespace BaghaleMahal.Data
{
    public class ApiContext : DbContext
    {
        public required DbSet<Items> Items { get; set; }
        public ApiContext(DbContextOptions<ApiContext> options)
            :base(options)
        {
            
        }
    }
}
