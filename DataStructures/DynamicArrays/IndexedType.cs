using System.Collections;

namespace DataStructures.DynamicArrays
{
    public class IndexedType<T> : IEnumerator<T>
    {
        private T[] store;
        private int position = -1;

        /// <summary>
        /// Returns the length of the internal storage array
        /// </summary>
        public int Length { get { return store.Length; } }

        public IndexedType(int size = 5)
        {
            store = new T[size];
        }

        public T this[int index]
        {
            get 
            {
                try
                {
                    return (T)store[index];
                }
                catch (IndexOutOfRangeException)
                {
                    throw;
                }
            }
            set
            {
                if (index < store.Length) store[index] = value;
                else
                {
                    var copy = (T[])store.Clone();

                    store = new T[index + 1];
                    for (int i = 0; i < copy.Length; i++)
                    {
                        store[i] = copy[i];
                    }

                    store[index] = value;
                }
            }
        }

        public T Current 
        { 
            get 
            {
                try
                {
                    return store[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw;
                }
            }
        }

        object IEnumerator.Current => Current!;

        public void Dispose() {}

        public bool MoveNext()
        {
            position++;
            return position < store.Length;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
