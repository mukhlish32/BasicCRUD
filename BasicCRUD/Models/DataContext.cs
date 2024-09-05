using Microsoft.EntityFrameworkCore;

namespace BasicCRUD.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
}
}