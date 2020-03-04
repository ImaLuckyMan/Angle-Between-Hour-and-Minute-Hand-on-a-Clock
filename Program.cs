using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angle_Between_Hour_and_Minute_Hand_on_a_Clock
{
    public class Angles
    {
        static void Main(string[] args)
        {
            Degrees();
            Degrees(3,00);
        } 

        public static void Degrees()
        {
            int angle;
            int hour;
            int minute;

            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            Console.WriteLine("The current hour is: " + hour);
            Console.WriteLine("The current minute is: " + minute);

            // We were told that our program should return the smaller angle so I broke it up at 180 degrees.

            if (hour <= 6)
            {
                angle = ((hour * 30) - (minute * 6)); //Converts the hours and minutes to degrees and subtracts them from each other. Returning an Absolute Value.
                Console.WriteLine("The angle is approximatly " + Math.Abs(angle) + " degrees");
            }

            if (hour >= 6)
            {
                angle = ((minute * 6) - (hour * 30)); //Converts the hours and minutes to degrees and subtracts them from each other. Returning an Absolute Value
                Console.WriteLine("The angle is approximatly " + Math.Abs(angle) + " degrees");
            }

        }

        public static int Degrees(int hour, int minute)
        {
            int angle;

            //hour = DateTime.Now.Hour;
            //minute = DateTime.Now.Minute;
            Console.WriteLine("The current hour is: " + hour);
            Console.WriteLine("The current minute is: " + minute);

            //hourAngle = hour * 30; //Figures out the angle of the hour hand

            if (hour <= 6)
            {
                angle = ((hour * 30) - (minute * 6)); //Converts the hours and minutes to degrees and subtracts them from each other. Returning an Absolute Value.
                Console.WriteLine("The angle is approximatly " + Math.Abs(angle) + " degrees");
                return (angle); 
            }

            if (hour >= 6)
            {
                angle = ((minute * 6) - (hour * 30)); //Converts the hours and minutes to degrees and subtracts them from each other. Returning an Absolute Value
                Console.WriteLine("The angle is approximatly " + Math.Abs(angle) + " degrees");
                return (angle);
            }
           
            else 
            { 
                Console.WriteLine("Please check your input"); 
            }   return(0);
        }
    }
}