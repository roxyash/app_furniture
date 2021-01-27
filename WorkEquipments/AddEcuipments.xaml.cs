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
    /// Логика взаимодействия для AddEcuipments.xaml
    /// </summary>
    public partial class AddEcuipments : Window
    {
        private Equipments _currentEquipment = new Equipments();
        public AddEcuipments(Equipments selectedEquipment)
        {
            InitializeComponent();
            if (selectedEquipment != null)
                _currentEquipment = selectedEquipment;
            DataContext = _currentEquipment;
            CBoxTypeEquipment.ItemsSource = OrderfurnituredbEntities.GetContext().TypeEquipment.ToList();
        }

        private void BtnBack(object sender, RoutedEventArgs e)
        {
            WorkEquipments.WorkWithEquipments eq = new WorkEquipments.WorkWithEquipments();
            eq.Visibility = Visibility.Visible;
            this.Close();
        }
        private void BtnSave(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentEquipment.label))
                errors.AppendLine("Укажите маркировку оборудования");
            if (string.IsNullOrWhiteSpace(_currentEquipment.Name))
                errors.AppendLine("Укажите наименование оборудования");
            if (_currentEquipment.TypeEquipment == null)
                errors.AppendLine("Выберите тип оборудования");

            if (TBcharac.Text.Length > 150)
            {
                MessageBox.Show("Количество символов не должно превышать 150 символов ");
                return;
            }
            //if(TBcharac.Text.Length>45)
            //{
            // Сделать проверку если количество символов больше 45 делать перенос строки. 
            //}
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentEquipment.Id == 0)
                OrderfurnituredbEntities.GetContext().Equipments.Add(_currentEquipment);

            try
            {
                OrderfurnituredbEntities.GetContext().SaveChanges();
                MessageBox.Show("Запись успешно сохранена!");
                WorkEquipments.WorkWithEquipments equipmentAccountingWindow = new WorkEquipments.WorkWithEquipments();
                equipmentAccountingWindow.Visibility = Visibility.Visible;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }

        }
    }
}
