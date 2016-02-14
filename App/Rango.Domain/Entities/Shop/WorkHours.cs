namespace Rango.Domain.Entities.Shop
{
    public class WorkHours
    {
        public int Id { get; set; }

        public string Day { get; set; }

        public string OpeningHour { get; set; }

        public string LunchExit { get; set; }

        public string LunchReturn { get; set; }

        public string ExitHour { get; set; }
    }
}