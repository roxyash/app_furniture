using System;
using OrderFurniture.ModelBD;
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

namespace OrderFurniture.WorkMaterial
{
    /// <summary>
    /// Логика взаимодействия для WorkWithMaterial.xaml
    /// </summary>
    public partial class WorkWithMaterial : Window
    {
        public WorkWithMaterial()
        {
            InitializeComponent();
        }

        private void AddMaterial(object sender, RoutedEventArgs e)
        {
            WorkMaterial.AddMaterial add = new WorkMaterial.AddMaterial(null);
            add.Visibility = Visibility.Visible;
            this.Close();

        }

        private void BtnRemove(object sender, RoutedEventArgs e)
        {
            var materialForRemoving = DGridMaterial.SelectedItems.Cast<Material>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {materialForRemoving.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    OrderfurnituredbEntities.GetContext().Material.RemoveRange(materialForRemoving);
                    OrderfurnituredbEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данны успешно удалены!");

                    DGridMaterial.ItemsSource = OrderfurnituredbEntities.GetContext().Material.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtnChange(object sender, RoutedEventArgs e)
        {
            if (DGridMaterial.SelectedItem == null)
            {
                MessageBox.Show("Выберите запись");
                return;
            }
            var std = DGridMaterial.SelectedItem as Material;

            AddMaterial mat = new AddMaterial(std);
            mat.Visibility = Visibility.Visible;
            this.Close();
        }

        private void BackButton(object sender, RoutedEventArgs e)
        {
            if (GlobalBack.role == Role.Director)
            {
                Roles.Director dir = new Roles.Director();
                dir.Visibility = Visibility.Visible;

            }
            if (GlobalBack.role == Role.Customer)
            {
                Roles.Customer cust = new Roles.Customer();
                cust.Visibility = Visibility.Visible;

            }
            if (GlobalBack.role == Role.Master)
            {
                Roles.Master master = new Roles.Master();
                master.Visibility = Visibility.Visible;

            }
            if (GlobalBack.role == Role.Manager)
            {
                Roles.Manager manager = new Roles.Manager();
                manager.Visibility = Visibility.Visible;

            }
            if (GlobalBack.role == Role.ZamDirectora)
            {
                Roles.ZamDirectora zam = new Roles.ZamDirectora();
                zam.Visibility = Visibility.Visible;

            }
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateEquipment();
        }

        private void SverProgramm(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ExitProgramm(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void UpdateEquipment()
        {
            var currentMaterial = OrderfurnituredbEntities.GetContext().Material.ToList();

            currentMaterial = currentMaterial.Where(p => p.Name.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();


            DGridMaterial.ItemsSource = currentMaterial.OrderBy(p => p.Article).ToList();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateEquipment();
        }
        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                OrderfurnituredbEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridMaterial.ItemsSource = OrderfurnituredbEntities.GetContext().Material.ToList();
            }
        }
    }
}
