using System;

public class VarButton{
	public static void Main() {
		var b = new VarButton();
		
		b.Caption = "abc";
		var c = b.Caption;
		Console.WriteLine("c = {0}\r\n", c);
		
		var p = new VarButton{Caption = "cool!"};
		var e = p.Caption;
		Console.WriteLine("e = {0}", e);
	}
	
	private string caption;
	public string Caption{
		get{
			Console.WriteLine("get {0}", caption);
			return caption;
		}
		set {
			Console.WriteLine("set {0}", value);
			caption = value;
		}
	}
}