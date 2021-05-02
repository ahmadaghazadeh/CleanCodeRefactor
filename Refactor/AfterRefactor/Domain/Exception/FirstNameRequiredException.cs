
using Refactor;

namespace AhmadAghazadeh.Shop.CustomerContext.Domain.Customers.Exceptions
{
    public class FirstNameRequiredException : DomainException
    {
        public override string Message => ExceptionResource.FirstNameRequiredException;
    }
}