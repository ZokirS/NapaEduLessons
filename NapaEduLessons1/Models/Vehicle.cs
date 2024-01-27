namespace NapaEduLessons1.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
        public DateTime ManufacturedDate { get; set; }
        public int Mileage { get; set; }
        public int PersonId { get; set; }
        public Person Owner { get; set; }
    }
}
