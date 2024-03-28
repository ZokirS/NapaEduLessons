using Microsoft.EntityFrameworkCore;

namespace Lesson2.Models
{
    [Keyless]
    public class Animal
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Weight { get; set; }
    }
}
