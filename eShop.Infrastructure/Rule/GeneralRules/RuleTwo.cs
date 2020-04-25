using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Infrastructure.Rule.GeneralRules
{
    public class RuleTwo : IRule
    {
        public RuleTwo()
        {
        }

        public string ErrorMessage => "You cannot make the purchases because of rule two!";

        public bool CompliesWithRule()
        {
            return false;
        }
    }
}
