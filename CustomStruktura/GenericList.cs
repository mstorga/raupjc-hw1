using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStruktura
{
    class GenericList<X> : IGenericList<X>
    {
        private X[] _internalStorage;

        private const int _defaultSize = 4;

        private int _currSize = 0;

        public GenericList()
        {
            _internalStorage = new X[_defaultSize];

        }

        public GenericList(int initSize)
        {
            if (initSize < 0)
            {
                Console.WriteLine("Neispravna veličina");
            }
            else
                _internalStorage = new X[initSize];

        }

        public int Count => _currSize;

        public void Add(X item)
        {
            if (_internalStorage.Length <= _currSize)
            {
                Array.Resize<X>(ref _internalStorage, _internalStorage.Length * 2);
            }
            _internalStorage[_currSize] = item;
            _currSize++;
        }

        public void Clear()
        {
            _currSize = 0;
        }

        public bool Contains(X item)
        {
            if (_internalStorage.Contains<X>(item))
            {
                if (Array.IndexOf(_internalStorage, item) < _currSize)
                    return true;
            }
            return false;
        }

        public X GetElement(int index)
        {
            if (index >= 0 && index < _currSize)
            {
                return _internalStorage[index];
            }
            else
                throw new IndexOutOfRangeException();
        }

        public int IndexOf(X item)
        {
            if (_internalStorage.Contains<X>(item))
            {
                if (Array.IndexOf(_internalStorage, item) < _currSize)
                    return Array.IndexOf(_internalStorage, item);
            }
            throw new Exception();
        }

        public bool Remove(X item)
        {
            if (!_internalStorage.Contains<X>(item))
            {
                return false;
            }
            else if (Array.IndexOf(_internalStorage, item) >= _currSize)
                return false;
            else
                return RemoveAt(Array.IndexOf(_internalStorage, item));
        }

        public bool RemoveAt(int index)
        {
            if (_currSize <= index || index < 0)
                throw new IndexOutOfRangeException();
            for (int i = index; i < _currSize; i++)
            {
                _internalStorage[i] = _internalStorage[i + 1];
            }
            _currSize--;
            return true;
        }
    }
}
