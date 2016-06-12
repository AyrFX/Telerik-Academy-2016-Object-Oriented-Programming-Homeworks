namespace GenericDemo
{
    using System;

    public class GenericList<T>
    {
        private T[] values;
        private int lastIndex;
        private const int InitialSize = 4;

        public GenericList()
        {
            values = new T[InitialSize];
            lastIndex = -1;
        }

        private void ResizeValuesArray()
        {
            if (this.lastIndex == this.values.Length - 1)
            {
                T[] newArray = new T[this.values.Length * 2];
                this.values.CopyTo(newArray, 0);
                this.values = newArray;
            }
        }

        private void CheckIndex(int index)
        {
            if (0 > index || index > this.values.Length - 1)
            {
                throw new IndexOutOfRangeException("Given index is out of the range of the list!");
            }
        }

        public void AddItem(T value)
        {
            ResizeValuesArray();
            this.lastIndex++;
            this.values[lastIndex] = value;
        }

        public T GetElement(int index)
        {
            CheckIndex(index);
            return this.values[index];
        }

        public void RemoveElement(int index)
        {
            CheckIndex(index);
            T[] newArray = new T[this.values.Length];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = this.values[i];
            }

            for (int i = index+1; i < this.values.Length; i++)
            {
                newArray[i-1] = this.values[i];
            }
            this.values = newArray;
            lastIndex--;
        }

        public void InsertElement(T value, int index)
        {
            CheckIndex(index);
            ResizeValuesArray();
            T[] newArray = new T[this.values.Length];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = this.values[i];
            }
            newArray[index] = value;
            for (int i = index+1; i < this.values.Length; i++)
            {
                newArray[i] = this.values[i - 1];
            }
            this.values = newArray;
            lastIndex++;
        }

        public void ClearList()
        {
            T[] newArray = new T[InitialSize];
            this.values = newArray;
            lastIndex = -1;
        }

        public int GetIndex(T value)
        {
            for (int i = 0; i < this.values.Length; i++)
            {
                if (value.Equals(this.values[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public override string ToString()
        {
            string result = string.Empty;
            for (int i = 0; i <= this.lastIndex; i++)
            {
                result += this.values[i];
                if (i != this.lastIndex)
                {
                    result += ", ";
                }
            }
            return result;
        }
    }
}
