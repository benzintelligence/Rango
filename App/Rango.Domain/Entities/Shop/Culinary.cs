using Rango.Common.Resources.Errors;
using Rango.Common.Validation;
namespace Rango.Domain.Entities.Shop
{
    public class Culinary
    {

        #region construct
        public Culinary(string title, int idCulinary = 0)
        {
            Validate(idCulinary, title);
        }
        #endregion

        #region properties
        public int IdCulinary { get; private set; }

        public string Title { get; private set; }
        #endregion

        #region Methods
        public void Validate(int idCulinary, string title)
        {
            if (idCulinary > 0)
            {
                this.IdCulinary = idCulinary;
            }

            if (AssertionConcern.AssertArgumentLength(title, 3, 150, Errors.CulinaryInvalid))
            {
                this.Title = title;
            }
        }
        #endregion

    }
}