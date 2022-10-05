using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAdapter
{
    //Comandos do MongoDB
    internal class MongoCommand
    {
        public string MGInsert()
        {
            return "INSERT MONGO";
        }

        public string MGUpdate()
        {
            return "UPDATE MONGO";
        }

        public string MGSelect()
        {
            return "SELECT MONGO";
        }

        public string MGDelete()
        {
            return "DELETE MONGO";
        }
    }
}
