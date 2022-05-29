namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phone1 = new Phone();
            var phone2 = new Phone();
            var phone3 = new Phone();
            Console.WriteLine($"Phone1 -- number:{phone1.number}, model:{phone1.model}, weight: {phone1.weight}");
            Console.WriteLine($"Phone2 -- number:{phone2.number}, model:{phone2.model}, weight: {phone2.weight}");
            Console.WriteLine($"Phone3 -- number:{phone3.number}, model:{phone3.model}, weight: {phone3.weight}");
            phone1.receiveCall("vasya");
            phone2.receiveCall("masha");
            phone3.receiveCall("petya");
            phone1.getNumber();
            phone2.getNumber();
            phone3.getNumber();
            phone1.receiveCall("vasya", 45454);
        }
    }


}
