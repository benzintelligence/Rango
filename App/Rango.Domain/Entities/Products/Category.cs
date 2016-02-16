using Rango.Common.Resources.Errors;
using Rango.Common.Validation;
namespace Rango.Domain.Entities.Products
{
    public class Category
    {

        #region Constructor
        public Category(string title, int Id = 0)
        {
            Validate(title);
        } 
        #endregion

        #region Properties
        public int Id { get; private set; }

        public string Title { get; private set; }
        #endregion

        #region Methods
        public void Validate(string title)
        {
            if (AssertionConcern.AssertArgumentLength(title, 3, 150, Errors.TitleInvalid))
            {
                this.Title = title;
            }
        }
        #endregion
    }
}