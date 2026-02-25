using System;
using System.IO;
using System.Collections.Generic;

public class Program
{

    public static string nameText = "default-John";
	public static void Main()
	{
        // definitely file read all lines
        // definitely file write all lines
        //lets try this below and see if it sucks

    
        //File.ReadAllText(SonofAnder.txt, out nameText);      //maybe
  
        //string filePath = @"C:\Users\holden.anderson\source\repos\SiriShortcutboi\write_a_Greeting\SonofAnder.txt";
        string filePath = @"SonofAnder.txt";
        nameText = File.ReadAllText(filePath);
        //also i learned that using the @ sign takes out the chance of perceived escape keys

        nameText = File.ReadAllText("SonofAnder.txt");
		
		Console.WriteLine(nameText);







        //if (!fileInfo.Exists || fileInfo.Length == 0)

	}
}