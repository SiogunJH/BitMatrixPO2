using System;
public partial class BitMatrix
{
    public static bool TryParse(string s, out BitMatrix result)
    {
        try
        {
            result = Parse(s);
            return true;
        }
        catch (Exception)
        {
            result = null;
            return false;
        }
    }

    public static BitMatrix Parse(string s)
    {
        if (s == null || s.Length == 0) throw new ArgumentNullException();
        string[] stringArr = s.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 1; i < stringArr.Length; i++)
            if (stringArr[i].Length != stringArr[i - 1].Length) throw new FormatException();

        var parsed = new BitMatrix(stringArr.Length, stringArr[0].Length);
        for (int i = 0; i < stringArr.Length; i++)
        {
            for (int ii = 0; ii < stringArr[0].Length; ii++)
            {
                if (stringArr[i][ii] != '0' && stringArr[i][ii] != '1') throw new FormatException();
                parsed[i, ii] = stringArr[i][ii] == '0' ? 0 : 1;
            }
        }

        return parsed;
    }
}