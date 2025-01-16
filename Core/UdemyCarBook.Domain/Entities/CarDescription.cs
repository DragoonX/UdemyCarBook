namespace UdemyCarBook.Domain.Entities
{
    public class CarDescription
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public string Detail { get; set; }
    }
}
