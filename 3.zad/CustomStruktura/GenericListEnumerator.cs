using System.Collections;
using System.Collections.Generic;

namespace CustomStruktura
{
    internal class GenericListEnumerator<X> : IEnumerator<X>
    {
        private GenericList<X> genericList;
        private int _current = -1;
        private X _currItem;

        public GenericListEnumerator(GenericList<X> genericList)
        {
            this.genericList = genericList;
        }

        public X Current => _currItem;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (_current++ >= genericList.InternalStorage.Length - 1)
            {
                return false;
            }
            else
            {
                _currItem = genericList.InternalStorage[_current];
            }
            return true;
        }

        public void Reset()
        {
            _current = -1;
        }
    }
}