using System;
using System.Collections;

public partial class BitMatrix
{
    public static implicit operator BitArray(BitMatrix m)
    {
        var copy = new bool[m.data.Length];
        m.data.CopyTo(copy, 0);
        return new BitArray(copy);
    }
    public static implicit operator bool[,](BitMatrix m)
    {
        var result = new bool[m.NumberOfRows, m.NumberOfColumns];
        for (int i = 0; i < m.NumberOfRows; i++)
        {
            for (int ii = 0; ii < m.NumberOfColumns; ii++)
            {
                result[i, ii] = BitToBool(m[i, ii]);
            }
        }
        return result;
    }

    public static explicit operator BitMatrix(bool[,] t)
    {
        if (t == null) throw new NullReferenceException();
        if (t.Length == 0) throw new ArgumentOutOfRangeException();

        var result = new BitMatrix(t.GetLength(0), t.GetLength(1));
        for (int i = 0; i < result.NumberOfRows; i++)
        {
            for (int ii = 0; ii < result.NumberOfColumns; ii++)
            {
                result[i, ii] = BoolToBit(t[i, ii]);
            }
        }
        return result;
    }
    public static implicit operator int[,](BitMatrix m)
    {
        var result = new int[m.NumberOfRows, m.NumberOfColumns];
        for (int i = 0; i < m.NumberOfRows; i++)
        {
            for (int ii = 0; ii < m.NumberOfColumns; ii++)
            {
                result[i, ii] = m[i, ii];
            }
        }
        return result;
    }

    public static explicit operator BitMatrix(int[,] t)
    {
        if (t == null) throw new NullReferenceException();
        if (t.Length == 0) throw new ArgumentOutOfRangeException();

        var result = new BitMatrix(t.GetLength(0), t.GetLength(1));
        for (int i = 0; i < result.NumberOfRows; i++)
        {
            for (int ii = 0; ii < result.NumberOfColumns; ii++)
            {
                result[i, ii] = t[i, ii];
            }
        }
        return result;
    }
}