using OrderFurniture.ModelBD;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.Entity.Validation;

namespace OrderFurniture.Registration
{
    /// <summary>
    /// Логика взаимодействия для SignUP.xaml
    /// </summary>
    public partial class SignUP : Window
    {
        public SignUP()
        {
            InitializeComponent();
        }
        public static bool ValidatePassword(string password)
        {
            if (password.Length < 6 || password.Length > 20)
                return false;
            if (!password.Any(char.IsUpper))
                return false;
            if (!password.Any(char.IsDigit))
                return false;
            if (password.Intersect("!@#$%^").Count() == 0)
                return false;

            return true;
        }


        private void Signup(object sender, RoutedEventArgs e)
        {
            

            var lg = Login.Text;
            var pw = Password.Password;


            
            using (var db = new OrderfurnituredbEntities())
            { 
                StringBuilder errors = new StringBuilder();
                var p = db.Users.Any(l => l.Login == Login.Text);
                
                if (pw.Length < 6 || pw.Length > 20)
                    errors.AppendLine("Длина пароля должна состоять от 6 до 20 символов");
                if (!pw.Any(char.IsUpper))
                    errors.AppendLine("Пароль должен содержать хотя бы одну заглавную букву");
                if (!pw.Any(char.IsDigit))
                    errors.AppendLine("Пароль должен содержать хотя бы одну цифру");
                if (pw.Intersect("!@#$%^").Count() == 0)
                    errors.AppendLine("Пароль должен содержать хотя бы один символ из набора  '!@#$%^'");
                if (String.IsNullOrEmpty(lg))
                    errors.AppendLine("Логин не введен, повторите попытку");
                if (String.IsNullOrEmpty(pw))
                    errors.AppendLine("Пароль не введен, повторите попытку");
                if (Password.Password == RepeatPassword.Password)
                    errors.AppendLine("Пароли не совпадают, повторите попытку!");
                if (p == true)
                    errors.AppendLine("Пользователь с таким логином уже существует, придумайте другой.");
                var imageBuffer = BitmapSourceToByteArray((BitmapSource)Picture.Source);
                if(errors.Length>0)
                {
                    MessageBox.Show(errors.ToString());
                    return;
                }
                else
                {
                    Users user = new Users
                    {
                        Login = Login.Text,
                        Password = Password.Password,
                        FirstName = FirstName.Text,
                        LastName = LastName.Text,
                        MidName = MiddleName.Text,
                        Role = "Заказчик",
                        Picture = imageBuffer
                    };
                    db.Users.Add(user);
                    db.SaveChanges();
                    MessageBox.Show("Аккаунт успешно создан!");
                }
                       
             }

        }
            
          

        private void UploadPicture(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";

            if (openDialog.ShowDialog() != null)
            {
                Picture.Source = new BitmapImage(new Uri(openDialog.FileName));

            }
        }
        private byte[] BitmapSourceToByteArray(BitmapSource image)
        {
            using (var stream = new MemoryStream())
            {
                var encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(image));
                encoder.Save(stream);
                return stream.ToArray();
            }
        }
        private void BackButton(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Visibility = Visibility;
            this.Close();
        }
    }
}
