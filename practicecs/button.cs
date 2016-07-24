using System;

public class Button {
	public static void Main() {
		Button b = new Button();

		b.Caption = "abc";
		string c = b.Caption;
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