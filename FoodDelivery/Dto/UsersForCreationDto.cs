using System.ComponentModel.DataAnnotations;

namespace FoodDelivery.Dto
{
    public class UsersForCreationDto
    {
        public short Id { get; set; }
        [Required]
        [StringLength(255)]
        public string FName { get; set; }
        [Required]
        [StringLength(255)]
        public string LName { get; set; }
        [Required]
        [StringLength(255)]
        public string Email { get; set; }
        [Required]
        public byte[] Password { get; set; }
    }
}
