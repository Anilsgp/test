using Microsoft.EntityFrameworkCore;
using mysampleapp.Models;

namespace MYSampleApp.Data
{
    public class SampleDbContext:DbContext
    {
        public SampleDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CustomerModel> Customers { get; set; }
    }
}
