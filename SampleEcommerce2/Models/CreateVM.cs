using System.ComponentModel.DataAnnotations;

namespace SampleEcommerce2.Models
{
    public class CreateVM
    {
        [Required(ErrorMessage ="Please Provide Your Name")]
        public String Name { get; set; }
        
        [Required(ErrorMessage ="Please Set Price")]
        public string Price { get; set; }

        public string? Address { get; set; }
    }
}
