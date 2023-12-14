using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace CustomerProjectApp.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string FamilyName { get; set; }
        [Required]
        public int phoneNumber { get; set; }
        
        public List<Reservation> Reservations { get; set; }
        public User()
        {
            Name = "default";
            FamilyName = "default";
            Reservations = new List<Reservation>();
        }
    }
}
