using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableaux2D
{
    class Program
    {
        static int[,] MonTableau(int[,] Tab)
        {
            int[,] CopieTab = new int[Tab.GetLength(0), Tab.GetLength(1)];
            for (int i = 0; i < Tab.GetLength(0); i++)
            {
                for (int j = 0; j < Tab.GetLength(1); j++)
                {
                    CopieTab[i, j] = Tab[i, j];
                    Console.Write(CopieTab[i, j] + " ");
                }
                Console.WriteLine(" "); // pour aller à la ligne 
            }
            return CopieTab;
        }

        static char[,] TabLigne()
        {
            char[,] TabEtoile = new char[5, 7];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i == 2)
                    {
                        TabEtoile[2, j] = '*';
                        Console.Write(TabEtoile[i, j] + " ");
                    }
                    else
                    {
                        TabEtoile[i, j] = '.';
                        Console.Write(TabEtoile[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }

            return TabEtoile;
        }

        static char[,] TabColonne()
        {
            char[,] TabEtoile = new char[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == 2)
                    {
                        TabEtoile[i, 2] = '*';
                        Console.Write(TabEtoile[i, j] + " ");
                    }
                    else
                    {
                        TabEtoile[i, j] = '.';
                        Console.Write(TabEtoile[i, j] + " ");
                    }
                }
                Console.WriteLine(" ");
            }
            return TabEtoile;
        }

        static char [,] TabDiagonale1()
        {
            char[,] TabEtoile = new char[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j)
                    {
                        TabEtoile[i, j] = '*';
                        Console.Write(TabEtoile[i, j] + " ");
                    }
                    else
                    {
                        TabEtoile[i, j] = '.';
                        Console.Write(TabEtoile[i,j] + " ");
                    }
                }
                Console.WriteLine(" ");
            }
            return TabEtoile;
        }

        static char [,] TabDiagonaleInversee()
        {
            char[,] TabEtoile = new char[5, 5];

            for (int i = 0; i<5; i++)
            {
                for (int j = 5-1; j >= 0; j--)
                {
                    if (i == j)
                    {
                        TabEtoile[i, j] = '*';
                        Console.Write(TabEtoile[i,j] + " ");
                    }
                    else
                    {
                        TabEtoile[i, j] = '.';
                        Console.Write(TabEtoile[i,j] + " ");
                    }
                }
                Console.WriteLine(" ");
            }
            return TabEtoile;
        }

        static char[,] TabDoubleDiago();

        static void Main(string[] args)
        {
            int ligne, colonne, valeur = 3;
            string a, s;

            Console.WriteLine("Veuillez introduire un numéro de ligne :");
            s = Console.ReadLine();
            ligne = int.Parse(s);

            Console.WriteLine("Veuillez introduire un numéro de colonne :");
            a = Console.ReadLine();
            colonne = int.Parse(a);


            int[,] Tab2D = new int[ligne, colonne];

            for (int i = 0; i < ligne; i++)
            {
                for (int j = 0; j < colonne; j++)
                {
                    Tab2D[i, j] = valeur++;
                }
            }

            MonTableau(Tab2D);

            TabLigne();
            Console.WriteLine(" ");
            TabColonne();
            Console.WriteLine(" ");
            TabDiagonale1();
            Console.WriteLine(" ");
            TabDiagonaleInversee();
            Console.WriteLine(" ");
            TabDoubleDiago();
        }
    }
}
