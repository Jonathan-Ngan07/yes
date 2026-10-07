using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        String Menu_title;
        String Title_image;
        String User_Next_Command;
        Menu_title = File.ReadAllText(@"Ressources/Menu/Message_d'acceuil.txt");
        Title_image = File.ReadAllText(@"Ressources/Images/Title.txt");
        User_Next_Command = File.ReadAllText(@"Ressources/Contextuel/Demande_de_continuité.txt");
        Console.WriteLine(Menu_title);
        Console.WriteLine(Title_image);
        Console.WriteLine(User_Next_Command);
        Console.ReadLine();
        Console.Clear();

    }

public static void Chapitre_1()
    {
        //Contenu du chapitre
    }

}