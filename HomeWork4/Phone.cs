namespace Task2
{
    public class Phone
    {

        public int number;
        public string model;
        public int weight;

        public Phone(int number, string model, int weight)
        {
            this.number = number;
            this.model = model;
            this.weight = weight;
        }
        public Phone(int number, string model)
        {
            this.number = number;
            this.model = model;
        }
        public Phone()
        {

        }

        public void receiveCall(string callerName)
        {
            Console.WriteLine($"Incoming call from {callerName}");
        }
        public int getNumber()
        {
            return number;
        }
        public void receiveCall(string callerName, int callerNumber)
        {
            Console.WriteLine($"Incoming call from {callerName}, {callerNumber}");
        }
        public void sendMesasge(params int[] sendToNumbers)
        {
            foreach (var item in sendToNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
