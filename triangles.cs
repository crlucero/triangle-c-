using System;
using System.Collections.Generic;

class Triangle
{
    public static void Main()

    {
        Console.WriteLine("Enter a number: ");
        string stringTriangleSideA = Console.ReadLine();
        int triangleSideA = int.Parse(stringTriangleSideA);

        Console.WriteLine("Enter a second number: ");
        string stringTriangleSideB = Console.ReadLine();
        int triangleSideB = int.Parse(stringTriangleSideB);

        Console.WriteLine("Enter a third number: ");
        string stringTriangleSideC = Console.ReadLine();
        int triangleSideC = int.Parse(stringTriangleSideC);

        if ( triangleSideA == triangleSideB && triangleSideA == triangleSideC) 
        {
        Console.WriteLine("This is an equilateral triangle.");    
        }

          else if (triangleSideA + triangleSideB < triangleSideC || triangleSideB + triangleSideC < triangleSideA || triangleSideA + triangleSideC < triangleSideB)
        {
            Console.WriteLine("This is not a triangle.");
        }
        
        else if ( triangleSideA == triangleSideB || triangleSideA ==  triangleSideC || triangleSideB == triangleSideC)
        {
            Console.WriteLine("This is an isosceles triangle.");
        }

        else if (triangleSideA != triangleSideB || triangleSideA !=  triangleSideC || triangleSideB != triangleSideC)
        {
            Console.WriteLine("This is a scalene triangle.");
        }
       
        
    }
    
   
}