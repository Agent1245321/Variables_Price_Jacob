using System;

namespace Variables_Price_Jacob
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //Declares an int named favoriteNumber
            int favoriteNumber;

            //Initializes two bools with valuse of false
            bool isJumping = false; bool isRunning = false;
            
            //Declares a float named asIWish
            float asIWish;

            //Assigns favoriteNumber and asIWish with values
            favoriteNumber = 21;
            asIWish = 69.69696f;

            //Initializes a double, finalGrade, and sets it to 100
            double finalGrade = 100;


            //Prints out all the variables pn seperate lines
            Console.WriteLine(favoriteNumber + " favorite Number");
            Console.WriteLine(isJumping + " isJumping");
            Console.WriteLine(isRunning + " isRunning");
            Console.WriteLine(asIWish + " Random Float");
            Console.WriteLine(finalGrade + " Final Grade");

            


        }
    }
}
