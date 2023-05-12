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
            x1 = float.Parse(Console.ReadLine());

            Console.WriteLine(" Please enter the Second Point (x2):");
            x2 = float.Parse(Console.ReadLine());

            Console.WriteLine(" Please enter the Third Point (y1):");
            y1 = float.Parse(Console.ReadLine());

            Console.WriteLine(" Please enter the Fourth Point (y2):");
            y2 = float.Parse(Console.ReadLine());

            length = (float) Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine(" Length of given line is " + length);

            //second line execution.

            Console.WriteLine(" Calculate the length of line using given points");
            Console.WriteLine(" Please enter the length of the second line first Point (x1_1):");
            x1_1 = float.Parse(Console.ReadLine());

            Console.WriteLine(" Please enter the length of the second line second Point (x2_2):");
            x2_2 = float.Parse(Console.ReadLine());

            Console.WriteLine(" Please enter the length of the second line third Point (y1_1):");
            y1_1 = float.Parse(Console.ReadLine());

            Console.WriteLine(" Please enter the length of the second line fourth Point (y2_2):");
            y2_2 = float.Parse(Console.ReadLine());

            length2 = (float)Math.Sqrt(Math.Pow(x2_2 - x1_1, 2) + Math.Pow(y2_2 - y1_1, 2));

            Console.WriteLine(" Length of given line is " + length2);

            if (length.Equals(length2))
            {
                Console.WriteLine(" Both the line 1 and line 2 are equal");
            }
            else if (length > length2)
            {
                Console.WriteLine(" Line1 is greater than Line2.");
            }
            else if (length < length2)
            {
                Console.WriteLine(" Line2 is greater than Line1.");
            }
            else
            {
                Console.WriteLine(" Both the lines are different");
            }



        }
    }
}