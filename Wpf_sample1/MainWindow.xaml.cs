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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Wpf_sample1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            combxfp.SelectedIndex = 0;
        }

        private void combxfp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Frame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }

        private void Comit_F_Selected(object sender, RoutedEventArgs e)
        {
            Frame.Content = new Page1();
        }

        private void Comit_v_Selected(object sender, RoutedEventArgs e)
        {
            Frame.Content = new Page2();
        }
    }
}
