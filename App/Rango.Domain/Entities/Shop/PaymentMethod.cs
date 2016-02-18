using Rango.Common.Resources.Errors;
using Rango.Common.Validation;
namespace Rango.Domain.Entities.Shop
{
    public class PaymentMethod
    {

        #region Constructor
        public PaymentMethod(string PaymentMethodName, string ImageCardUrl, int id = 0)
        {
            Validate(id, PaymentMethodName, ImageCardUrl);
        }
        #endregion

        #region properties
        public int Id { get; set; }

        public string PaymentMethodName { get; set; }

        public string ImageCardUrl { get; set; }
        #endregion

        #region Methods
        public void Validate(int Id, string PaymentMethodName, string ImageCardUrl)
        {
            if (Id > 0)
            {
                this.Id = Id;
            }

            if (AssertionConcern.AssertArgumentLength(PaymentMethodName, 0, 255, Errors.PaymentMethodNameInvalid))
            {
                this.PaymentMethodName = PaymentMethodName;
            }

            if (AssertionConcern.AssertArgumentNotNull(ImageCardUrl, Errors.ImageCardUrlInvalid))
            {
                this.ImageCardUrl = ImageCardUrl;
            }
        }
        #endregion

    }
}