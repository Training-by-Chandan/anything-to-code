using System;

namespace ConsoleApp
{
    public class CustomQueue
    {
        public CustomQueue()
        {
            _container = new int[size];
        }

        public CustomQueue(int size)
        {
            this.size = size;
            _container = new int[size];
        }

        private int size = 5;
        private int _counter = 0;
        private int[] _container;

        public void Enqueue(int i)
        {
            if (_counter < size)
            {
                _container[_counter] = i;
                _counter++;
            }
        }

        public void Dequeue()
        {
            for (int i = 0; i < _counter - 1; i++)
            {
                _container[i] = _container[i + 1];
            }
            _container[_counter - 1] = 0;
            _counter--;
        }

        public void DisplayAll()
        {
            for (int i = 0; i < _counter; i++)
            {
                Console.WriteLine(_container[i]);
            }
        }
    }

    public class CustomQueueInfinite
    {
        private int[] _container = new int[0];

        public void Enqueue(int i)
        {
            Array.Resize(ref _container, _container.Length + 1);
            _container[_container.Length - 1] = i;
        }

        public void Dequeue()
        {
            for (int i = 0; i < _container.Length - 1; i++)
            {
                _container[i] = _container[i + 1];
            }
            Array.Resize(ref _container, _container.Length - 1);
        }

        public void DisplayAll()
        {
            for (int i = 0; i < _container.Length; i++)
            {
                Console.WriteLine(_container[i]);
            }
        }
    }

    public class CustomQueueInfiniteTemplated<T>
    {
        private T[] _container = new T[0];

        public void Enqueue(T i)
        {
            Array.Resize(ref _container, _container.Length + 1);
            _container[_container.Length - 1] = i;
        }

        public void Dequeue()
        {
            for (int i = 0; i < _container.Length - 1; i++)
            {
                _container[i] = _container[i + 1];
            }
            Array.Resize(ref _container, _container.Length - 1);
        }

        public void DisplayAll()
        {
            for (int i = 0; i < _container.Length; i++)
            {
                Console.WriteLine(_container[i]);
            }
        }
    }
}
