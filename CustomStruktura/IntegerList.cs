using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStruktura
{

    public class IntegerList : IIntegerList
    {
        private int[] _internalStorage;

        private const int _defaultSize = 4;

        private int _currSize = 0;

        int IIntegerList.Count => _currSize;
        public IntegerList()
        {
            _internalStorage = new int[_defaultSize];

        }

        public IntegerList(int initSize)
        {
            if (initSize < 0) {
                Console.WriteLine("Neispravna veličina");
            }
            else
            _internalStorage = new int[initSize];

        }


        public void Add(int item)
        {
            if (_internalStorage.Length <= _currSize)
            {
                Array.Resize<int>(ref _internalStorage, _internalStorage.Length * 2);
            }
            _internalStorage[_currSize] = item;
            _currSize++;  
        }

        public void Clear()
        {
            for (int i = 0; i < _currSize; i++)
                _internalStorage[i] = 0;
            _currSize= 0;
        }

        public bool Contains(int item)
        {
            if (_internalStorage.Contains<int>(item))
            {
                if (Array.IndexOf(_internalStorage, item) < _currSize)
                    return true;
            }
            return false;
        }

        public int GetElement(int index)
        {
            if (index>=0 && index<_currSize)
            {
                return _internalStorage[index];
            } else
                throw new IndexOutOfRangeException();
        }

        public int IndexOf(int item)
        {
            if (_internalStorage.Contains<int>(item))
            {
                if(Array.IndexOf(_internalStorage, item)<_currSize)
                return Array.IndexOf(_internalStorage, item);
            }
            throw new Exception();  
        }

        public bool Remove(int item)
        {
            if (!_internalStorage.Contains<int>(item))
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
            if (_currSize<=index || index<0)
                throw new IndexOutOfRangeException();
            _internalStorage[index] = 0;
            for (int i = index; i < _currSize; i++)
            {
                _internalStorage[i] = _internalStorage[i + 1];
            }
            _currSize--;
            return true;
        }
        // ... IIntegerList implementation ...
    }
}
