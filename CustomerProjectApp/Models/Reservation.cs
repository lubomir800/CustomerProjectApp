using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace CustomerProjectApp.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime DateAndTime { get; set; }
        [Required]
        public string Description { get; set; }

        [Required]
        public int TableId { get; set; }
        [Required]
        public Table Table { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public User User { get; set; }
        public Reservation()
        {
            
        }
    }
}
