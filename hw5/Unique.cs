public static class Unique
{
    private static Random _random = new Random();
    public static void Run()
    {
        var input = GetRandomInpit(5 * 10000);
        var result = BruteForce(input);
        Console.WriteLine($"{input} - {result}");
    }
    private static string GetRandomInpit(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 !@#$>%^&*()";
        const string chars_short = "ABC";

        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[_random.Next(s.Length)]).ToArray());
    }
    private static int BruteForce(string s)
    {
        if (string.IsNullOrEmpty(s))
            return 0;
        var buffer = "";
        var count = 1;
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
    private static int TwoPointers(string s)
    {
        
    }
}