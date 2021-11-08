using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceController.Funcionality.Models
{
    class FinanceDictionary : IDictionary<string, decimal>
    {
        public decimal this[string key] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ICollection<string> Keys => throw new NotImplementedException();

        public ICollection<decimal> Values => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(string key, decimal value)
        {
            throw new NotImplementedException();
        }

        public void Add(KeyValuePair<string, decimal> item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(KeyValuePair<string, decimal> item)
        {
            throw new NotImplementedException();
        }

        public bool ContainsKey(string key)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(KeyValuePair<string, decimal>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<string, decimal>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(string key)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<string, decimal> item)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(string key, out decimal value)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
