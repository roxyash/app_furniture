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

namespace OrderFurniture.Roles
{
    /// <summary>
    /// Логика взаимодействия для Customer.xaml
    /// </summary>
    public partial class Customer : Window
    {
        public Customer()
        {
            InitializeComponent();
        }


        private void UchetFurniture(object sender, RoutedEventArgs e)
        {
            WorkFurniture.WorkWithFurniture fur = new WorkFurniture.WorkWithFurniture();
            fur.Visibility = Visibility.Visible;
            fur.Add.Visibility = Visibility.Collapsed;
            fur.Remove.Visibility = Visibility.Collapsed;
            fur.Change.Visibility = Visibility.Collapsed;
            this.Close();

        }

        private void UchetMaterial(object sender, RoutedEventArgs e)
        {
            WorkMaterial.WorkWithMaterial mat = new WorkMaterial.WorkWithMaterial();
            mat.Visibility = Visibility.Visible;
            mat.Add.Visibility = Visibility.Collapsed;
            mat.Remove.Visibility = Visibility.Collapsed;
            mat.Change.Visibility = Visibility.Collapsed;
            this.Close();

        }

        private void SverProgramm(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ExitProgramm(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void BackButton(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Visibility = Visibility.Visible;
            this.Close();
        }
    }
}
