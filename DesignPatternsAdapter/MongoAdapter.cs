using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAdapter
{
    //Esta classe faz uma "adapatção" dos métodos da interface IAdapterDB para ser usado no banco de dados MongoDB
    internal class MongoAdapter : IAdapterDB
    {
        private readonly MongoCommand _command;  
        public MongoAdapter( MongoCommand command)
        {
            this._command = command;
        }

        public string Insert()
        {
           return this._command.MGInsert();
        }

        public string Update()
        {
            return this._command.MGUpdate();
        }

        public string Select()
        {
            return this._command.MGSelect();
        }

        public string Delete()
        {
            return this._command.MGDelete();
        }
    }
}
