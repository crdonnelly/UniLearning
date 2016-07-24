using System;

public class Button_3 {
	public static void Main() {
		Button_3 b = new Button_3();

		b.Caption = "abc";
		string c = b.Caption;
		Console.WriteLine("c = {0}\r\n",c);
		
		Button_3 p = new Button_3{Caption = "cool!"};
		string e = p.Caption;
		Console.WriteLine("e = {0}", e);
	}
	private string caption;
	public string Caption{
		get{
			Console.WriteLine("get {0}",caption);
			return caption;
		}
		set{
			Console.WriteLine("set {0}", value);
			caption = value;
		}
	}
}