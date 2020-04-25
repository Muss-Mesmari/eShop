using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Infrastructure.Rule.Membership
{
    public class MembershipRuleTwoConfiguration : IRule
    {
        private readonly IMembershipRules _membership;

        public MembershipRuleTwoConfiguration(IMembershipRules membership)
        {
            _membership = membership;
        }

        //public MembershipRuleTwoConfiguration()
        //{
        //}

        public bool CompliesWithRule()
        {

            // validate RuleMembershipTwo
            var membershipPurchase = _membership.MembershipRuleTwo;
            membershipPurchase = 0;
            int purchase = 0;
            if (purchase == _membership.MembershipRuleOne)
            {
                return false;
            }
            return true;
         
        }

        public string ErrorMessage => "Purchases is not possible. You do not fulfill rule two!";
    }
}

