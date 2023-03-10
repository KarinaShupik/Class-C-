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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Lab_16
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_res_Click(object sender, RoutedEventArgs e)
        {
            string user_name = txt1.Text;//найменування адресата
            string phone_num = txt2.Text; //номер мобільного
            string street_name = txt3.Text;//найменування вулиці
            string house_num = txt4.Text;//номер будинку
            string flat_num = txt5.Text;//номер квартири
            string email = txt6.Text;//почта
            string location_name = txt7.Text;//найменування населеного пункту
            string region_name = txt8.Text;//найменування району
            string area_name = txt9.Text;//найменування області
            string country_name = txt10.Text;//країна призначення
            string index = txt11.Text;//країна призначення

           
            //для перевірки кількості символів у текстовому полі індексу
            if (index.Length == 5 && int.TryParse(index, out int number1))
            {
                index = txt11.Text;
            }
            else
            {
                index = "Error";
            }

            //для перевірки кількості символів у текстовому полі мобільного телефону
            if (phone_num.Length == 10 && int.TryParse(phone_num, out int number2))
            {
                phone_num = txt2.Text;
            }
            else
            {
                phone_num = "Error";
            }

            Address user = new Address(user_name, phone_num, street_name, house_num, flat_num, email, location_name, region_name, area_name, country_name, index);
            user.Print();

        }
    }
}
