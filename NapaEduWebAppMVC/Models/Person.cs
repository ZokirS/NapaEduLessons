using System.ComponentModel.DataAnnotations;

namespace NapaEduWebAppMVC.Models
{
    public class Person
    {
        public int Id { get; set; }
        [MinLength(5)]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
