using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class Program
{
    static int Value1;
    static int Value2;
    static int Value3;
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
        Console.Clear();
        String Title;
        String User_Next_Command;
        String msg1;
        String msg2;
        String msg3;
        String msg4;
        String msg5;
        String msg6;
        String msg7;
        String msg8;
        String choix;
        String img1;
        String img2;
        String img3;
        String img4;
        Title = File.ReadAllText(@"Ressources/Chapitres/Chapitre_1/Title.txt");
        User_Next_Command = File.ReadAllText(@"Ressources/Contextuel/Demande_de_continuité.txt");
        Console.WriteLine(Title);
        Console.WriteLine(User_Next_Command);
        Console.ReadLine();
        Console.Clear();
        msg1 = File.ReadAllText(@"Ressources/Chapitres/Chapitre_1/msg1.txt");
        img1 = File.ReadAllText(@"Ressources/Chapitres/Chapitre_1/Images_chapitre_1/Voltage.txt");
        Console.WriteLine(img1);
        Console.WriteLine(msg1);
        Console.WriteLine(User_Next_Command);
        Console.ReadLine();
        Console.Clear();
        msg2 = File.ReadAllText(@"Ressources/Chapitres/Chapitre_1/msg2.txt");
        Console.WriteLine(msg2);
        Console.WriteLine(User_Next_Command);
        Console.ReadLine();
        Console.Clear();
        msg3 = File.ReadAllText(@"Ressources/Chapitres/Chapitre_1/msg3.txt");
        img2 = File.ReadAllText(@"Ressources/Chapitres/Chapitre_1/Images_chapitre_1/Horloge.txt");
        Console.WriteLine(img2);
        Console.WriteLine(msg3);
        Console.WriteLine(User_Next_Command);
        Console.ReadLine();
        Console.Clear();
        msg4 = File.ReadAllText(@"Ressources/Chapitres/Chapitre_1/msg4.txt");
        Console.WriteLine(msg4);
        Console.WriteLine(User_Next_Command);
        Console.ReadLine();
        Console.Clear();
        msg5 = File.ReadAllText(@"Ressources/Chapitres/Chapitre_1/msg5.txt");
        Console.WriteLine(msg5);
        Console.WriteLine(User_Next_Command);
        Console.ReadLine();
        Console.Clear();
        msg6 = File.ReadAllText(@"Ressources/Chapitres/Chapitre_1/msg6.txt");
        Console.WriteLine(msg6);
        Console.WriteLine(User_Next_Command);
        Console.ReadLine();
        Console.Clear();
        msg7 = File.ReadAllText(@"Ressources/Chapitres/Chapitre_1/msg7.txt");
        img3 = File.ReadAllText(@"Ressources/Chapitres/Chapitre_1/Images_chapitre_1/Atelier.txt");
        Console.WriteLine(img3);
        Console.WriteLine(msg7);
        Console.WriteLine(User_Next_Command);
        Console.ReadLine();
        Console.Clear();
        msg8 = File.ReadAllText(@"Ressources/Chapitres/Chapitre_1/msg8.txt");
        Console.WriteLine(msg8);
        Console.WriteLine(User_Next_Command);
        Console.Write("Appuyer sur Entrée pour recommencer le chapitre ou choisissez une option : 1, 2 ou 3 = ");
        choix = (Console.ReadLine() ?? string.Empty).ToLowerInvariant();
        switch (choix)
        {
            case "1":
                Chapitre_1minus1();
                break;
            case "2":
                Chapitre_1minus2();
                break;
            case "3":
                Chapitre_1minus3();
                break;
            default:
                Console.WriteLine("Choix invalide, veuillez réessayer le chapitre.");
                Chapitre_1();
                break;
        }

    }
public static void Chapitre_1minus1()
    {
    Console.Clear();
    }

public static void Chapitre_1minus2()
    {
    Console.Clear();
    }

public static void Chapitre_1minus3()
    {
    Console.Clear();
    }

}
