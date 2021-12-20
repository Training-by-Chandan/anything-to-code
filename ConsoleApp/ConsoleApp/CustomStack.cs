using System;

namespace ConsoleApp
{
    public class CustomStack
    {
        private int maxSize = 5;

        public CustomStack()
        {
            maxSize = 5;
            _container = new int[maxSize];
        }

        public CustomStack(int maxSize)
        {
            this.maxSize = maxSize;
            _container = new int[maxSize];
        }

        public int Counter = 0;
        private int[] _container = new int[5];

        public void Push(int i)
        {
            if (Counter < maxSize)
            {
                _container[Counter] = i;
                Counter++;
            }
        }

        public void Pop()
        {
            if (Counter > 0)
            {
                _container[Counter] = 0;
                Counter--;
            }
        }

        public void Peek()
        {
            Console.WriteLine(_container[Counter]);
        }

        public void DisplayAll()
        {
            for (int i = Counter - 1; i >= 0; i--)
            {
                Console.WriteLine(_container[i]);
            }
        }
    }

    public class CustomStackV2
    {
        private int[] _container = new int[0];

        public void Push(int i)
        {
            Array.Resize(ref _container, _container.Length + 1);
            _container[_container.Length - 1] = i;
        }

        public void Pop()
        {
            Array.Resize(ref _container, _container.Length - 1);
        }

        public void Peek()
        {
            Console.WriteLine(_container[_container.Length - 1]);
        }

        public void DisplayAll()
        {
            for (int i = _container.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(_container[i]);
            }
        }
    }

    public class CustomStackV2String
    {
        private string[] _container = new string[0];

        public void Push(string i)
        {
            Array.Resize(ref _container, _container.Length + 1);
            _container[_container.Length - 1] = i;
        }

        public void Pop()
        {
            Array.Resize(ref _container, _container.Length - 1);
        }

        public void Peek()
        {
            Console.WriteLine(_container[_container.Length - 1]);
        }

        public void DisplayAll()
        {
            for (int i = _container.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(_container[i]);
            }
        }
    }

    public class CustomStackV2Double
    {
        private double[] _container = new double[0];

        public void Push(double i)
        {
            Array.Resize(ref _container, _container.Length + 1);
            _container[_container.Length - 1] = i;
        }

        public void Pop()
        {
            Array.Resize(ref _container, _container.Length - 1);
        }

        public void Peek()
        {
            Console.WriteLine(_container[_container.Length - 1]);
        }

        public void DisplayAll()
        {
            for (int i = _container.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(_container[i]);
            }
        }
    }

    public class CustomStackV2Templated<T>
    {
        private T[] _container = new T[0];

        public void Push(T i)
        {
            Array.Resize(ref _container, _container.Length + 1);
            _container[_container.Length - 1] = i;
        }

        public void Pop()
        {
            Array.Resize(ref _container, _container.Length - 1);
        }

        public void Peek()
        {
            Console.WriteLine(_container[_container.Length - 1]);
        }

        public void DisplayAll()
        {
            for (int i = _container.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(_container[i]);
            }
        }
    }
}
