using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    public class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;

        public T Start
        {
            get { return this.start; }
            private set { this.start = value; }
        }

        public T End
        {
            get { return this.end; }
            private set { this.end = value; }
        }

        public InvalidRangeException(string msg, T start, T end)
            : this(msg, start, end, null)
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(string msg, T start, T end, Exception innerEx)
            : base(msg, innerEx)
        {
            this.Start = start;
            this.End = end;
        }
    }
}
