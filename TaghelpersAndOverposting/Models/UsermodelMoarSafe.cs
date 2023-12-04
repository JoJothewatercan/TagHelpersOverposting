using System.ComponentModel.DataAnnotations;

namespace TaghelpersAndOverposting.Models
{
    public class UsermodelMoarSafe
    {
        [MaxLength(200)]
        [Display(Name = "Fullname")]
        [Required]
        public string Name { get; set; }

        [Editable(false)]
        public bool IsAdmin { get; set; }
    }
}
