using eShop.Entities.Entities;
using eShop.Infrastructure;
using eShop.Infrastructure.IRepository;
using eShop.Infrastructure.Rule;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Infrastructure.Rule.GeneralRules
{
    public class RuleOne : IPurchaseRule
    {
        public RuleOne()
        {            
        }

        public string ErrorMessage => "You cannot make the purchases because of rule one!";

        public bool CompliesWithRule()
        {         
            return true;
        }
    }
}
