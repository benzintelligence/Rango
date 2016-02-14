namespace Rango.Domain.Entities.Order
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int IdPedido { get; set; }

        public int IdProduto { get; set; }

        public int Quantity { get; set; }
    }
}