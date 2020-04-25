using System.Collections.Generic;

namespace eShop.Infrastructure.Rule
{
    public interface IRuleProcessor
    {
        (bool, IEnumerable<string>) PassesAllRules();
    }
}