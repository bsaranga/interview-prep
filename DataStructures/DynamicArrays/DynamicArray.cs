using System.Collections;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DataStructures_Tests")]
namespace DataStructures.DynamicArrays
{
    public class DynamicArray<T> : IEnumerator<T>
    {
        private T[] store;
        private int position = 0;

        /// <summary>
        /// Returns the length of the internal storage array
        /// </summary>
        public int Length { get { return store.Length; } }

        /// <summary>
        /// Initialize a dynamic array with set size
        /// </summary>
        /// <param name="size">Size of array</param>
        public DynamicArray(int size = 1)
        {
            if (size < 0) throw new ArgumentOutOfRangeException("size");
            store = new T[size];
        }

        public DynamicArray(params T[] list)
        {
            store = list;
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

        internal void ExtendStore(int amount = 1)
        {
            var copy = (T[]) store.Clone();
            store = new T[store.Length + amount];
            CopyElements(copy, ref store);
        }

        internal void CopyElements(T[] oldCopy, ref T[] newArray)
        {
            for (int i = 0; i < oldCopy.Length; i++)
            {
                newArray[i] = oldCopy[i];
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
            position = 0;
        }
    }
}
