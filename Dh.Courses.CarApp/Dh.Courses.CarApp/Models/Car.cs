namespace Dh.Courses.CarApp.Models
{
    public class Car
    {
        public int id { get; set; }
        public string Company { get; set; }
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        public int Mileage { get; set; }
        public int Capacity { get; set; }
        public string FuelType { get; set; }
        public int Power { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public string ThumbnailURL { get; set; }
        public bool IsCarOfTheWeek { get; set; }
    }
}
