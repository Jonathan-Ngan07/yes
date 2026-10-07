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
        Menu_title = File.ReadAllText(@"Ressources/Menu_Accueil/Message_d'accueil.txt");
        Title_image = File.ReadAllText(@"Ressources/Images/Title.txt");
        User_Next_Command = File.ReadAllText(@"Ressources/Contextuel/Demande_de_continuité.txt");
        Console.WriteLine(Menu_title);
        Console.WriteLine(Title_image);
        Console.WriteLine(User_Next_Command);
        Console.ReadLine();
        Console.Clear();
        Chapitre_1();

    }

public static void Chapitre_1()
    {
        String Title;
        String User_Next_Command;
        String msg1;
        Title = File.ReadAllText(@"Ressources/Chapitres/Chapitre_1/Title.txt");
        User_Next_Command = File.ReadAllText(@"Ressources/Contextuel/Demande_de_continuité.txt");
        Console.WriteLine(Title);
        Console.WriteLine(User_Next_Command);
        Console.ReadLine();
        Console.Clear();
        msg1 = File.ReadAllText(@"Ressources/Chapitres/Chapitre_1/msg1.txt");
        Console.WriteLine(msg1);
        Console.WriteLine(User_Next_Command);
        Console.ReadLine();
        Console.Clear();

    }

}