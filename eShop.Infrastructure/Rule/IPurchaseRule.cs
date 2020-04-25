using eShop.Entities.Entities;
using eShop.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Infrastructure.Rule
{
    public interface IPurchaseRule
    {
        bool CompliesWithRule();
        string ErrorMessage { get; }
    }

    //public interface IScopedPurchaseRule : IPurchaseRule
    //{
    //}

    //public interface ISingletonPurchaseRule : IPurchaseRule
    //{
    //}
}
