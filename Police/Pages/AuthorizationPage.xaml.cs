﻿using System;
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
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
       
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string login = LoginTb.Text.Trim().ToLower();
                string password = PasswordTb.Password.Trim().ToLower();
                App.currentUser = Connection.PoliceStation.User.FirstOrDefault(i => i.login == login && i.password == password);
                if (App.currentUser != null && App.currentUser.idRole == 2)
                {
                    NavigationService.Navigate(new ListForCriminalPage());
                }
                else if (App.currentUser != null && App.currentUser.idRole == 3) 
                {
                    NavigationService.Navigate(new UserPage());
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
