using System.Windows.Input;


namespace LearningMVVM.ViewModels
{
    // Represents the viewmodel for the customer view
    public class CustomerViewModel : ViewModelBase
    {
        // Properties for the customerdetailviewmodel and customerlistviewmodel
        public CustomerDetailViewModel CustomerDetailViewModel { get; }
        public CustomerListViewModel CustomerListViewModel { get; }
        public ICommand AddCustomerCommand { get; }

        // Property for selected client
        public PointOfTruthStore.SelectedClient PointOfTruthStore { get; }

        // Constructor for customer viewmodel
        public CustomerViewModel(PointOfTruthStore.SelectedClient selectedClient)
        {
            // Instantiate the customerdetailviewmodel and customerlistviewmodel
            CustomerDetailViewModel = new CustomerDetailViewModel(selectedClient);
            CustomerListViewModel = new CustomerListViewModel(selectedClient);
        }
    }
}