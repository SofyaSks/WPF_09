using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace dataGrid_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IList<Student> students;
        public MainWindow()
        {
            InitializeComponent();

           students = new ObservableCollection<Student>
            {
                new Student () {Name = "Valentin", Grade = 5, Birthday = new DateTime(2000,1,1)},
                new Student () {Name = "Katerina", Grade = 5, Birthday = new DateTime(1999,12,12)},
                new Student () {Name = "Martin", Grade = 4, Birthday = new DateTime(2001,3,3)}
            };

            this.DataContext = students;
            //students.Add(new Student());
        }

        private void DataGrid_AddingNewItem(object sender, AddingNewItemEventArgs e)
        {
            e.NewItem = new Student() { Name = "---", Grade = 3, Birthday = DateTime.Now }; // все новые студенты по умолчанию будут вот такими
        }
    }
}
