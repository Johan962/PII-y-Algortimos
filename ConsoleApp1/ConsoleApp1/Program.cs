//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        //Says Hello {name}
//        Console.WriteLine("PROGRAM TO SAY HELLO");
//        Console.WriteLine("");
//        Console.WriteLine("What's your name?");
//        string name = Console.ReadLine();
//        Console.WriteLine($"Hello {name}");

//        // Sum of two numbers
//        Console.WriteLine("--------------------------------------------------------------------------------------------");
//        Console.WriteLine("");
//        Console.WriteLine("PROGRAM TO SUM TWO NUMBERS");
//        Console.WriteLine("");
//        Console.WriteLine("Enter the first number to sum: ");
//        string N1 = Console.ReadLine();
//        Console.WriteLine("Enter the second number to sum: ");
//        string N2 = Console.ReadLine();
//        Console.WriteLine($"The sum is: {int.Parse(N1) + int.Parse(N2)}");

//        //It is even or not?
//        Console.WriteLine("--------------------------------------------------------------------------------------------");
//        Console.WriteLine("");
//        Console.WriteLine("PROGRAM TO KNOW IF A NUMBER IS EVEN OR NO");
//        Console.WriteLine("");
//        Console.WriteLine("Enter the num to verify if it is even: ");
//        string num = Console.ReadLine();
//        if (int.Parse(num) % 2 == 0)
//        {
//            Console.WriteLine("It is even!!!!");
//        }
//        else
//        {
//            Console.WriteLine("It is not even :( ");
//        }

//        //He or She is aprooved or not?
//        Console.WriteLine("--------------------------------------------------------------------------------------------");
//        Console.WriteLine("");
//        Console.WriteLine("PROGRAM TO KNOW IF AN STUDENT IS APROOVED, DESAPROOVED OR REPROBATED");
//        Console.WriteLine("");
//        Console.WriteLine("Enter the first exam score: ");
//        string Sc1 = Console.ReadLine();
//        Console.WriteLine("Enter the first exam score: ");
//        string Sc2 = Console.ReadLine();
//        Console.WriteLine("Enter the first exam score: ");
//        string Sc3 = Console.ReadLine();
//        int Prom = (int.Parse(Sc1) + int.Parse(Sc2) + int.Parse(Sc3))/3;
//        if (Prom >= 13.5)
//        {
//            Console.WriteLine("APROOVED");
//        }
//        else
//        {
//            if (Prom < 13.5 && Prom > 9)
//            {
//                Console.WriteLine("DISAPROOVED");
//            }
//            else
//                Console.WriteLine("REPROBATED");
//        }

//        // Finding the mayor of N numbers
//        Console.WriteLine("--------------------------------------------------------------------------------------------");
//        Console.WriteLine("");
//        Console.WriteLine("PROGRAM TO FIND THE MAYOR OF N NUMBERS");
//        Console.WriteLine("");
//        Console.WriteLine("Enter how many numbers you want to enter: ");
//        string Nnumbers = Console.ReadLine();
//        int[] numbers = new int[int.Parse(Nnumbers)];
//        for (int i = 0; i < int.Parse(Nnumbers); i++)
//        {
//            numbers[i] = int.Parse(Console.ReadLine());
//        }
//        int Mayor = numbers[0];
//        for (int i = 0; i < int.Parse(Nnumbers); i++)
//        {
//            if (numbers[i] > Mayor)
//            {
//                Mayor = numbers[i];
//            }
//        }
//        Console.WriteLine($"The mayor number is {Mayor}");

//        //Finding the minor of N numbers
//        Console.WriteLine("--------------------------------------------------------------------------------------------");
//        Console.WriteLine("");
//        Console.WriteLine("PROGRAM TO FIND THE MINOR OF N NUMBERS");
//        Console.WriteLine("");
//        Console.WriteLine("Enter how many numbers you want to enter: ");
//        string Nnumbers1 = Console.ReadLine();
//        int[] numbers1 = new int[int.Parse(Nnumbers1)];
//        for (int i = 0; i < int.Parse(Nnumbers1); i++)
//        {
//            numbers1[i] = int.Parse(Console.ReadLine());
//        }
//        int Minor = numbers1[0];
//        for (int i = 0; i < int.Parse(Nnumbers1); i++)
//        {
//            if (numbers1[i] < Minor)
//            {
//                Minor = numbers1[i];
//            }
//        }
//        Console.WriteLine($"The minor number is: {Minor}");

//        //Invert of two numbers
//        Console.WriteLine("--------------------------------------------------------------------------------------------");
//        Console.WriteLine("");
//        Console.WriteLine("PROGRAM TO INVERT TWO NUMBERS");
//        Console.WriteLine("");
//        Console.WriteLine("Enter the number to invert: ");
//        string numb = Console.ReadLine();
//        int numCifras = numb.Length;
//        int numberI = int.Parse(numb);
//        int invertNumber = 0;
//        for (int i=0;  i <numCifras;i++)
//        {
//            int lastDigit = numberI % 10;
//            numberI = (numberI - lastDigit)/10;
//            invertNumber = (invertNumber*10) + lastDigit;
//        }

//        Console.WriteLine($"El numero invertido es {invertNumber}");


//    }
//}
