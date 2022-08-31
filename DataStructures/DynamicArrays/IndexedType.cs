using System.Collections;

namespace DataStructures.DynamicArrays
{
    public class IndexedType<T> : IEnumerator<T>
    {
        private T[] store;

        public IndexedType(int size = 5)
        {
             store = new T[size];
        }

        public T this[int index]
        { 
            get { return (T) new object(); }
            set 
            { 
                if (index < store.Length) store[index] = value;
                else
                {
                    var copy = (T[]) store.Clone();

                    store = new T[index + 1];
                    for (int i = 0; i < copy.Length; i++)
                    {
                        store[i] = copy[i];
                    }
                }
            }
        }

        public T Current => throw new NotImplementedException();

        object IEnumerator.Current => Current!;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
