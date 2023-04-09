using System;
using System.Collections;
using System.Collections.Generic;

public partial class BitMatrix : IEnumerable<int>
{
    public int this[int row, int col]
    {
        get
        {
            if (row < 0 || col < 0 || row >= NumberOfRows || col >= NumberOfColumns) throw new IndexOutOfRangeException();
            return BoolToBit(this.data[row * NumberOfColumns + col]);
        }

        set
        {
            if (row < 0 || col < 0 || row >= NumberOfRows || col >= NumberOfColumns) throw new IndexOutOfRangeException();
            this.data[row * NumberOfColumns + col] = BitToBool(value);
        }
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < NumberOfRows; i++)
        {
            for (int ii = 0; ii < NumberOfColumns; ii++)
            {
                yield return BoolToBit(this.data[i * NumberOfColumns + ii]);
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}