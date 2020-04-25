using eShop.Entities.Entities;
using eShop.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Infrastructure.Rule
{
    public class RuleProcessor : IRuleProcessor
    {
        private readonly IEnumerable<IPurchaseRule> _rules;

        public RuleProcessor(IEnumerable<IPurchaseRule> rules)
        {
            _rules = rules;
        }

        public (bool, IEnumerable<string>) PassesAllRules()
        {
            var passedRules = true;

            var errors = new List<string>();

            foreach (var rule in _rules)
            {
                if (!rule.CompliesWithRule())
                {
                    errors.Add(rule.ErrorMessage);
                    passedRules = false;
                }
            }

            return (passedRules, errors);
        }
    }
}
