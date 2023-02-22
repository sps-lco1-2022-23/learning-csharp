namespace LinkedList.Lib
{
    public class IntegerLinkedListWithTail
    {
        IntegerNode _head;
        IntegerNode _tail;

        public IntegerLinkedListWithTail()
        {
            _head = null;
            _tail = null;
        }

        public IntegerLinkedListWithTail(int v)
        {
            _head = new IntegerNode(v);
            _tail = _head;
        }

        public  IntegerLinkedListWithTail(IList<int> items) : this() { 
            foreach(int i in items)
                Append(i);
        }

        public int Count => _head == null ? 0 : _head.Count;
        public int Sum => _head == null ? 0 : _head.Sum;

        public void Append(int v)
        {
            if (_head == null) { 
                _head = new IntegerNode(v);
                _tail = _head;
            }
            else {                
                _tail = _tail.Append(v);
            }

        }

        public override string ToString()
        {
            return _head == null ? "{}" : $"{{{_head}}}";
        }
    }
}