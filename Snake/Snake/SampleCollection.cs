using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class SampleCollection<T>
    {
        private T[] array;

        public SampleCollection()
        {
            array = new T[0];
        }

        public void Add(T elem)
        {
            T[] _array = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++) _array[i] = array[i];
            _array[array.Length] = elem;
            array = _array;
        }

        public void RemoveAt(int index)
        {
            T[] _array = new T[array.Length - 1];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
                if (i != index) 
                {
                    _array[k] = array[i]; 
                    k++; 
                }
            array = _array;
        }

        public T this [int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public int Count { get { return array.Length; } }
    }
}
