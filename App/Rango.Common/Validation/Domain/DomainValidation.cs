namespace Rango.Common.Validation
{
    public class DomainValidation
    {
        public DomainValidation(string message)
        {
            Message = message;
        }

        public string Message { get; private set; }
    }
}