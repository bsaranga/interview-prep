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

        /// <summary>
        /// Initializes dynamic array with an array of type T
        /// </summary>
        /// <param name="arrayOfT">Array of type T</param>
        public DynamicArray(params T[] arrayOfT)
        {
            store = arrayOfT;
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

                    CopyElements(copy, store);

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

        public bool MoveNext()
        {
            position++;
            return position < store.Length;
        }

        public void Reset()
        {
            position = 0;
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
    }

    public class NullStoreExtensionException : Exception
    {
        private const string DEFAULT_MSG = "Cannot extend the internal store by 0 or less";
        public NullStoreExtensionException(string? message = DEFAULT_MSG) : base(message)
        {

        }
    }
}
