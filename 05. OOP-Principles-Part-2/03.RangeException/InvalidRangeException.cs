namespace RangeException
{
    using System;

    class InvalidRangeException<T> : ApplicationException
    {
        //Constructors
        public InvalidRangeException(T rangeStart, T rangeEnd)
            : base()
        {
            this.RangeStart = rangeStart;
            this.RangeEnd = rangeEnd;
        }

        public InvalidRangeException(string message, T rangeStart, T rangeEnd)
            : base(message)
        {
            this.RangeStart = rangeStart;
            this.RangeEnd = rangeEnd;
        }
                
        public InvalidRangeException(string message, Exception inner, T rangeStart, T rangeEnd)
            : base(message, inner)
        {
            this.RangeStart = rangeStart;
            this.RangeEnd = rangeEnd;
        }

        //Properties
        public T RangeStart { get; private set; }
        public T RangeEnd { get; private set; }
    }
}
