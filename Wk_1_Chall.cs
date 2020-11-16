using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week_1_Challenges
{
    [TestClass]
    public class Wk_1_Chall
    {

        [TestMethod]
        public void NumberOne()
        {
            string firstName = "Briggs ";
            string lastName = "Iwunze";
            int myAge = 34;

            Console.WriteLine(firstName + lastName + " is " + myAge);
        }

        [TestMethod]
        public void NumberTwo()
        {
            string[] favMovies = { "Coming to America", "Paid in Full", "The Great Gatsby", "The Matrix" };

            Console.WriteLine(favMovies[1]);
        }

        [TestMethod]
        public void NumberThree()
        {
            //Make a list to hold dates. Include on that list the current date and time.
            DateTime todaysDate = DateTime.Now;
            
            List<string> listOfDates = new List<string>();
            listOfDates.Add(todaysDate);

        }

        [TestMethod]
        public void NumberFour()
        {
            //Write out to the Console the values calculated by your age variable and the number 7. 
            //Use each operator we covered in Operators 
            int myAge = 34;
            int numSeven = 7;

            int sum = myAge + numSeven;
            Console.WriteLine(sum);

            int diff = myAge - numSeven;
            Console.WriteLine(diff);

            int prod = myAge * numSeven;
            Console.WriteLine(prod);

            int quot = myAge / numSeven;
            Console.WriteLine(quot);

            int modu = myAge % numSeven;
            Console.WriteLine(modu);
        }

        [TestMethod]
        public void NumberFive()
        {
            //Write out a collection of conditionals that evaluates a new variable for how many hours of sleep the user gets
            //-----"You can just initialize this variable for now, it does not have to be actually given by a user."-----
            //      For any other condition output "Oh man, get some sleep!"

            int hrsSleep = 12;

            if (hrsSleep >= 10)                         //If the hours slept is greater or equal to 10, write to the console "Wow that's a lot of sleep!"
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }
            if (hrsSleep <= 10 && hrsSleep >= 8)        //If the hours is greater than 8 but less than 10, write to the console "You should be pretty rested"
            {
                Console.WriteLine("You should be pretty rested");
            }
            if (hrsSleep <= 8 && hrsSleep >= 4)         //If the hours is greater than 4 but less than 8, output "Bummer"
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }
        }

        [TestMethod]
        public void NumberSix()
        {
            //Write out a switch case that evaluates a variable that holds the value for how the user's day has been.
            //Have a case for: "Great", "Good", "Okay", "Bad", ":(" and output a response to the Console for each.

            int myDay = 8;

            switch (myDay)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Bad");
                    break;
                case 5:
                case 6:
                    Console.WriteLine("Okay");
                    break;
                case 7:
                case 8:
                    Console.WriteLine("Good");
                    break;
                case 9:
                case 10:
                    Console.WriteLine("Great");
                    break;
            }

        }
    }

    internal class List<T>
    {
    }
}
