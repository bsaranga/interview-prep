using System.Collections;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DataStructures_Tests")]
namespace DataStructures.DynamicArrays
{
    public class DynamicArray<T> : IEnumerator<T>, IEnumerable<T>
    {
        private T[] store;
        private int position = -1;

        /// <summary>
        /// Returns the length of the internal storage array
        /// </summary>
        public int Length { get { return store.Length; } }

        /// <summary>
        /// Initializes dynamic array with an array of type T
        /// </summary>
        /// <param name="arrayOfT">Array of type T</param>
        public DynamicArray(params T[] arrayOfT)
        {
            if (arrayOfT == null)
            {
                store = new T[] { };
            }
            else
            {
                store = arrayOfT;
                position = arrayOfT.Length - 1;
            }
        }

        /// <summary>
        /// Adds new elements into the store
        /// </summary>
        /// <param name="items">Items of T to be added</param>
        public void Add(params T[] items)
        {
            ExtendStore(items.Length);
            for (int i = 0; i < items.Length; i++)
            {
                MoveNext();
                store[position] = items[i];
            }
        }

        public void Remove(int index)
        {
            var left = new T[index];
            var right = new T[Length - 1 - index];
            
            for (int i = 0; i < index; i++)
            {
                left[i] = store[i];
            }

            for (int i = 0; i < Length - 1 - index; i++)
            {
                right[i] = store[index + i + 1];
            }

            store = left.Concat(right).ToArray();
            position--;
        }

        /// <summary>
        /// Get value at index, or set value at index
        /// </summary>
        /// <param name="index">Index number</param>
        /// <returns>Value at index</returns>
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

                    CopyElements(copy, store);

                    store[index] = value;
                }
            }
        }

        /// <summary>
        /// Get's the current value the iterator is pointing
        /// </summary>
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

        public bool MoveNext()
        {
            position++;
            return position < store.Length;
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose() { }

        internal void ExtendStore(int amount = 1)
        {
            if (amount <= 0) throw new NullStoreExtensionException();

            var copy = (T[])store.Clone();
            store = new T[store.Length + amount];
            CopyElements(copy, store);
        }

        internal void CopyElements(T[] oldCopy, T[] newArray)
        {
            for (int i = 0; i < oldCopy.Length; i++)
            {
                newArray[i] = oldCopy[i];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return store[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class NullStoreExtensionException : Exception
    {
        private const string DEFAULT_MSG = "Cannot extend the internal store by 0 or less";
        public NullStoreExtensionException(string? message = DEFAULT_MSG) : base(message)
        {

        }
    }
}
