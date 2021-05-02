﻿
using Refactor;

namespace AhmadAghazadeh.Shop.CustomerContext.Domain.Customers.Exceptions
{
    public class LastNameRequiredException : DomainException
    {
        public override string Message => ExceptionResource.LastNameRequiredException;
    }

     
}