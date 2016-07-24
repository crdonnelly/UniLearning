using System;

public class Button_2 {
	public static void Main() {
		Button_2 b = new Button_2();

		b.Caption = "abc";
		string c = b.Caption;
		Console.WriteLine("c = {0}\r\n",c);
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