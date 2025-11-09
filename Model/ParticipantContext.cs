using Microsoft.EntityFrameworkCore;

namespace Model;

public class ParticipantContext:DbContext
{
    public ParticipantContext(DbContextOptions<ParticipantContext> options):base(options)
    { }
    
    public DbSet<Participant> Participants { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}