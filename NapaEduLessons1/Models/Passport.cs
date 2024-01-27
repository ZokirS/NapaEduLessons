namespace NapaEduLessons1.Models
{
    public class Passport
    {
        public int PassportId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Series { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
