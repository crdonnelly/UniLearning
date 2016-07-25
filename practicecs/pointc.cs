using System;

public class PointC {
	public static void Main() {
		var pc = new PointC{X=10,Y=20};
		
		var a = pc.X;
		var b = pc.Y;
		
		Console.WriteLine("x = {0}",a);
		Console.WriteLine("y = {0}",b);
		
		pc.X = 30;
		pc.Y = 20;
		
		a = pc.X;
		b = pc.Y;
		
		Console.WriteLine("x = {0}",a);
		Console.WriteLine("y = {0}",b);
	}
	
	public int X{get;set;}
	public int Y{get;set;}
}