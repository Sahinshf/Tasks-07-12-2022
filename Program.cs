namespace Tasks_07_12_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the sentences");
            string sentence = Console.ReadLine();

            Console.WriteLine("Check what the sentence contains");
            string check = Console.ReadLine();

            sentence.customContains(check);
        }
    }
}