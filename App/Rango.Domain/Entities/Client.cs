using System.Collections.Generic;

namespace Rango.Domain.Entities
{
    public class Client
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public List<Address> Address { get; set; }


    }
}