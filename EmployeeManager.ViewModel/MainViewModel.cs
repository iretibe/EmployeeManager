using EmployeeManager.Common.DataProvider;
using EmployeeManager.Common.Model;
using System;
using System.Collections.ObjectModel;

namespace EmployeeManager.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private EmployeeViewModel _selectedEmployee;
        private readonly IEmployeeDataProvider _employeeDataProvider;

        public MainViewModel(IEmployeeDataProvider employeeDataProvider)
        {
            _employeeDataProvider = employeeDataProvider;
        }

        public ObservableCollection<EmployeeViewModel> Employees { get; } = new();
        public ObservableCollection<JobRole> JobRoles { get; } = new();
                
        public EmployeeViewModel SelectedEmployee
        {
            get => _selectedEmployee; 
            set 
            {
                if (_selectedEmployee != value)
                {
                    _selectedEmployee = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(IsEmployeeSelected));
                }                
            }
        }

        public bool IsEmployeeSelected => SelectedEmployee != null;

        public void Load()
        {
            var employees = _employeeDataProvider.LoadEmployees();
            var jobRoles = _employeeDataProvider.LoadJobRoles();

            Employees.Clear();

            foreach (var item1 in employees)
            {
                Employees.Add(new EmployeeViewModel(item1, _employeeDataProvider));
            }

            JobRoles.Clear();

            foreach (var item2 in jobRoles)
            {
                JobRoles.Add(item2);
            }
        }

        public static string SayHello(string name)
        {
            Console.WriteLine(name);

            return $"Hello {name!}";
        }
    }
}
