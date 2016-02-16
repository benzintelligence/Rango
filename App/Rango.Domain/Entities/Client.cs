using Rango.Common.Resources.Errors;
using Rango.Common.Validation;
using System.Collections.Generic;

namespace Rango.Domain.Entities
{
    public class Client
    {


        public Client(string Name, List<Address> Adresses, User user)
        {
            //Ou criar ClientAssertionConcern, imagino que não. #PauloVerificar
            if (AssertionConcern.AssertArgumentLength(Name, 2, 150, Errors.NomeInvalid))
            {
                this.Name = Name;
            }

            if (AssertionConcern.AssertArgumentContainsElement(Adresses, Errors.AddressEmpty))
            {
                this.Addresses = Adresses;
            }

            if (AssertionConcern.AssertArgumentNotNull(user, Errors.UserEmpty))
            {
                this.User = User;
            }
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public List<Address> Addresses { get; set; } 

        public User User { get; set; }


    }
}