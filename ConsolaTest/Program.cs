using System; 
class TestingExercise
{
    public static int suma(int x, int b)
    {
        return x + b;
    }


    public static int[] InvertValues(int[] input)
    {
        int[] test = new int[];
       
         input.Select((numero) => test.add( numero * (-1))); 
        return test;
    }
    public static double NearestSq(int x)
    {
        double currentNumber = Math.Pow(Math.Round(Math.Sqrt(x)), 2);
        Console.WriteLine("HELLO");
        return currentNumber;
    }

    static void Main()
    {
        int[] numeros = new int[4] { 2, 3, -4, -7 };

        int[] numberResults = InvertValues(numeros);
        for(int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }

        Console.WriteLine("Hello world");
        Console.WriteLine(NearestSq(2)); 
    }
}