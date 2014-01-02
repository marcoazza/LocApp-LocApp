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
using LocApplication;
using LocApp;
using System.Data;
using System.Threading;
namespace LocApplication.Menu
{
    /// <summary>
    /// Logica di interazione per AggiungiLuogo.xaml
    /// </summary>
    public partial class AggiungiLuogo : Page
    {
        public AggiungiLuogo()
        {
            InitializeComponent();
        }


        private void clickAggiungi(object sender, RoutedEventArgs e)
        {
            ThreadPool.QueueUserWorkItem(this.aggiungiLuogo);






        }

        private void aggiungiLuogo(Object stateInfo) {

            Luogo l = new Luogo(nomeLuogo.Text);
            try
            {
                if (nomeLuogo.Text != null)
                {
                    l.luogoToDB();
                    
                }
            }

            catch (ConstraintException ex)
            {



            }
        
        }

    }
}