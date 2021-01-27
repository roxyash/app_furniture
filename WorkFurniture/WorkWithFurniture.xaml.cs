using OrderFurniture.ModelBD;

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

namespace OrderFurniture.WorkFurniture
{
    /// <summary>
    /// Логика взаимодействия для WorkWithFurniture.xaml
    /// </summary>
    public partial class WorkWithFurniture : Window
    {
        public WorkWithFurniture()
        {
            InitializeComponent();
            //DGridFurniture.ItemsSource = OrderfurnituredbEntities.GetContext().Furniture.ToList();
            
        }

        private void AddFurniture(object sender, RoutedEventArgs e)
        {
            WorkFurniture.AddFurniture fur = new AddFurniture(null);
            fur.Visibility = Visibility.Visible;
            this.Close();
        }

        private void BtnRemove(object sender, RoutedEventArgs e)
        {
            var furnitureForRemoving = DGridFurniture.SelectedItems.Cast<Furniture>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {furnitureForRemoving.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    OrderfurnituredbEntities.GetContext().Furniture.RemoveRange(furnitureForRemoving);
                    OrderfurnituredbEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данны успешно удалены!");

                    DGridFurniture.ItemsSource = OrderfurnituredbEntities.GetContext().Furniture.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtnChange(object sender, RoutedEventArgs e)
        {
            if (DGridFurniture.SelectedItem == null)
            {
                MessageBox.Show("Выберите запись");
                return;
            }
            var std = DGridFurniture.SelectedItem as Furniture;

            AddFurniture fur = new AddFurniture(std);
            fur.Visibility = Visibility.Visible;
            this.Close();


        }

        private void BackButton(object sender, RoutedEventArgs e)
        {
           
            if(GlobalBack.role == Role.Director)
            {
                Roles.Director dir = new Roles.Director();
                dir.Visibility = Visibility.Visible;
           
            }
            if(GlobalBack.role == Role.Customer)
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

        private void SverProgramm(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ExitProgramm(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                OrderfurnituredbEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridFurniture.ItemsSource = OrderfurnituredbEntities.GetContext().Furniture.ToList();
            }
        }

        private void UpdateEquipment()
        {
            var currentFurniture = OrderfurnituredbEntities.GetContext().Furniture.ToList();

            currentFurniture = currentFurniture.Where(p => p.Name.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();


            DGridFurniture.ItemsSource = currentFurniture.OrderBy(p => p.Article).ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateEquipment();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateEquipment();
        }
    }
}
