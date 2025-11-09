using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Model;
[Table("Participant")]
public class Participant
{
    [Key, Column("ParticipantId"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ParticipantId { get; set; }
    
    [Column("FirstName")]
    public string FirstName { get; set; }
    
    [Column("LastName")]
    public string LastName { get; set; }
    
    [Column("Email")]
    public string Email { get; set; }
    
    [Column("BirthDate")]
    public DateTime BirthDate { get; set; }
    
    [Column("Weight")]
    public decimal Weight { get; set; }
    
    [Column("Height")]
    public decimal Height { get; set; }
    
    [Column("CreatedAt")]
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    
    [Column("UpdatedAt")]
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}