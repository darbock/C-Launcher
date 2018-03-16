using System;

namespace ProjectOne
{
    class Information
    {
        public static void Main(string[] args)
        {
            // Method main
            // avec des method de la même classe
            // dont une method venant d'une autre classe " end "
            Information x = new Information();
            x.Fond();
            Console.WriteLine("Bonjour !");
            Console.WriteLine("Quel est ton nom");            
            string saisie = Console.ReadLine();            
            Console.WriteLine("Enchanter " + saisie);
            Console.Clear();
            Information t = new Information();
            t.Age(saisie);
            t.Metier(saisie);            
            t.Application(); 
                                  
        }
        
        // demande l'age
        public void Age(string saisie)
        {
            // Methode qui retiens une saisie clavier
            // verifie que "saisie2" est bien un chiffre  
            
            Console.WriteLine("Quel age a tu " + saisie);
            string saisie2 = Console.ReadLine();            
            int n;
            bool isNumeric = int.TryParse(saisie2, out n);            
            if (int.TryParse(saisie2, out n))
            {
                Console.WriteLine("Vous avez " + saisie2, "vous etes enconre jeune !");
            }
            else
            {
                Console.WriteLine("ce n'est pas un nombre");
                return;
            }
            Console.Clear();

        }

        // demande le metier
        public void Metier(string saisie)
        {
            // Methode qui retient une saisie clavier
            Console.WriteLine("Et tu excerce quel metier " + saisie );
            string saisieMetier = Console.ReadLine();
            Console.WriteLine("Woaw génial !" + saisie);
            Console.WriteLine("c'est un super metier" + saisieMetier);
            Console.ReadKey();
            Console.Clear();
        }

        // change le fond et la couleur du texte
        public void Fond()
        {            
           Console.BackgroundColor = ConsoleColor.Black;
           Console.ForegroundColor = ConsoleColor.Green;      
        }

        // affiche un menu pour lancer divers programme
        public void Application()
        {
            Console.WriteLine("Lancement Menu Applications");
            
            Console.WriteLine("Veuillez choisir une application a executer");
            Console.WriteLine("a : Le Juste Prix ");
            Console.WriteLine("b : Autre ");
            Console.WriteLine("Appuyez sur une autre touche pour terminer le programme");
            string choix = Console.ReadLine();
            switch (choix)
            {
                
                case "a":
                    Console.Clear();
                    Console.WriteLine("Lancement : Le Juste Prix");
                    
                    JustePrix j = new JustePrix();
                    j.Lancer();
                    break;

                case "b":
                    Console.WriteLine("Lancement :  ");
                    break;

                default:
                    Credits y = new Credits();
                    y.end();
                    break;
                    
                    

                                                           
            }
            
             


        }
    }

    // Générique de Fin Lewl \o/
    public class Credits
    {
        // méthode générique de fin
        public void end()
        {
            // Methods de fin
            Console.Clear();
            Console.WriteLine("merci d'avoir utiliser notre application");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Application : Who Are U ?! ");
            Console.WriteLine("By DBK "     +     " V.0.1.5.0");
            Console.ReadKey();
            Console.Clear();            
            Console.WriteLine("Appuyez sur une touche pour mettre fin au programme");
            Console.ReadKey();

        }
    }
}
// love me long time, long time, fucky fucky fucky fucky sunquan