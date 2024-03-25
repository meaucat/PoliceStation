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
    /// Логика взаимодействия для CriminalPage.xaml
    /// </summary>
    public partial class CriminalPage : Page
    {
        public CriminalPage()
        {
            InitializeComponent();
            NumAppTb.Text = App.currentApp.id.ToString();
            NameAppTb.Text = App.currentApp.name.ToString();
        }

        private void EnterBt_Click(object sender, RoutedEventArgs e)
        { 
            App.currentApp.alibi = AlibiTb.Text;
            Connection.PoliceStation.SaveChanges();
        }
    }
}
