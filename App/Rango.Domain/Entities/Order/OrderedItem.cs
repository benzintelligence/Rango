﻿namespace Rango.Domain.Entities.Order
{
    public class OrderedItem
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        // Produto (Alimento/Comida)
        //     |-->  Ingredientes
    }
}