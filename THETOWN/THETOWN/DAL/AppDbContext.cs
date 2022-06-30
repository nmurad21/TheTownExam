using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using THETOWN.Models;

namespace THETOWN.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<TheTownBackground> theTownBackground { get; set; }
        public DbSet<Introduction> introductions { get; set; }
        public DbSet<Transportation> transportations { get; set; }
        public DbSet<WorkTitle> workTitles { get; set; }
        public DbSet<WorkSlider> workSliders { get; set; }
        public DbSet<Contact> contacts { get; set; }
    }
}
