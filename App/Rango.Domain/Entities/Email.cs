using System.CodeDom;
using Rango.Common.Resources.Errors;
using Rango.Common.Validation;

namespace Rango.Domain.Entities
{
    public class Email
    {
        public Email(string eletronicEmail)
        {
            if (EmailAssertionConcern.AssertIsInvalid(eletronicEmail, Errors.EmailInvalid))
            {
                ElectronicMail = eletronicEmail;
            }
        }

        public int Id { get; private set; }

        public string ElectronicMail { get; private set; }
    }
}