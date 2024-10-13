using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public interface IDataStore
    {
        void Save(string data);
    }

    public class _Database : IDataStore
    {
        public void Save(string data)
        { 
            //save to database
        }
    }

    public class _FileStore : IDataStore
    {
        public void Save(string data)
        {
            //save to file
        }
    }

    public class _DataManager
    {
        private IDataStore _store;

        public _DataManager(IDataStore store)
        {
            _store = store;
        }

        public void Save(string data)
        {
            _store.Save(data);
        }
    }
}
