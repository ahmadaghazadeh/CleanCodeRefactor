
using Refactor;

namespace AhmadAghazadeh.Shop.CustomerContext.Domain.Customers.Exceptions
{
    public class PasswordInvalidFormatException : DomainException
    {
        public override string Message => ExceptionResource.PasswordInvalidFormatException;
    }
}