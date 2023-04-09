using System;

public partial class BitMatrix : ICloneable
{
    public object Clone()
    {
        var clone = new BitMatrix(this.NumberOfRows, this.NumberOfColumns);
        for (int i = 0; i < NumberOfRows; i++)
        {
            for (int ii = 0; ii < NumberOfColumns; ii++)
            {
                clone[i, ii] = this[i, ii];
            }
        }
        return clone;
    }
}