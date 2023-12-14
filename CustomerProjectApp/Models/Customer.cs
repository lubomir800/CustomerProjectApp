using System.ComponentModel.DataAnnotations;

namespace CustomerProjectApp.Models
{
    public class Customer
    {
        [Key]
        public int IdOfTable { get; set; }
        [Required]
        public int numberOfTables { get; set; }
        [Required]
        public bool smokers { get; set; }
        public Customer()
        {
            
        }
    }
}
