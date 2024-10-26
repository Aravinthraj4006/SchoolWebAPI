using System.ComponentModel.DataAnnotations;

namespace CrudProjectApi.Model
{
    public class Feedback
    {
       
            public int Id { get; set; }

            [Required(ErrorMessage = "Name is required.")]
            public string Name { get; set; }

            [EmailAddress(ErrorMessage = "Invalid email address.")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Category is required.")]
            public string Category { get; set; }

            [Required(ErrorMessage = "Comments are required.")]
            public string Comments { get; set; }

            [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
            public int Rating { get; set; }
        
    }
}
