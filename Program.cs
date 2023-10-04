namespace Lab3Problema1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetSubstringFromString();

            void GetSubstringFromString()
            {
                Console.WriteLine("Write something:");
                var input = Console.ReadLine();
                Console.WriteLine("Write a piece of text that's contained in your first prompt.");
                var searchString = Console.ReadLine();
                int counter = 0;

                while (input.Contains(searchString))
                {
                    var index = input.IndexOf(searchString, 0);
                    counter++;
                    input = input.Remove(index, searchString.Length);
                }
                Console.WriteLine($"{counter} instances of {searchString} found");
            }
        }
    }
}