internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello Montilivi!");
        Console.WriteLine("Estoy aprendiendo a utilizar GitHub");
        Console.WriteLine("look at my number: "+Randomized());
    }
    public static int Randomized() {
        Random dog = new Random();

        return dog.Next(1, 7);
    }
}
