using System;

public partial class BitMatrix : IEquatable<BitMatrix>
{
    public override bool Equals(object obj)
    {
        if (Object.ReferenceEquals(obj, null)) return false;
        if (Object.ReferenceEquals(this, obj)) return true;

        if (obj.GetType().Equals(typeof(BitMatrix)))
            return Equals((BitMatrix)obj);

        return false;
    }

    public bool Equals(BitMatrix m1)
    {
        if (Object.ReferenceEquals(m1, null)) return false;
        if (Object.ReferenceEquals(this, m1)) return true;
        if (this.NumberOfColumns != m1.NumberOfColumns || this.NumberOfRows != m1.NumberOfRows) return false;

        for (int i = 0; i < NumberOfRows; i++)
        {
            for (int ii = 0; ii < NumberOfColumns; ii++)
            {
                if (this.data[i * NumberOfColumns + ii] != m1.data[i * NumberOfColumns + ii]) return false;
            }
        }
        return true;
    }

    public override int GetHashCode() => HashCode.Combine(this.NumberOfColumns, this.NumberOfRows, data.GetHashCode());

    public static bool operator ==(BitMatrix m1, BitMatrix m2)
    {
        if (Object.ReferenceEquals(m1, null) && Object.ReferenceEquals(m2, null)) return true;
        if (Object.ReferenceEquals(m1, null) || Object.ReferenceEquals(m2, null)) return false;
        return m1.Equals(m2);
    }

    public static bool operator !=(BitMatrix m1, BitMatrix m2)
    {
        if (Object.ReferenceEquals(m1, null) && Object.ReferenceEquals(m2, null)) return false;
        if (Object.ReferenceEquals(m1, null) || Object.ReferenceEquals(m2, null)) return true;
        return !m1.Equals(m2);
    }
}