using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using LearningMVVM.PointOfTruthStore;
using LearningMVVM.ViewModels;

namespace LearningMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly SelectedClient m_SelectedClient;

        public App()
        {
            m_SelectedClient = new SelectedClient();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            //base.OnStartup(e);
            MainWindow = new MainWindow()
            {
                DataContext = new CustomerViewModel(m_SelectedClient)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }

    }
}
