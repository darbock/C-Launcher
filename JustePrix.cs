using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne
{
    public class JustePrix
    {
        public void Lancer()
        {
            Console.WriteLine("Application : Le Juste Prix ");

            Console.WriteLine("Trouvez le nombre generer par RNGesus : ");

            int rngesus = new Random().Next(0, 100);
            int essai = 0;
            bool trouve = false;
            while (!trouve)
            {
                string saisie = Console.ReadLine();
                int ValSaisie;
                if (int.TryParse(saisie, out ValSaisie))
                {
                    if (ValSaisie == rngesus)
                    {
                        trouve = true;
                        Console.WriteLine("Vous avez trouver !");
                        Console.WriteLine("Le nombre generer etait bien " + rngesus);
                        Console.WriteLine("Vous avez gagnez en " + essai + " essai");
                        Console.ReadKey();
                        Credits t = new Credits();
                        t.end();
                    }
                    else
                    {
                        if (ValSaisie < rngesus)
                        {
                            Console.WriteLine("Trop Petit");
                            
                        }
                        else
                        {
                            Console.WriteLine("Trop Grand");
                            
                        }
                        essai++;

                    }
                }
                else
                {

                    Console.WriteLine("Ce n'est pas un nombre");

                }

            }















            Console.ReadKey();
        }
    }
}
