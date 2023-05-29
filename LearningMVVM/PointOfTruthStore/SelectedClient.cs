using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningMVVM.Models;

namespace LearningMVVM.PointOfTruthStore
{
    public class SelectedClient
    {
        private Customer m_Customer;

        public Customer SelectedCustomer
        {
            get
            {
                return m_Customer;
            }
            set
            {
                m_Customer = value;
                OnSelectedCustomerChanged?.Invoke();
            }
        }
        public event Action OnSelectedCustomerChanged;
    }
}

