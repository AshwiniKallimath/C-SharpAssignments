using System;
#region
public class Exercise3
{
    private static void Sum()
    {   #region FIELDS
        int i, n, sum = 0;
        Console.Write("Input the number of elements to be stored in the array :");
        n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[100];
        #endregion
        for (i = 0; i < n; i++)
        {
            Console.Write("please enter the numbers :");
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < a.Length; i++)
        {
            sum += a[i];
        }
        Console.WriteLine("Sum of all elements stored in the array is : {0}\n\n", +sum);
        Console.ReadLine();
    }
    public static void Main(String[] args)
    {  
        #region BODY
        Exercise3.Sum();
        Console.ReadKey();
        #endregion
    }
}
