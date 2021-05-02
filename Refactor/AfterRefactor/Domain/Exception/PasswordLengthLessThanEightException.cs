
using Refactor;

namespace AhmadAghazadeh.Shop.CustomerContext.Domain.Customers.Exceptions
{
    public class PasswordLengthLessThanEightException : DomainException
    {
        public override string Message => ExceptionResource.PasswordLengthLessThanEightException;
    }
}