using System;
using System.Collections;
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
using LocApp;
using LocApplication;

namespace LocApplication.Pages
{
    /// <summary>
    /// Interaction logic for RemoveLuogo.xaml
    /// </summary>
    public partial class RemoveLuogo : Page
    {
        public RemoveLuogo()
        {
            InitializeComponent();
            ArrayList listLuoghi = DBAccess.getLuoghi();
            if(listLuoghi.Count > 0){
                foreach (Luogo l in listLuoghi)
                {
                    LuoghiSalvati.Items.Add(l.NomeLuogo);
                }
            }
            else{

            }
        }
    }
}
