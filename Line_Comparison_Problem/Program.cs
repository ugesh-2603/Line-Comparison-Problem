namespace Line_Comparison_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparison Problem");

            //line 1
            float x1;
            float x2;
            float y1;
            float y2;
            float length;

            //line 2
            float x1_1;
            float x2_2;
            float y1_1;
            float y2_2;
            float length2;

            //first line execution.
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

            //second line execution.

            Console.WriteLine(" Calculate the length of line using given points");
            Console.WriteLine(" Please enter the length of the second line first Point (x1_1):");
            float.TryParse(Console.ReadLine(), out x1_1);

            Console.WriteLine(" Please enter the length of the second line second Point (x2_2):");
            float.TryParse(Console.ReadLine(), out x2_2);

            Console.WriteLine(" Please enter the length of the second line third Point (y1_1):");
            float.TryParse(Console.ReadLine(), out y1_1);

            Console.WriteLine(" Please enter the length of the second line fourth Point (y2_2):");
            float.TryParse(Console.ReadLine(), out y2_2);

            length2 = (float)Math.Sqrt(Math.Pow(x2_2 - x1_1, 2) + Math.Pow(y2_2 - y1_1, 2));

            Console.WriteLine(" Length of given line is " + length2);

            if (length.Equals(length2))
            {
                Console.WriteLine(" Both the line 1 and line 2 are equal");
            }
            else
            {
                Console.WriteLine(" Both the line 1 and line 2 are not equal");
            }



        }
    }
}