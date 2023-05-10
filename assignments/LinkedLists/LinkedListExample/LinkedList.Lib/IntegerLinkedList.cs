namespace LinkedList.Lib
{
    public class IntegerLinkedList
    {
        IntegerNode _head;

        public IntegerLinkedList()
        {
            _head = null;
        }

        public IntegerLinkedList(int v)
        {
            _head = new IntegerNode(v);
        }        

        public int Count => _head == null ? 0 : _head.Count;
        public int Sum => _head == null ? 0 : _head.Sum;

        public void Append(int v)
        {
            if (_head == null)
                _head = new IntegerNode(v);
            else
                _head.Append(v);

        }

        public override string ToString()
        {
            return _head == null ? "{}" : $"{{{_head}}}";
        }
    }
}