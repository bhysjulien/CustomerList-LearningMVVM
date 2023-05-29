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
    public class CustomerDetailViewModel : ViewModelBase
    {


        public string UserName => m_Customer?.UserName ?? "Unkown";
        public string IsSubscribedDisplay => m_Customer?.IsSubscribedDisplay ?? "False";
        public string IsMemberDisplay => m_Customer?.IsMemberDisplay ?? "False";

        private SelectedClient m_SelectedClient;
        private Customer m_Customer => m_SelectedClient.SelectedCustomer;

        public CustomerDetailViewModel(SelectedClient selectedClient)
        {
            m_SelectedClient = selectedClient;
            m_SelectedClient.OnSelectedCustomerChanged += M_SelectedClient_OnSelectedCustomerChanged;
        }

        private void M_SelectedClient_OnSelectedCustomerChanged()
        {
            OnPropertyChanged(nameof(UserName));
            OnPropertyChanged(nameof(IsSubscribedDisplay));
            OnPropertyChanged(nameof(IsMemberDisplay));
        }
    }
}
