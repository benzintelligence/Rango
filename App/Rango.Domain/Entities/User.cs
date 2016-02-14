namespace Rango.Domain.Entities
{
    public class User
    {
        public User()
        {
            
        }

        public int Id { get; private set; }

        public Email Email { get; private set; }

        public string Password { get; private set; }
    }
}