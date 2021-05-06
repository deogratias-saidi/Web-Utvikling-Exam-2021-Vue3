using Microsoft.EntityFrameworkCore;

namespace FindAMusicianAPI.Models{
    public class FindAMusicianDbContext : DbContext{
        public FindAMusicianDbContext(DbContextOptions<FindAMusicianDbContext> options): base(options){}

        
        public DbSet<Request> Requests {get; set;}
        public DbSet<Artist> Artists {get; set;}
    }
}