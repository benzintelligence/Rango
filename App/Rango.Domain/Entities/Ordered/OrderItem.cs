using Rango.Common.Resources.Errors;
using Rango.Common.Validation;

namespace Rango.Domain.Entities.Ordered
{
    public class OrderItem
    {
        #region Constructor
        public OrderItem(int idOrder, int idProduct, int quantity, int id = 0)
        {
            Validate(id, idOrder, idProduct, quantity);
        }
        #endregion

        #region Properties
        public int Id { get; private set; }

        public int IdOrder { get; private set; }

        public int IdProduct { get; private set; }

        public int Quantity { get; private set; }
        #endregion 

        #region Methods
        public void Validate(int id, int idOrder, int idProduct, int quantity)
        {
            if (id > 0)
            {
                this.Id = id;
            }

            if (AssertionConcern.AssertArgumentGreaterThanZero(idOrder, Errors.OrderInvalid))
            {
                this.IdOrder = idOrder;
            }

            if (AssertionConcern.AssertArgumentGreaterThanZero(idProduct, Errors.ProductInvalid))
            {
                this.IdProduct = idProduct;
            }

            if (AssertionConcern.AssertArgumentGreaterThanZero(quantity, Errors.QuantityInvalid))
            {
                this.Quantity = quantity;
            }
        }
        #endregion
    }
}