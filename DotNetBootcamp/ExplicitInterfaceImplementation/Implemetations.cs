using System;
using System.Collections;
using System.Collections.Generic;

namespace ExplicitInterfaceImplementation
{
    public class StandardCatalog : ISaveable, IPersistable
    {
        public void Load()
        {
        }

        public string Save()
        {
            return "Catalog Save";
        }
    }

    public class ExplicitCatalog : ISaveable, IPersistable
    {
        public string Save()
        {
            return "Explicit Catalog Save";
        }

        string ISaveable.Save()
        {
            return "ISaveable Save";
        }

        string IPersistable.Save()
        {
            return "IPersistable Save";
        }
    }

    public class Catalog : ISaveable, IVoidSaveable
    {
        //can have only one standard implicit implemetation, but can more that one explicit implemetations
        string ISaveable.Save()
        {
            throw new NotImplementedException();
        }

        void IVoidSaveable.Save()
        {
            throw new NotImplementedException();
        }
    }

    public class EnumerableCatalog : IEnumerable<string>
    {

        public IEnumerator<string> GetEnumerator()
        {
            // all of our code
            return null;
        }

        //IEnumerable<T> inherits IEnumerable - so vs implemented both
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
