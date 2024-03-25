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
            Aplication application = new Aplication();
            application = Connection.PoliceStation.Aplication.Where(i => i.idCriminal == App.currentUser.id);
            NumAppTb.Text = application.id.ToString();
        }
    }
}
