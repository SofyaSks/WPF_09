using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Employee : INotifyPropertyChanged
    {
        private SalaryType salaryType;
        private string name;
        private double payment;

        public event PropertyChangedEventHandler? PropertyChanged;

        
        public SalaryType SalaryType {
            get => salaryType;
            set
            {
                salaryType = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SalaryType)));
            } 
           
        }
        public string Name
        {
            get => name;

            set
            {
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }
            
        public double Payment
        {
            get => payment;
            set
            {
                payment = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Payment)));
            }
        }
        public float Hours { get; set; }

    }
}
