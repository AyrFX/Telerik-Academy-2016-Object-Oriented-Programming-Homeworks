namespace SixtyFourBitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    class SixtyFourBitArray : IEnumerable<int>
    {
        //Properties
        public ulong Number { get; set; }

        //Indexer
        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("Given index is out of the range of the array!");
                }
                return (int)((this.Number >> index) & 1);
            }
            set
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException();
                }

                if (value < 0 || value > 1)
                {
                    throw new ArgumentException();
                }

                if (value == 0)
                {
                    this.Number = this.Number & (ulong)(~(1 << index));
                }
                else
                {
                    this.Number = this.Number | (ulong)(1 << index);
                }
            }
        }

        //Operators
        // Operators
        public static bool operator ==(SixtyFourBitArray firstArray, SixtyFourBitArray secondArray) =>
            firstArray.Equals(secondArray);

        public static bool operator !=(SixtyFourBitArray firstArray, SixtyFourBitArray secondArray) =>
            !firstArray.Equals(secondArray);


        //Methods
        public override bool Equals(object other) =>
            this.Number == ((SixtyFourBitArray)other).Number;

        public override int GetHashCode() =>
            this.Number.GetHashCode() ^ (this.Number.GetHashCode() * this.Number.GetHashCode());

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() =>
            this.GetEnumerator();
    }
}
