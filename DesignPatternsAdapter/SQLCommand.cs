using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAdapter
{
    //Comandos para o banco de dados SQL
    internal class SQLCommand : IAdapterDB
    {
        public string Insert()
        {
            return "INSERT SQL";
        }

        public string Update()
        {
            return "UPDATE SQL";
        }

        public string Select()
        {
            return "SELECT SQL";
        }

        public string Delete()
        {
            return "DELETE SQL";
        }
    }
}
