using Police.DBconnection;
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

namespace Police.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListForCriminalPage.xaml
    /// </summary>
    public partial class ListForCriminalPage : Page
    {
        public static List<Aplication> aplications { get; set; }
        public ListForCriminalPage()
        {
            InitializeComponent();
            aplications = Connection.PoliceStation.Aplication.Where(i => i.idCriminal == App.currentUser.id).ToList();
            ListView.ItemsSource = aplications;
            DataContext = this;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            App.currentApp = ListView.SelectedItem as Aplication;
            NavigationService.Navigate(new CriminalPage());
        }
    }
}
