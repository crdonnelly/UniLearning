using System;

public struct PointS{
	public static void Main() {
		var ps = new PointS{X=10,Y=20};
		var qs = ps;
		qs.X += 1;
		ps.Dump("ps");
		qs.Dump("qs");
	}
	
	public int X{get;set;}
	public int Y{get;set;}
}