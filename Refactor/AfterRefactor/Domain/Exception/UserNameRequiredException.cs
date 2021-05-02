
using Refactor;

namespace AhmadAghazadeh.Shop.CustomerContext.Domain.Customers.Exceptions
{
    public class UserNameRequiredException : DomainException
    {
        public override string Message => ExceptionResource.UserNameRequiredException;
    }

     
}