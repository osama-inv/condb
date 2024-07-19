using System.ComponentModel.DataAnnotations;

namespace condb.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string MyString { get; set; }
    }
}
