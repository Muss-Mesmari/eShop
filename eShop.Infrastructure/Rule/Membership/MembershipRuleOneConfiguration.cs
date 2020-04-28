using eShop.Infrastructure.Rule.Membership;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Infrastructure.Rule.Membership
{ 
    public class MembershipRuleOneConfiguration : IRule
    {
        private readonly MembershipRules _membership;

        public MembershipRuleOneConfiguration(IOptions<MembershipRules> options)
        {
            _membership = options.Value;
        }

        //public MembershipRuleOneConfiguration()
        //{
        //}


        public bool CompliesWithRule()
        {
            // validate RuleMembershipOne

            var membershipPurchase = _membership.MembershipRuleOne;
            membershipPurchase = 0;
            int purchase = 0;
            if (purchase == _membership.MembershipRuleOne)
            {
                return true;
            }
            return true;
        }

        public string ErrorMessage => "Purchases is not possible. You do not fulfill rule one!";
    }
}
