using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class Database
    {
        public void Save(string data)
        { 
            //save to database
        }
    }

    public class DataManager
    {
        private Database db = new Database();

        public void Save(string data)
        {
            db.Save(data);
        }
    }

}
