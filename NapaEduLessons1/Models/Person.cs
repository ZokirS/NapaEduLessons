namespace NapaEduLessons1.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Passport Passport { get; set; }
        public List<Vehicle> Vehicles{ get; set; }
    }
}
