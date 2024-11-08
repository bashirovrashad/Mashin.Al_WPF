using MasinAl1.RelayCommands;
using MasinAl1.User_Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MasinAl1.Views.PageViews
{
    /// <summary>
    /// Interaction logic for User_Registr_Page.xaml
    /// </summary>
    public partial class User_Registr_Page : Page
    {
        public int random = 0;
        public string Gmail {  get; set; }  
        public User_Registr_Page()
        {
            InitializeComponent();

        }

        private void back_button(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        private void ireli_button(object sender, RoutedEventArgs e)
        {
            try
            {
                if (textBoxWithPlaceholder.textBox.Text.EndsWith("@gmail.com"))
                {

                    random = Random.Shared.Next(100000, 1000000);
                    send_email("your_email", "your_code", textBoxWithPlaceholder.textBox.Text, "  MASHINAL  ", $"Sizin Qeydiyyat Kodunuz - {random}");
                    User_Registr2_Page user_Registr2_Page = new User_Registr2_Page();
                    user_Registr2_Page.Gmail = textBoxWithPlaceholder.textBox.Text;
                    user_Registr2_Page.random1 = random;
                    NavigationService?.Navigate(user_Registr2_Page);
                }
                else
                {
                    MessageBox.Show("Email Sonu Mutleq @gmail.com ile Bitmelidir!!!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bele Bir Email Yoxdu!!!");

            }
               
               
        }

        private  void send_email(string from_email, string from_password, string to_email, string tittle, string gonder)
        {
            MailMessage mesaj = new MailMessage();
            mesaj.From = new MailAddress(from_email);

            mesaj.Subject = Convert.ToString(tittle);
            mesaj.To.Add(new MailAddress(to_email));
            mesaj.Body = $"<html><body>{gonder}</body></html>";
            mesaj.IsBodyHtml = true;
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(from_email, from_password),
                EnableSsl = true,

            };
            smtpClient.Send(mesaj);

        }

    }
}