internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Program Start....");
        if (args is null || args.Length == 0)
            throw new TestFailException("No Argument Passed.");
        System.Console.WriteLine($"Passed arguement is {string.Join("||=||", args)}");
        System.Console.WriteLine("Program Complete...");
    }
}

public class TestFailException : Exception
{
    public TestFailException(string messsage) : base(messsage)
    {
        System.Console.Error.WriteLine(messsage);
    }
}
