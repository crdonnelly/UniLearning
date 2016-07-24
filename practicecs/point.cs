using System;

public class Point{
	public static void Main() {
		Point p = new Point();
		
		p.X = 1;
		p.Y = 2;
		int a = p.X;
		int b = p.Y;
		Console.WriteLine("x = {0}, y = {1}", a, b);
	}
	public int X{get;set;}
	public int Y{get;set;}
}