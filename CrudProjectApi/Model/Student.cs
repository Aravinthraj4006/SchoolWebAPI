using System.ComponentModel.DataAnnotations;

namespace CrudProjectApi.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }//Primarykey
        [Required]
        public string? Name { get; set; }//Nullable

        public string? Description { get; set; }//Nullable

        public int PhoneNo { get; set; }
    }
}
