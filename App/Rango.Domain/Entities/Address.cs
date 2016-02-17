namespace Rango.Domain.Entities
{
    public class Address
    {
        public int Id { get; private set; }

        public string Street { get; private set; }

        public string Number { get; private set; }

        public string City { get; private set; }

        public string State { get; private set; }

        public string ZipCode { get; private set; }

        public string TypeAddress { get; private set; }

        public string Latitude { get; private set; }

        public string Longitude { get; private set; }
    }
}