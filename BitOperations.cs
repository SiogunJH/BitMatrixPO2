using System;

public partial class BitMatrix
{
    public static BitMatrix operator &(BitMatrix m1, BitMatrix m2)
    {
        if (Object.ReferenceEquals(m1, null) || Object.ReferenceEquals(m2, null)) throw new ArgumentNullException();
        if (m1.NumberOfColumns != m2.NumberOfColumns || m1.NumberOfRows != m2.NumberOfRows) throw new ArgumentException();

        var result = new BitMatrix(m1.NumberOfRows, m1.NumberOfColumns);
        for (int i = 0; i < m1.NumberOfRows; i++)
        {
            for (int ii = 0; ii < m1.NumberOfColumns; ii++)
            {
                result[i, ii] = m1[i, ii] == 1 && m2[i, ii] == 1 ? 1 : 0;
            }
        }
        return result;
    }
    public static BitMatrix operator |(BitMatrix m1, BitMatrix m2)
    {
        if (Object.ReferenceEquals(m1, null) || Object.ReferenceEquals(m2, null)) throw new ArgumentNullException();
        if (m1.NumberOfColumns != m2.NumberOfColumns || m1.NumberOfRows != m2.NumberOfRows) throw new ArgumentException();

        var result = new BitMatrix(m1.NumberOfRows, m1.NumberOfColumns);
        for (int i = 0; i < m1.NumberOfRows; i++)
        {
            for (int ii = 0; ii < m1.NumberOfColumns; ii++)
            {
                result[i, ii] = m1[i, ii] == 1 || m2[i, ii] == 1 ? 1 : 0;
            }
        }
        return result;
    }
    public static BitMatrix operator ^(BitMatrix m1, BitMatrix m2)
    {
        if (Object.ReferenceEquals(m1, null) || Object.ReferenceEquals(m2, null)) throw new ArgumentNullException();
        if (m1.NumberOfColumns != m2.NumberOfColumns || m1.NumberOfRows != m2.NumberOfRows) throw new ArgumentException();

        var result = new BitMatrix(m1.NumberOfRows, m1.NumberOfColumns);
        for (int i = 0; i < m1.NumberOfRows; i++)
        {
            for (int ii = 0; ii < m1.NumberOfColumns; ii++)
            {
                result[i, ii] = m1[i, ii] != m2[i, ii] ? 1 : 0;
            }
        }
        return result;
    }
    public static BitMatrix operator !(BitMatrix m1)
    {
        if (Object.ReferenceEquals(m1, null)) throw new ArgumentNullException();

        var result = new BitMatrix(m1.NumberOfRows, m1.NumberOfColumns);
        for (int i = 0; i < m1.NumberOfRows; i++)
        {
            for (int ii = 0; ii < m1.NumberOfColumns; ii++)
            {
                result[i, ii] = m1[i, ii] == 0 ? 1 : 0;
            }
        }
        return result;
    }

    public BitMatrix And(BitMatrix other)
    {
        if (Object.ReferenceEquals(other, null)) throw new ArgumentNullException();
        if (this.NumberOfColumns != other.NumberOfColumns || this.NumberOfRows != other.NumberOfRows) throw new ArgumentException();

        for (int i = 0; i < this.NumberOfRows; i++)
        {
            for (int ii = 0; ii < this.NumberOfColumns; ii++)
            {
                this[i, ii] = this[i, ii] == 1 && other[i, ii] == 1 ? 1 : 0;
            }
        }
        return this;
    }
    public BitMatrix Or(BitMatrix other)
    {
        if (Object.ReferenceEquals(other, null)) throw new ArgumentNullException();
        if (this.NumberOfColumns != other.NumberOfColumns || this.NumberOfRows != other.NumberOfRows) throw new ArgumentException();

        for (int i = 0; i < this.NumberOfRows; i++)
        {
            for (int ii = 0; ii < this.NumberOfColumns; ii++)
            {
                this[i, ii] = this[i, ii] == 1 || other[i, ii] == 1 ? 1 : 0;
            }
        }
        return this;
    }
    public BitMatrix Xor(BitMatrix other)
    {
        if (Object.ReferenceEquals(other, null)) throw new ArgumentNullException();
        if (this.NumberOfColumns != other.NumberOfColumns || this.NumberOfRows != other.NumberOfRows) throw new ArgumentException();

        for (int i = 0; i < this.NumberOfRows; i++)
        {
            for (int ii = 0; ii < this.NumberOfColumns; ii++)
            {
                this[i, ii] = this[i, ii] != other[i, ii] ? 1 : 0;
            }
        }
        return this;
    }
    public BitMatrix Not()
    {
        for (int i = 0; i < this.NumberOfRows; i++)
        {
            for (int ii = 0; ii < this.NumberOfColumns; ii++)
            {
                this[i, ii] = this[i, ii] == 0 ? 1 : 0;
            }
        }
        return this;
    }
}