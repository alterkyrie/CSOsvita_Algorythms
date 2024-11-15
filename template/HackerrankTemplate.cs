using System;
using System.IO;
public class Solution
{
    public static void Main(string[] args)
    {
        var reader = new StreamReader(Console.OpenStandardInput());
        var writer = new StreamWriter(Console.OpenStandardOutput());
        var a = int.Parse(reader.ReadLine());
        var b = int.Parse(reader.ReadLine());
        writer.WriteLine(a + b);
        reader.Close();
        writer.Close();
    }
}
