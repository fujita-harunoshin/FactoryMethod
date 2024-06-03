namespace FactoryMethod;

internal class Client
{
    public void Main()
    {
        ClientCode(new ConcreteCreator1());
        Console.WriteLine("");
        ClientCode(new ConcreteCreator2());
    }

    public void ClientCode(Creator creator)
    {
        Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + creator.SomeOperation());
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }
    }
}
