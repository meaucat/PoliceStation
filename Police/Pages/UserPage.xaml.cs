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
using Police.DBconnection;
namespace Police.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        public UserPage()
        {
            InitializeComponent();
            List<Gender> genders = Connection.PoliceStation.Gender.ToList();
            GenderCb.ItemsSource = genders;
            DataContext = this;
        }
        Aplication aplication = new Aplication();
        private void EnterBt_Click(object sender, RoutedEventArgs e)
        {
            aplication.name = nameTb.Text.Trim();
            aplication.weight = int.Parse(weightTb.Text.Trim());
            aplication.height = int.Parse(heightTb.Text.Trim());
            aplication.age = int.Parse(AgeTb.Text.Trim());
            aplication.description = DescripTb.Text.Trim();
            Connection.PoliceStation.Aplication.Add(aplication);
            Connection.PoliceStation.SaveChanges();

        }

        private void GenderCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            aplication.idGender = (GenderCb.SelectedItem as Gender).id;
        }
    }
}
