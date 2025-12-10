using System.ComponentModel.DataAnnotations;

namespace LiftLending.Models
{  
    public class UserData
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
    }
}
