using Rango.Common.Resources.Errors;
using Rango.Common.Validation;

namespace Rango.Domain.Entities
{
    public class Email
    {
        #region Constructor
        public Email(string eletronicEmail, int id = 0)
        {
            Validate(id, eletronicEmail);
        }
        #endregion

        #region Properties
        public int Id { get; private set; }

        public string ElectronicMail { get; private set; } 
        #endregion

        #region Methods
        public void Validate(int id, string eletronicEmail)
        {
            if (id != 0)
            {
                Id = id;
            }

            if (EmailAssertionConcern.AssertIsInvalid(eletronicEmail, Errors.EmailInvalid))
            {
                ElectronicMail = eletronicEmail;
            }
        } 
        #endregion
    }
}