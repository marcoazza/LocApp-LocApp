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
using System.Threading;

namespace LocApplication
{
    /// <summary>
    /// Interaction logic for AddLuogo.xaml
    /// </summary>
    public partial class AddLuogo : Page
    {
        public AddLuogo()
        {
            InitializeComponent();
            //load default actions
            //if(ListaAzioniLuogo.Items.IsEmpty)
            ThreadPool.QueueUserWorkItem(Class1.getInstalledSoftware, this.ListaAzioniPredefinite);
            
        }

        private void AggiungiAzioneButton_Click(object sender, RoutedEventArgs e)
        {
            //get selected item from ListaAzioniPredefinite
         Class1.itemApp selectedItem = (Class1.itemApp)  ListaAzioniPredefinite.SelectedItem;
        
            //add item to AzioniLuogo
         ListaAzioniLuogo.Items.Add(new Class1.itemApp { applicazione = selectedItem.applicazione, icon = selectedItem.icon, name = selectedItem.name });
        }

        private void AggiungiLuogoButton_Click(object sender, RoutedEventArgs e)
        {
            String nome = (String) NomeLuogo.Text;
            if (nome == null || nome!="")
            {
                MessageBox.Show("Nome luogo obbligatorio!");
            }
            else {

                DBAccess.addNewLuogo(nome);
              
            }
        }
    }
}
