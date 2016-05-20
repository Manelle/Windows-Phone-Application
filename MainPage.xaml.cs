using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneOns.Resources;

namespace PhoneOns
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            if (pswd.Password.ToString() =="") { erreur.Visibility = System.Windows.Visibility.Collapsed; }
        }

        private void BoutonOK_Click(object sender, RoutedEventArgs e)
        {
            if (pswd.Password.ToString().Equals("admin"))
            {   
                NavigationService.Navigate(new Uri("/Page1.xaml?msg" +IDclient, UriKind.Relative));
            }
            else { erreur.Visibility = System.Windows.Visibility.Visible; }
           
        }


       
    }  
}
