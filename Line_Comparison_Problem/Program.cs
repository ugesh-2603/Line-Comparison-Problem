namespace Line_Comparison_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparison Problem");

            float x1;
            float x2;
            float y1;
            float y2;
            float length;

            Console.WriteLine(" Calculate the length of line using given points");
            Console.WriteLine(" Please enter the First Point (x1):");
            float.TryParse(Console.ReadLine(), out x1);

            Console.WriteLine(" Please enter the Second Point (x2):");
            float.TryParse(Console.ReadLine(), out x2);

            Console.WriteLine(" Please enter the Third Point (y1):");
            float.TryParse(Console.ReadLine(), out y1);

            Console.WriteLine(" Please enter the Fourth Point (y2):");
            float.TryParse(Console.ReadLine(), out y2);

            length = (float) Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine(" Length of given line is " + length);



        }
    }
}