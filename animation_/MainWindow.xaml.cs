using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace animation_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }

      /*  private void button_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation anim = new DoubleAnimation();
            anim.From = 50; // можно не прописывать если задать стартовые значения
            anim.To = 300;
            //anim.By = 200;
            anim.Duration = new Duration(TimeSpan.Parse("0:0:1.5"));
            anim.AutoReverse = true;

            button.BeginAnimation(Button.WidthProperty, anim);
            button.BeginAnimation(Button.HeightProperty, anim);
        }*/
    }
}
