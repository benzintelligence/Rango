using Rango.Common.Resources.Errors;
using Rango.Common.Validation;
using System.Collections.Generic;

namespace Rango.Domain.Entities
{
    public class Client
    {
        #region Constructor
        public Client(string name, List<Address> addresses, User user)
        {
            Validate(name, addresses, user);
        } 
        #endregion

        #region Properties
        public int Id { get; private set; }

        public string Name { get; private set; }

        public List<Address> Addresses { get; private set; }

        public User User { get; private set; }
        #endregion

        #region Methods
        public void Validate(string name, List<Address> addresses, User user)
        {
            if (AssertionConcern.AssertArgumentLength(name, 3, 150, Errors.NomeInvalid))
            {
                this.Name = Name;
            }

            if (AssertionConcern.AssertArgumentContainsElement<Address>(addresses, Errors.AddressEmpty))
            {
                this.Addresses = Addresses;
            }

            if (AssertionConcern.AssertArgumentNotNull(user, Errors.UserEmpty))
            {
                this.User = User;
            }
        } 
        #endregion
    }
}