using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DynamicArrays
{

    public class EnumeratedDataType<T> : IEnumerable<T>
    {
        private List<T>? store = new List<T>();

        public EnumeratedDataType(params T[] parameters)
        {
            foreach (var param in parameters)
            {
                store?.Add(param);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in store!)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
