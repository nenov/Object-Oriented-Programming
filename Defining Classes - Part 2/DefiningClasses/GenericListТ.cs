using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class GenericList<T> where T: IComparable
    {
        private T[] elements;
        private int capacity;
        private int count = 0;

        public GenericList(int capacity)
        {
            this.elements = new T[capacity];
            this.Capacity = capacity;
        }
        public int Capacity
        {
            get { return this.capacity; }
            private set { this.capacity = value; }
        }
        public void Add(T variable)
        {
            if (count >= elements.Length)
            {
                this.DoubleSize();
            }
            this.elements[count] = variable;
            count++;
        }
        public void DoubleSize()
        {
            T[] newArray = new T[this.elements.Length * 2];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = this.elements[i];
            }
            this.elements = newArray;
            this.Capacity *= 2;
        }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                else return elements[index];
            }
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                for (int i = index; i < count - 1; i++)
                {
                    this.elements[i] = this.elements[i + 1];
                }

                this.elements[count - 1] = default(T);
                count--;
            }
        }
        public void InsertAt(int index, T element)
        {
            if (index < 0 || index > count)
            {
                throw new IndexOutOfRangeException();
            }
            if (index == count)
            {
                this.Add(element);
                return;
            }

            if (count >= this.elements.Length - 1)
            {
                this.DoubleSize();
            }

            count++;

            for (int i = count; i > index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }

            this.elements[index] = element;
        }

        public void Clear()
        {
            this.elements = new T[16];
            this.count = 0;
            this.Capacity = 16;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                result.Append(elements[i]);
                if (i < count - 1)
                {
                    result.Append(", ");
                }
            }

            return result.ToString();
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < count; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }
        public T Min()
        {
            T min = this.elements[0];

            for (int i = 0; i < count; i++)
            {
                if (this.elements[i].CompareTo(min) < 0)
                {
                    min = this.elements[i];
                }
            }
            return min;
        }
        public T Max()
        {
            T max = this.elements[0];

            for (int i = 0; i < count; i++)
            {
                if (this.elements[i].CompareTo(max) > 0)
                {
                    max = this.elements[i];
                }
            }
            return max;
        }
    }

}
