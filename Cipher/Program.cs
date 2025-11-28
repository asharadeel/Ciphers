using System;
using System.Collections.Generic;

public class Ciphers{
	
    public static void Main(){
        Console.WriteLine("Welcome to Cipher Libray ");
    }

	//A1Z26 
	public static string A1Z26_Encode(string text){
		text = text.ToUpper();
		List<int> values = new List<int>();
		foreach(char c in text){
			if (char.IsLetter(c))
				values.Add(c - 'A' + 1);
		}
		return string.Join(" ", values);
	}
	public static string A1Z26_Decode(string numbers){
		string[] parts = numbers.Split(' ');
		string result = "";
		foreach (string p in parts){
			if (int.TryParse(p, out int num) && num >= 1 && num <= 26)
				result += (char)('A' + num - 1);
		}
		return result;
	}

}
