namespace LinkedList.Lib
{
    class IntegerNode
    {
        int _value;
        IntegerNode _next;

        internal int Count => _next == null ? 1 : 1 + _next.Count;

        internal int Sum => _next == null ? _value : _value + _next.Sum;


        internal IntegerNode(int v)
        {
            _value = v;
            _next = null;
        }

        internal void Append(int v)
        {
            if (_next == null)
                _next = new IntegerNode(v);
            else
                _next.Append(v);
        }

        public override string ToString()
        {
            return _next == null ? _value.ToString() : $"{_value}, {_next}";
        }
    }
}