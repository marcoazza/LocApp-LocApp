using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocApplication
{
    class DBAccess
    {
        public static void addNewLuogo(string nome) {
            LocApp.Luogo l = new LocApp.Luogo(nome);
            l.luogoToDB();
        }
    }
}
