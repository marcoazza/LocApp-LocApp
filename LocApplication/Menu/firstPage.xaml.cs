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

namespace LocApplication.Menu
{
    /// <summary>
    /// Logica di interazione per firstPage.xaml
    /// </summary>
    public partial class firstPage : UserControl, ISwitchable
    {
        public firstPage()
        {
            InitializeComponent();
        }

        #region ISwitchable
        public void UtilizeState(Object state)
        {
            throw new NotImplementedException();

        }
        #endregion
    }
}
