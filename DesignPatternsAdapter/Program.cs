using System;

namespace DesignPatternsAdapter
{
    class Program 
    {
        static void Main(string[] args)
        {
            //A interface IAdapterDB esta sendo utilizada pelo objeto sql de uma forma comum (diretamente)
            SQLCommand sql = new SQLCommand();
            string cmSql = sql.Insert();
            Console.WriteLine(cmSql);

            //Neste caso o objeto mongo utiliza a classe MongoAdapter para poder utilizar os metodos da interface IAdapterDB
            MongoAdapter mongo = new MongoAdapter(new MongoCommand());
            string cmMongo = mongo.Insert();
            Console.WriteLine(cmMongo);
            
        }
    }
}
