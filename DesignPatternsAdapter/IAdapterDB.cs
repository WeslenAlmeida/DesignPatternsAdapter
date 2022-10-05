using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAdapter
{
    //Classe de interface com os metodos para ter acesso ao banco de dados
    internal interface IAdapterDB
    {
        public string Insert();
        public string Select();
        public string Update();
        public string Delete();
    }
}
