using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkShortener.Persistence
{
    public class ShortenedLinkDBContext : DbContext
    {
        public ShortenedLinkDBContext(DbContextOptions<ShortenedLinkDBContext> options)
        : base(options)
        {
        }
        public DbSet<ShortenedLink> ShortenedLink { get; set; }
    }
}
