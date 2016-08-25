using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Public methods
// Delegates -- used with passing methods as arguments
delegate void customMsg(string txt);
#endregion Public methods


namespace CSharpDrillExercisesPart4
{
    class Exercises
    {

        // Define delegate used methods for custom strings
        // notice the same variable name is used
        static void Greeting(string txt)
        {
            Console.Write("{0}", txt);
        }
        static void Identity(string txt)
        {
            Console.Write("{0}", txt);
        }


        // Create a struct.  A struct takes simple variables and can use less
        // memory than creating a class using point, color, rectangle, and
        // other simple objects built-in
        // This example is a triangle with three sides using points
        public struct TriShape
        {
            public int s1, s2, s3;

            public TriShape(int p1, int p2, int p3)
            {
                s1 = p1;
                s2 = p2;
                s3 = p3;
            }
        }




        static void Main(string[] args)
        {
            Exercises ex = new Exercises();

            // You can create multiple versions of the delegate
            customMsg greetMsg, nameMsg, fullMsg;


            // Assign the methods to two of the delegates
            greetMsg = Greeting;
            nameMsg = Identity;

            // Call the single delegates (for this example just supplying the text)
            greetMsg("Hello, ");
            nameMsg("Sarah");

            // Clear screen after example
            ex.clrScreen();


            // A multicastdelegate can contain two delegates
            fullMsg = greetMsg + nameMsg;

            //Call mulicastdelegate will print two lines
            fullMsg("In this example the same text is said on two lines.\n");

            // Clear screen after example
            ex.clrScreen();


            // Use of the Struct object
            // The "new" syntax is optional for a Struct type
            TriShape tri1, tri2;

            tri1.s1 = 4;
            tri1.s2 = 3;
            tri1.s3 = 6;

            Console.WriteLine("The first triangle has sides with the lengths of:");
            Console.WriteLine("{0} x {1} x {2}", tri1.s1, tri1.s2, tri1.s3);
            int perim = tri1.s1 + tri1.s2 + tri1.s3;
            Console.WriteLine("\nThe perimter of the first triangle is {0}", perim);


            // Clear screen after example
            ex.clrScreen();

            tri2.s1 = 3;
            tri2.s2 = 5;
            tri2.s3 = 2;

            Console.WriteLine("The second triangle has sides with the lengths of:");
            Console.WriteLine("{0} x {1} x {2}", tri2.s1, tri2.s2, tri2.s3);
            perim = tri2.s1 + tri2.s2 + tri2.s3;
            Console.WriteLine("\nThe perimter of the second triangle is {0}", perim);

            // Clear screen after example
            ex.clrScreen();


            // Nullable Type Example



            // Enumerable Type Example

        }



        // Resource used repeatedly
        public void clrScreen()
        {
            Console.WriteLine("\n\nPress any key to continue . . .");
            Console.ReadLine();
            Console.Clear();
            return;
        }

    }
}
