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
    /// Логика взаимодействия для AddFurniture.xaml
    /// </summary>
    public partial class AddFurniture : Window
    {
        private Furniture _currentFurniture = new Furniture();
        public AddFurniture(Furniture selectedFurniture)
        {
            InitializeComponent();
            if (selectedFurniture != null)
                _currentFurniture = selectedFurniture;
            DataContext = _currentFurniture;
            CBoxTypeNameSupplier.ItemsSource = OrderfurnituredbEntities.GetContext().Supplier.ToList();

        }


        private void BtnBack(object sender, RoutedEventArgs e)
        {
            WorkFurniture.WorkWithFurniture eq = new WorkFurniture.WorkWithFurniture();
            eq.Visibility = Visibility.Visible;
            this.Close();
        }
        private void BtnSave(object sender, RoutedEventArgs e)
        {

            var p = OrderfurnituredbEntities.GetContext().Furniture.Any(l => l.Article == ChekMark.Text);
            if (p == true)
            {
                MessageBox.Show("Артикул уже существует, придумайте другой. ");
                return;
            }
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentFurniture.Article))
                errors.AppendLine("Укажите артикул фурнитуры");
            if (string.IsNullOrWhiteSpace(_currentFurniture.Name))
                errors.AppendLine("Укажите наименование фурнитуры");
       



            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            else
            {
                OrderfurnituredbEntities.GetContext().Furniture.Add(_currentFurniture);
            }
          
               
                OrderfurnituredbEntities.GetContext().SaveChanges();
                MessageBox.Show("Запись успешно сохранена!");
                WorkFurniture.WorkWithFurniture fur = new WorkFurniture.WorkWithFurniture();
                fur.Visibility = Visibility.Visible;
                this.Close();

        }

    }
}
