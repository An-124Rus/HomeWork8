internal class Program
{
    private static void Main(string[] args)
    {
        string message;
        int repeat;
        int numberOfReplay;

        Console.Write("Введите сообщение: ");
        message = Console.ReadLine();
        Console.Write("Введите количество повторов: ");
        numberOfReplay = Convert.ToInt32(Console.ReadLine());

        for (repeat = 0; repeat < numberOfReplay; repeat++)
        {
            Console.WriteLine(repeat + message);
        }
    }
}