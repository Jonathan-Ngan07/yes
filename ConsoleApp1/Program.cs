using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        String Menu;
        String Title;
        Menu = File.ReadAllText(@"Ressources/Menu/Menu.txt");
        Title = File.ReadAllText(@"Ressources/Images/Title.txt");
        Console.WriteLine(Menu);
        Console.WriteLine(Title);
        Console.ReadLine();
        Console.Clear();

    }

public static void Chapitre_1()
    {
        //Contenu du chapitre
    }

}