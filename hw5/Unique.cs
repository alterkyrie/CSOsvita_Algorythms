public static class Unique
{
    public static void Run()
    {
        var input = "bbbbb";
        var result = BruteForce(input);
        Console.WriteLine(result);
    }
    private static int BruteForce(string s)
    {
        var buffer = "";
        var count = 0;
        for (int i = 0; i < s.Length; i++)
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