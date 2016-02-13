namespace Rango.Domain.Entities.Order
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        // Produto (Alimento/Comida)
        //     |-->  Ingredientes
    }
}