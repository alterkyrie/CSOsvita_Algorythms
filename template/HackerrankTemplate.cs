using System;
using System.IO;
public class Solution
{
    public static void Main(string[] args)
    {
        var reader = new StreamReader(Console.OpenStandardInput());
        var writer = new StreamWriter(Console.OpenStandardOutput());
        var s = reader.ReadLine();
        var result = BruteForce(s);
        writer.WriteLine(result);
        reader.Close();
        writer.Close();
    }
    private static long BruteForce(string s)
    {
        if (string.IsNullOrEmpty(s))
            return 0;
        var buffer = "";
        var count = 1L;
        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];
            if (buffer.Contains(c))
            {
                count = Math.Max(count, buffer.Length);
                buffer = $"{c}";
            }
            else
            {
                buffer += c;
            }
        }
        return count;
    }

}
