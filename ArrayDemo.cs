public class ArrayDemo
{
    public static void playWithFruits()
    {
        List<string> fruits = new List<string> { "Apple", "Mango" };

        fruits.Add("Cashew");
        fruits.Add("Pineapple");
        fruits.Add("Melon");

        foreach (var fruit in fruits)
        {
            Console.WriteLine($"I love {fruit}");
        }
        fruits.Remove("Melon");

        Console.WriteLine($"The Length of our list is {fruits.Count}");

        var fakeFruit = "Sugar Cane";

        if (fruits.IndexOf(fakeFruit) != -1)
        {
            Console.WriteLine($"The index of {fakeFruit}  is {fruits.IndexOf(fakeFruit)}");
        }
        else
        {
            Console.WriteLine($"{fakeFruit}  is not in {fruits}");
        }
        fruits.Sort();
        Console.WriteLine("After sorting");
        foreach (var fruit in fruits)
        {
            Console.WriteLine($"{fruit}");
        }
    }

    public static void fibonnaci()
    {
        List<int> fibonacci = new List<int> { 1, 1 };

        while (fibonacci.Count() < 20)
        {
            var lastNumber = fibonacci[fibonacci.Count - 1];
            var numberBeforeLastNumber = fibonacci[fibonacci.Count - 2];
            var newNumber = lastNumber + numberBeforeLastNumber;
            fibonacci.Add(newNumber);
        }

        Console.WriteLine("Take a look at our fibonnaci sequence");

        foreach (var num in fibonacci)
        {
            Console.WriteLine(num);
        }
    }
}