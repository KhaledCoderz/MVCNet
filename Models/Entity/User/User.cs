using System.ComponentModel.DataAnnotations;

namespace MVCNet.Models.Entity.User
{
    public class User
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }


        [Required]
        [StringLength(100)]
        public string Email { get; set; }


        [Required]
        [StringLength(32)]
        public string Password { get; set; }
        

        [Required]
        public int Age { get; set; }    
    }
}
