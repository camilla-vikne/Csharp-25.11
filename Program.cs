using System;
using System.Reflection.Metadata;

public class Program 
{
	public static void Main()
	{
		string myName = "John"; // initializes the variable text string "myName"
        float myAge =32.5f; // initializes the variable float "myAge". The number type
        // needs to be declared in the variable as well
        Console.WriteLine(myAge); // prints the variable to the console
        Cup myCup = new ( //creates a new instance of the cup class
            handle: false, // sets the handle property to false
            circ: 20.5d, // sets the circ property to 20.5
            depth: 50.4d // sets the depth property to 50.4
        );
        Console.WriteLine(myCup.HasHandle); 
        // prints to the console whether the cup has a handle or not
	}
    class Cup // inizialises the class Cup
    {
        public bool HasHandle; // declares the property HasHandle, lets you tell the program 
        // if the cup has a handle or not (boolean)
        public double Circumference; // declares the  property Circumfrence, lets you tell the program
        // what the circumference of the cup is
        public double Depth; // declares the depth property, lets you
        // tell the program how deep the cup is
        public Cup(bool handle, double circ, double depth) // Declares what properties the cup should contain,
        // and what type of data they should be
        {
            HasHandle = handle;
            Circumference = circ;
            Depth = depth;
        }
    }
}