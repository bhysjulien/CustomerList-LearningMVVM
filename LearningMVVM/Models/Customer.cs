using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningMVVM.Models
{
    public class Customer
    {
        public string UserName { get;}
        public string IsSubscribedDisplay { get;}
        public string IsMemberDisplay { get;}

        public Customer(string userName, bool isSubscribed, bool isMember)
        {
            UserName = userName;
            IsSubscribedDisplay = isSubscribed.ToString();
            IsMemberDisplay = isMember.ToString();
        }
    }
}
