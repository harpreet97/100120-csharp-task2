using System;

namespace problem02csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //csharp problem02
            
            Console.WriteLine("This program will ask you to enter the number less than 100");
            Console.WriteLine("************************************************************");
            Console.WriteLine("Please type the number less than 100");
            double number = Convert.ToDouble(Console.ReadLine());

            if(number < 100){
                for(int i = 1; i <= 12; i++){
                    Console.WriteLine(number + "/" + i + "="+ (number/i));


                }
            }
            else{
                Console.WriteLine("Please type in the number less than 100");
            }

        }
    }
}
