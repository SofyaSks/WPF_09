using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Company
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        private Visibility hoursVisibility;
        private FontStyle newName;
        private Brush paymentAmount;

        public Employee Employee { get; }

        public EmployeeViewModel(Employee employee)
        {
            Employee = employee;
            Employee.PropertyChanged += Employee_PropertyChanged;
            ShowHideHours();
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void Employee_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Employee.SalaryType))
            {
                ShowHideHours();
            }   

            if (e.PropertyName == nameof(Employee.Name))
            {
                if (Employee.Name != "")
                    FontStyleName = FontStyles.Oblique;
            }
            
            if (e.PropertyName == nameof(Employee.Payment))
            {
                if (Employee.Payment <= 1000)
                    SalaryBrush = Brushes.Red;
                if (Employee.Payment > 1000 && Employee.Payment <= 10000)
                    SalaryBrush = Brushes.Yellow;
                if (Employee.Payment > 10000 && Employee.Payment <= 100000)
                    SalaryBrush = Brushes.Green;
                if (Employee.Payment > 100000)
                    SalaryBrush = Brushes.Cyan;
            }
            
        }

        private void ShowHideHours()
        {
            if (Employee.SalaryType == SalaryType.Hourly)
                HoursVisibility = Visibility.Visible;
            else
                HoursVisibility = Visibility.Collapsed;
        }

        public SalaryType[] SalaryTypes { get; } = (SalaryType[])Enum.GetValues(typeof(SalaryType));

        public Visibility HoursVisibility { get => hoursVisibility; set
            {
                hoursVisibility = value;
                
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HoursVisibility)));

            }       
        }

        public FontStyle FontStyleName
        {
            get => newName;
            set
            {
                newName = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FontStyleName)));
            }
        }

        public Brush SalaryBrush
        {
            get => paymentAmount;
            set
            {
                paymentAmount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SalaryBrush)));
            }
        }
    }
}
