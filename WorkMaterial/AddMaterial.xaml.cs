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
    /// Логика взаимодействия для AddMaterial.xaml
    /// </summary>
    public partial class AddMaterial : Window
    {
        private Material _currentMaterial = new Material();
        public AddMaterial(Material selectedMaterial)
        {
            InitializeComponent();
            if (selectedMaterial != null)
                _currentMaterial = selectedMaterial;
            DataContext = _currentMaterial;
            CBoxTypeNameSupplier.ItemsSource = OrderfurnituredbEntities.GetContext().Supplier.ToList();
        }

        private void BtnSave(object sender, RoutedEventArgs e)
        {
            var p = OrderfurnituredbEntities.GetContext().Material.Any(l => l.Article == ChekMark.Text);
            if (p == true)
            {
                MessageBox.Show("Артикул уже существует, придумайте другой. ");
                return;
            }
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentMaterial.Article))
                errors.AppendLine("Укажите артикул материала");
            if (string.IsNullOrWhiteSpace(_currentMaterial.Name))
                errors.AppendLine("Укажите наименование материала");




            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            else
            {
                OrderfurnituredbEntities.GetContext().Material.Add(_currentMaterial);
            }


            OrderfurnituredbEntities.GetContext().SaveChanges();
            MessageBox.Show("Запись успешно сохранена!");
            WorkMaterial.WorkWithMaterial mat = new WorkMaterial.WorkWithMaterial();
            mat.Visibility = Visibility.Visible;
            this.Close();

        }

        private void BtnBack(object sender, RoutedEventArgs e)
        {
            WorkMaterial.WorkWithMaterial mat = new WorkMaterial.WorkWithMaterial();
            mat.Visibility = Visibility.Visible;
            this.Close();

        }
    }
}
