using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocApp
{
    class Network
    {
        private string _mac;
        private uint _potenza;

        public string Mac {
            get { return _mac; }
            set { _mac = value; }
        }




        public uint Potenza
        {
            get { return _potenza; }
            set { _potenza = value ; }
        }


        public void setNetwork(string mac, uint potenza) { 
            _mac=mac;
            _potenza= potenza;
        }

       




    }
}
