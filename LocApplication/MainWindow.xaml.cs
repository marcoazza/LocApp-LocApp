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
using NativeWifi;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using LocApplication;
using LocApp;
using LocApplication.Menu;

using System.Drawing;
using System.Threading;


namespace LocApplication
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public static Window win;

        public MainWindow()
        {


            InitializeComponent();
            win = this;
            


            _mainFrame.NavigationService.Navigate("Hello world");
            //_mainFrame.NavigationService.Navigate(new Uri("Menu/AggiungiLuogo.xaml", UriKind.Relative));
            _mainFrame.NavigationService.Navigate(new Uri("AppList.xaml", UriKind.Relative));            
        }




        void HandleClick(object sender, RoutedEventArgs args)
        {
            // Get the element that raised the event. 
            FrameworkElement fe = (FrameworkElement)args.OriginalSource;
            string name4 = fe.Name;
            if (fe.Name == "AddLuogo")
            {
                _mainFrame.NavigationService.Navigate(new Uri("AddLuogo.xaml", UriKind.Relative));

            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           //_mainFrame.NavigationService.Navigate(new Uri("AddLuogo.xaml", UriKind.Relative));
            _mainFrame.NavigationService.Navigate(new Uri("WelcomeLuogo.xaml", UriKind.Relative));
            _menuFrame.NavigationService.Navigate(new Uri("MenuLuogo.xaml", UriKind.Relative));
        }

        public void _mainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }


  

        //private void clickAggiungi(object sender, RoutedEventArgs e)
        //{
           
        //    Luogo l = new Luogo(nomeLuogo.Text);
        //    try
        //    {
        //        l.luogoToDB();
        //    }

        //    catch (ConstraintException ex) {

        //        System.Windows.MessageBox.Show("luogo gia inserito");
        //    }


        //}

        //private void clickDoveSono(object sender, RoutedEventArgs e) {

        //    Luogo l = new Luogo();
            
        //    l.saveNetxList();
        //    Triangolazione t = new Triangolazione(l);
        //    int i = t.triangola();



        //    nomeLuogo.Text = i.ToString();


           
        
        //    Class1.startProcess("C:\\Program Files (x86)\\Skype\\Phone\\Skype.exe");




        
        //}


        //private void getAppList(object sender, RoutedEventArgs e)
        //{

        //    Thread newThread = new Thread(Class1.getInstalledSoftware);
        //    newThread.Start(appList);

            




        //    //Class1.getInstalledSoftware(appList);
            

        //}
 
    }
}
