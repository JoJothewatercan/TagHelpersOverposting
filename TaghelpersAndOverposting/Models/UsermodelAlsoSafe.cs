using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TaghelpersAndOverposting.Models
{
    public class UsermodelAlsoSafe
    {
        [MaxLength(200)]
        [Display(Name = "Fullname")]
        [Required]
        public string Name { get; set; }
    }

    public class UsermodelBlsoSafe : UsermodelAlsoSafe
    {
        public bool isAdmin { get; set; }
    }
}
