using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] reqemler = { 6, 7, 8, 9 };
            
            reqemler = Metod(reqemler, 20);
        }

        static int Metod( int[] nums, int a)
        {
         
            int[] newnums = new int[nums.Length + 1];
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    newnums[i] = nums[i];
                }
                    newnums[newnums.Length - 1] = a;

            return newnums;
            }
            
        }             
        
        
            
            
            
        

            

        
    }
}
