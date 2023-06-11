using System.ComponentModel.DataAnnotations;

namespace Block1StudentWebsite.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "* Required")]//Marks an item as "required". Useful for non-nullable database fields.
        public string Name { get; set; }

        [Required(ErrorMessage = "* Required")]
        [DataType(DataType.EmailAddress)] //Certain formatting is expected (@ symbol, .com, etc.)
        public string Email { get; set; }

        [Required(ErrorMessage = "* Required")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "* Required")]
        [DataType(DataType.MultilineText)] //Makes the textbox for this field bigger.
        public string Message { get; set; }
    }
}
