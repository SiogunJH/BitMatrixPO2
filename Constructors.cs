using System;
using System.Collections;

public partial class BitMatrix
{
    public BitMatrix(bool[,] bits)
    {
        if (bits == null) throw new NullReferenceException();
        if (bits.Length == 0) throw new ArgumentOutOfRangeException();

        NumberOfRows = bits.GetLength(0);
        NumberOfColumns = bits.GetLength(1);
        data = new BitArray(NumberOfRows * NumberOfColumns, BitToBool(0));

        for (int i = 0; i < NumberOfRows; i++)
        {
            for (int ii = 0; ii < NumberOfColumns; ii++)
            {
                data[i * NumberOfColumns + ii] = bits[i, ii];
            }
        }
    }
    public BitMatrix(int[,] bits)
    {
        if (bits == null) throw new NullReferenceException();
        if (bits.Length == 0) throw new ArgumentOutOfRangeException();

        NumberOfRows = bits.GetLength(0);
        NumberOfColumns = bits.GetLength(1);
        data = new BitArray(NumberOfRows * NumberOfColumns, BitToBool(0));

        for (int i = 0; i < NumberOfRows; i++)
        {
            for (int ii = 0; ii < NumberOfColumns; ii++)
            {
                data[i * NumberOfColumns + ii] = BitToBool(bits[i, ii]);
            }
        }
    }

    public BitMatrix(int numberOfRows, int numberOfColumns, params int[] bits)
    {
        if (numberOfRows < 1 || numberOfColumns < 1) throw new ArgumentOutOfRangeException("Incorrect size of matrix");

        NumberOfRows = numberOfRows;
        NumberOfColumns = numberOfColumns;
        data = new BitArray(numberOfRows * numberOfColumns, BitToBool(0));

        if (bits == null) return;

        int i = 0;
        while (i < bits.Length && i < data.Length)
        {
            data[i] = BitToBool(bits[i]);
            i++;
        }
    }
}