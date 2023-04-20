using CinemaSessionWPF.ADOApp;
using CinemaSessionWPF.Components;
using CinemaSessionWPF.Properties;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace CinemaSessionWPF.PagesApp
{
    /// <summary>
    /// Interaction logic for AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();

            TbLogin.Text = Settings.Default.LastUser;
        }

        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            /// <summary>
            /// Проверка данных
            /// </summary>
            if (string.IsNullOrWhiteSpace(TbLogin.Text))
                errors.AppendLine("Введите логин");
            if (string.IsNullOrWhiteSpace(TbPassword.Password))
                errors.AppendLine("Введите пароль");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            /// <summary>
            /// Обработка функции "Запомни меня"
            /// </summary>
            if (ChbRemember.IsChecked == true) Settings.Default.LastUser = TbLogin.Text;     
            else Settings.Default.LastUser = "";

            Settings.Default.Save();
                                           
            /// <summary>
            /// Авторизация
            /// </summary>
            var findUser = CinemaSessionEntities
                .GetContext().User
                .Where(x => x.Login == TbLogin.Text)
                .FirstOrDefault();

            if (findUser == null || findUser.Password != TbPassword.Password)
                MessageBox.Show("Не правильный логин или пароль",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                MessageBox.Show("Авторизация прошла успешно!",
                    "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                Manager.MainFrame.Navigate(new MainPage());
            }
        }
    }
}
