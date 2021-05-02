
using Refactor;

namespace AhmadAghazadeh.Shop.CustomerContext.Domain.Customers.Exceptions
{
    public class PasswordRequiredException : DomainException
    {
        public override string Message => ExceptionResource.PasswordRequiredException;
    }
}