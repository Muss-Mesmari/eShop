using eShop.Entities.Entities;
using eShop.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Infrastructure.Rule
{
    public interface IRule
    {
        bool CompliesWithRule();
        string ErrorMessage { get; }
    }

    public interface IScopedRule : IRule
    {
    }

    public interface ISingletonRule : IRule
    {
    }
}
