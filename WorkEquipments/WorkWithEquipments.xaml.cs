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

namespace OrderFurniture.WorkEquipments
{
    /// <summary>
    /// Логика взаимодействия для WorkWithEquipments.xaml
    /// </summary>
    public partial class WorkWithEquipments : Window
    {
        public WorkWithEquipments()
        {
            InitializeComponent();
        }
        private void BackButton(object sender, RoutedEventArgs e)
        {

            Roles.Director directorWindow = new Roles.Director();
            directorWindow.Visibility = Visibility.Visible;
            this.Close();
        }



        private void AddEquipment(object sender, RoutedEventArgs e)
        {
            WorkEquipments.AddEcuipments ecuipments = new WorkEquipments.AddEcuipments(null); 
            ecuipments.Visibility = Visibility.Visible;
            this.Close();
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                OrderfurnituredbEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridEquipments.ItemsSource = OrderfurnituredbEntities.GetContext().Equipments.ToList();
            }
        }

        private void BtnChange(object sender, RoutedEventArgs e)
        {
            if (DGridEquipments.SelectedItem == null)
            {
                MessageBox.Show("Выберите запись");
                return;
            }
            var std = DGridEquipments.SelectedItem as Equipments;

            WorkEquipments.AddEcuipments ecuipments = new WorkEquipments.AddEcuipments(std); 
            ecuipments.Visibility = Visibility.Visible;
            this.Close();
        }

        private void BtnRemove(object sender, RoutedEventArgs e)
        {
            var equipmentForRemoving = DGridEquipments.SelectedItems.Cast<Equipments>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {equipmentForRemoving.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    OrderfurnituredbEntities.GetContext().Equipments.RemoveRange(equipmentForRemoving);
                    OrderfurnituredbEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данны успешно удалены!");

                    DGridEquipments.ItemsSource = OrderfurnituredbEntities.GetContext().Equipments.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }

        }
        private void UpdateEquipment()
        {
            var currentEquipment = OrderfurnituredbEntities.GetContext().Equipments.ToList();
          
            currentEquipment = currentEquipment.Where(p => p.Name.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();


            DGridEquipments.ItemsSource = currentEquipment.OrderBy(p => p.Name).ToList();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateEquipment();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateEquipment();
        }

        private void ExitProgramm(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void SverProgramm(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
