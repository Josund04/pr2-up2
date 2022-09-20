// See https://aka.ms/new-console-template for more information
using System;
public class AreaOfRectangle
{
    public static void Main()
    {
        int height = 15;
        int width = 6;
        int Area = height * width;
        Console.WriteLine("Arean av basen " +(width)+ " och höjden " +(height)+ " ger arean " +(Area));
        Console.ReadKey();


        Console.WriteLine("Skriv in basen på en rektanegl: ");
        int Width = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Skriv in höjden på rektangeln: ");
        int Height = Convert.ToInt32(Console.ReadLine());
        Area = Width * Height;
        Console.WriteLine("Längden av basen " +(Width)+ " och höjden " +(Height)+ " ger arean " +(Area));
        Console.ReadKey();
    }
} 
