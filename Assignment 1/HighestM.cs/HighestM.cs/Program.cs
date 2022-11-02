using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region
class Highestm
{
 
    static void Main(string[] args)
    {
        #region BODY
        int i = 0;
        int highest = 0;
        int[] mark = new int[5];
        for (i = 0; i < 5; i++)
        {
            Console.WriteLine("Please enter students marks:");
            mark[i] = Convert.ToInt32(Console.ReadLine());
            {
                if (mark[i] > highest)
                    highest = mark[i];
            }

        }
        #endregion
        Console.WriteLine("The highest marks among all students :" + highest);
        Console.ReadLine();
        #endregion
    }
}
