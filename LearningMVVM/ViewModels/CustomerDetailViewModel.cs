using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningMVVM.Models;
using LearningMVVM.PointOfTruthStore;

namespace LearningMVVM.ViewModels
{
    /**
   * This class represents the view model for details of a customer.
   * Contains properties related to the currently selected customer.
   */
    public class CustomerDetailViewModel : ViewModelBase
    {
        // Properties    
        public string UserName => m_Customer?.UserName ?? "Unkown";
        public string IsSubscribedDisplay => m_Customer?.IsSubscribedDisplay ?? "False";
        public string IsMemberDisplay => m_Customer?.IsMemberDisplay ?? "False";

        // Fields
        private SelectedClient m_SelectedClient; // Instance of SelectedClient class.
        private Customer m_Customer => m_SelectedClient.SelectedCustomer; // Currently selected customer.

        // Constructor
        public CustomerDetailViewModel(SelectedClient selectedClient)
        {
            m_SelectedClient = selectedClient;
            m_SelectedClient.OnSelectedCustomerChanged += M_SelectedClient_OnSelectedCustomerChanged;
        }

        // Event handler for selected customer change
        private void M_SelectedClient_OnSelectedCustomerChanged()
        {
            OnPropertyChanged(nameof(UserName));
            OnPropertyChanged(nameof(IsSubscribedDisplay));
            OnPropertyChanged(nameof(IsMemberDisplay));
        }
    }

}
