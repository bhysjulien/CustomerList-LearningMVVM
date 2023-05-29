using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using LearningMVVM.Models;

namespace LearningMVVM.ViewModels
{
    public class CustomerListingItemViewModel : ViewModelBase
    {
        public Customer Customer { get; }
        public string UserName => Customer.UserName;

        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get;}

        public CustomerListingItemViewModel(Customer customer)
        {
            Customer = customer;
        }
    }
}
