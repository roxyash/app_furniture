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
    /// Логика взаимодействия для Director.xaml
    /// </summary>
    public partial class Director : Window
    {
        public Director()
        {
            InitializeComponent();
        }

        private void BackButton(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Visibility = Visibility.Visible;
            this.Close();
        }

        private void ExitProgramm(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void SverProgramm(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Equipments(object sender, RoutedEventArgs e)
        {
            WorkEquipments.WorkWithEquipments eq = new WorkEquipments.WorkWithEquipments();
            eq.Visibility = Visibility.Visible;
            this.Close();
        }

        private void UchetFurniture(object sender, RoutedEventArgs e)
        {
            WorkFurniture.WorkWithFurniture fur  = new WorkFurniture.WorkWithFurniture();
            fur.Visibility = Visibility.Visible;
            this.Close();
        }

        private void UchetMaterial(object sender, RoutedEventArgs e)
        {
            WorkMaterial.WorkWithMaterial mat = new WorkMaterial.WorkWithMaterial();
            mat.Visibility = Visibility.Visible;
            this.Close();
        }
    }
}
