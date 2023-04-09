using System;
using System.Text;

public partial class BitMatrix
{
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < NumberOfRows; i++)
        {
            for (int ii = 0; ii < NumberOfColumns; ii++)
            {
                sb.Append(BoolToBit(data[i * NumberOfColumns + ii]));
            }
            sb.Append(Environment.NewLine);
        }

        return sb.ToString();
    }
}