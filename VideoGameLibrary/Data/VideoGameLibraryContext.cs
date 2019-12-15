using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VideoGameLibrary.Models
{
    public class VideoGameLibraryContext : DbContext
    {
        public VideoGameLibraryContext (DbContextOptions<VideoGameLibraryContext> options)
            : base(options)
        {
        }

        public DbSet<VideoGameLibrary.Models.Game> Game { get; set; }
    }
}
