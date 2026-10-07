using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        String choix;
        String texte;
        Console.WriteLine("Bienvenue dans l'aventure !");
        texte = File.ReadAllText(@"Ressources\Entrer.txt");
        Console.WriteLine(texte);
        Console.ReadLine();
        Console.Clear();

    }

public static void Chapitre_1()
    {
        //Contenu du chapitre
    }

}
