using System.Text.RegularExpressions;
using Rango.Common.Validation.Domain;

namespace Rango.Common.Validation
{
    public class EmailAssertionConcern
    {
        public static bool AssertIsInvalid(string email, string message)
        {
            if (!Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
            {
                DomainValidationManagement.Add(new DomainValidation(message));
                return false;
            }

            return true;
        }
    }
}