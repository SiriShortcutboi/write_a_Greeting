using System;
using System.IO;
using System.Collections.Generic;

public class Program
{

    
    public static string userName = "user is John";
    public static string nameText = "file default-John";
	public static void Main()
	{

       // nameText = File.WriteAllText//bbbbbbbbbbrrrrrrrruuuuuuuuuuuuuhhhhhhhhhhhhhh
    
        //File.ReadAllText(SonofAnder.txt, out nameText);      //maybe
  
        //string filePath = @"C:\Users\holden.anderson\source\repos\SiriShortcutboi\write_a_Greeting\SonofAnder.txt";
        string filePath = @"SonofAnder.txt";
        nameText = File.ReadAllText(filePath);
        //also i learned that using the @ sign takes out the chance of perceived escape keys

       // nameText = File.ReadAllText("SonofAnder.txt");
		
        if (filePath.IsWhiteSpace()){
            
            Console.WriteLine("What is your name?");
            userName = Console.ReadLine();
            userName = userName.ToString();
		
        }

        else
        {
            Console.WriteLine($"Hello {nameText}");

        }





        //if (!fileInfo.Exists || fileInfo.Length == 0)

	}
}