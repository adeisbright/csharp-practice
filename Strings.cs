public class Strings
{

    public static void stringOperation(string title)
    {
        string helloText = " Hello,  World   ";
        Console.WriteLine($"The length of the string is {title.Length}");
        Console.WriteLine($"Make it uppercased : {title.ToUpper()}");
        Console.WriteLine($"Make it lowercased : {title.ToLower()}");
        Console.WriteLine($"Index of a in {title}: {title.IndexOf("a")}");
        Console.WriteLine($"[{helloText}]");
        Console.WriteLine($"[{helloText.TrimStart()}]");
        Console.WriteLine($"[{helloText.TrimEnd()}]");
        Console.WriteLine($"[{helloText.Trim()}]");
        Console.WriteLine($"[{title.Replace(title[0], 'Z')}]");

        Console.WriteLine($"{title.Contains("R")}");
        Console.WriteLine($"{title.StartsWith("R")}");
        Console.WriteLine($"{title.EndsWith("P")}");

    }
}