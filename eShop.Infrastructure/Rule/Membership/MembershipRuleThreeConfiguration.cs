using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Infrastructure.Rule.Membership
{
    public class MembershipRuleThreeConfiguration : IRule
    {
        private readonly IMembershipRules _membership;

        public MembershipRuleThreeConfiguration(IMembershipRules membership)
        {
            _membership = membership;
        }

        //public MembershipRuleThreeConfiguration()
        //{
        //}

        public bool CompliesWithRule()
        {
            // validate RuleMembershipThree
            var membershipPurchase = _membership.MembershipRuleThree;
            membershipPurchase = 0;
            int purchase = 0;
            if (purchase == _membership.MembershipRuleOne)
            {
                return false;
            }
            return false;

        }

        public string ErrorMessage => "Purchases is not possible. You do not fulfill rule Three!";
    }
}

