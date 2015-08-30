using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _64BitArray
{
    public class BitArray64: IEnumerable<int>
    {
        private ulong number;

        public ulong Number
        {
            get { return number; }
            set { number = value; }
        }

        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            bool eqRef = ReferenceEquals(first, second);

            if (eqRef)
                return true;

            return first.Equals(second);

        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !(first == second);
        }

        public int this[int pos]
        {
            get
            {
                if (pos < 0 || pos > 63)
                {
                    throw new ArgumentOutOfRangeException("Index is out of range");
                }

                return (int)((this.number >> pos) & 1);
            }
            set
            {
                if (pos < 0 || pos > 63)
                {
                    throw new ArgumentOutOfRangeException("Index is out of range");
                }
                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Value must be 0 or 1");
                }
                if (value == 1)
                {
                    this.number = this.number | ((ulong)1 << pos);
                }
                else
                {
                    this.number = this.number & (~((ulong)1 << pos));
                }
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this.number.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var objAsNum = obj as BitArray64;

            if (objAsNum == null)
            {
                return false;
            }

            return this.number == objAsNum.number;
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int pos = 0; pos < 64; pos++)
            {
                yield return this[pos];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            for (int i = 0; i < 64; i++)
            {
                if (((this.number >> (63 - i)) & 1) == 1)
                {
                    sb.Append(1);
                }
                else
                {
                    sb.Append(0);
                }
            }

            return sb.ToString();
        }

    }
}
