using Rango.Common.Resources.Errors;
using Rango.Common.Validation;

namespace Rango.Domain.Entities
{
    public class Address
    {
        #region Constructor
        public Address(string street, string number, string city, string state, string zipCode, string complement, string latitude, string longitude, int id = 0)
        {
            Validate(street, number, city, state, zipCode, complement, latitude, longitude, id);
        }
        #endregion

        #region Properties
        public int Id { get; private set; }

        public string Street { get; private set; }

        public string Number { get; private set; }

        public string City { get; private set; }

        public string State { get; private set; }

        public string ZipCode { get; private set; }

        public string Complement { get; private set; }

        public string Latitude { get; private set; }

        public string Longitude { get; private set; }
        #endregion

        #region Methods
        private void Validate(string street, string number, string city, string state, string zipCode, string complement, string latitude, string longitude, int id = 0)
        {
            if (id > 0)
            {
                Id = id;
            }

            if (AssertionConcern.AssertArgumentLength(street, 2, 255, Errors.StreetInvalid))
            {
                Street = street;
            }

            if (AssertionConcern.AssertArgumentLength(number, 2, 50, Errors.StreetNumberInvalid))
            {
                Number = number;
            }

            if (AssertionConcern.AssertArgumentLength(city, 2, 100, Errors.CityInvalid))
            {
                City = city;
            }

            if (AssertionConcern.AssertArgumentLength(state, 2, 2, Errors.StateInitials))
            {
                State = state;
            }

            if (AssertionConcern.AssertArgumentLength(zipCode, 4, 8, Errors.ZipCodeInvalid))
            {
                ZipCode = zipCode;
            }

            if (AssertionConcern.AssertArgumentLength(complement, 2, 100, Errors.ComplementInvalid))
            {
                Complement = complement;
            }

            if (AssertionConcern.AssertArgumentEmpty(latitude, Errors.LatitudeInvalid))
            {
                Latitude = latitude;
            }

            if (AssertionConcern.AssertArgumentEmpty(longitude, Errors.LongitudeInvalid))
            {
                Longitude = longitude;
            }
        }
        #endregion
    }
}