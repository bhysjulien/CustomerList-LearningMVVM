using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using LearningMVVM.PointOfTruthStore;

namespace LearningMVVM.ViewModels
{
    public class CustomerViewModel :ViewModelBase
    {
        public CustomerDetailViewModel CustomerDetailViewModel { get;}
        public CustomerListViewModel CustomerListViewModel { get; }
        public ICommand AddCustomerCommand { get;}

        public PointOfTruthStore.SelectedClient PointOfTruthStore { get; }

        public CustomerViewModel(PointOfTruthStore.SelectedClient selectedClient)        {
            CustomerDetailViewModel = new CustomerDetailViewModel(selectedClient);
            CustomerListViewModel = new CustomerListViewModel(selectedClient);
        }
    }
}
