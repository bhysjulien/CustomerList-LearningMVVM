using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningMVVM.Models;
using LearningMVVM.PointOfTruthStore;

namespace LearningMVVM.ViewModels
{
    public class CustomerListViewModel : ViewModelBase
    {
        private readonly SelectedClient m_selectedClient;
        private readonly ObservableCollection<CustomerListingItemViewModel> m_customerListingItemViewModels;
        //This is just encapsulating the list of CustomerListingItemViewModels
        public IEnumerable<CustomerListingItemViewModel> CustomerListingItemViewModels => m_customerListingItemViewModels;

        private CustomerListingItemViewModel m_SelectedCustomerListingItemViewModel;

        public CustomerListingItemViewModel SelectedCustomerListingItemViewModel
        {
            get { return m_SelectedCustomerListingItemViewModel; }
            set
            {
                m_SelectedCustomerListingItemViewModel = value; 
                OnPropertyChanged(nameof(SelectedCustomerListingItemViewModel));
                m_selectedClient.SelectedCustomer = m_SelectedCustomerListingItemViewModel?.Customer;
            }
        }
        public CustomerListViewModel(SelectedClient selectedClient)
        {
            m_selectedClient = selectedClient;
            m_customerListingItemViewModels = new ObservableCollection<CustomerListingItemViewModel>
            {
                new CustomerListingItemViewModel(new Customer("MyName", true, false)),
                new CustomerListingItemViewModel(new Customer("JoName", false, false)),
                new CustomerListingItemViewModel(new Customer("John Smith", true, true)),
                new CustomerListingItemViewModel(new Customer("MyName", true, false))
            };
        }
    }

}

