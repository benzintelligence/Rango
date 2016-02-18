using Rango.Common.Resources.Errors;
using Rango.Common.Validation;

namespace Rango.Domain.Entities
{
     public class User
    {
        #region Constructor
        public User(Email email)
        {
            Email = email;
        } 
        #endregion

        #region Properties
        public int Id { get; private set; }

        public Email Email { get; private set; }

        public string Password { get; private set; }
        #endregion

        #region Methods
        // Method login
        public void SetPassword(string password)
        {
            if (AssertionConcern.AssertArgumentEmpty(password, Errors.InvalidPassword))
            {
                Password = password;
            }
        }
        
        // Method registration
        public void SetPassword(string password, string confirmPassword)
        {
            if (AssertionConcern.AssertArgumentLength(password, 8, 20, Errors.PasswordIntervalCaractere) &&
                AssertionConcern.AssertArgumentEmpty(confirmPassword, Errors.InvalidPasswordConfirmation) &&
                AssertionConcern.AssertArgumentNotEquals(password, confirmPassword, Errors.PasswordDoNotMatch))
            {
                Password = password;
            }
        }
        #endregion
    }
}  