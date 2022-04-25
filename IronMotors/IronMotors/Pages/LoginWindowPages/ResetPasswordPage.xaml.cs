using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IronMotors.Pages
{
    /// <summary>
    /// Interaction logic for ResetPasswordPage.xaml
    /// </summary>
    public partial class ResetPasswordPage : Page
    {
        public ResetPasswordPage()
        {
            InitializeComponent();
        }

        private void BReset_Click(object sender, RoutedEventArgs e)
        {
            var userEmail = TBEmail.Text;
            var user = App.DB.Client.FirstOrDefault(c => c.Email == userEmail);
            if (user == null)
            {
                MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var newPassword = Membership.GeneratePassword(10, 3);

            //var from = new MailAddress("ashpalitov@yandex.ru", "askar");
            //var to = new MailAddress(userEmail);
            //SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 465);
            //smtp.Credentials = new NetworkCredential("shpalitov222@gmail.com", "koploptoprop222");
            //smtp.EnableSsl = true;
            //var message = new MailMessage(from, to);
            //message.Subject = "Восстановление пароля";
            //message.Body = $"Ваш новый пароль: {newPassword}";
            //smtp.Send(message);

            // ЧЕТ НИХУЯ НЕ ОТПРАВЛЯЕТСЯ
            // МБ НАДО СМТП ПОМЕНЯТЬ
            // ИЛИ ХУЙ ЗАБИТЬ

            SendResetPasswordMessageAsync(userEmail, newPassword).GetAwaiter();
            user.Password = newPassword;
            App.DB.SaveChanges();
            NavigationService.GoBack();

        }

        private async Task SendResetPasswordMessageAsync(string userEmail, string newPassword)
        {
            var from = new MailAddress("ashpalitov@yandex.ru", "askar");
            var to = new MailAddress(userEmail);
            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 25);
            smtp.Credentials = new NetworkCredential("ashpalitov@yandex.ru", "koploptoprop222");
            smtp.EnableSsl = true;
            var message = new MailMessage(from, to);
            message.Subject = "Восстановление пароля";
            message.Body = $"Ваш новый пароль: {newPassword}";
            await smtp.SendMailAsync(message);
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
