using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            string commande;
            Repertoire C = new Repertoire("C:", null);
            Fichier fileCurrent = C;
            string [] listcommande;
                
            for (int i = 0; i < i + 2; i++)
            {
                //Ajouter la ligne d'en dessous si l'on veut afficher à chaque fois le chemin complet d'ou l'on est
                //sConsole.Write(fileCurrent.getPath()+"\\>");
                commande = Console.ReadLine();
                listcommande = commande.Split(' ');

               
                if (listcommande[0] == "parent" && listcommande.Count() == 1 && fileCurrent !=C)
                {
                        fileCurrent = fileCurrent.getParent();     
                } 
                else if (listcommande[0] == "create" && listcommande.Count()==2)
                {
                        Console.WriteLine(fileCurrent.createNewFile(listcommande[1]));
                }
                else if (listcommande[0] == "delete" && listcommande.Count() == 2)
                {
                        Console.WriteLine(fileCurrent.delete(listcommande[1]));
                }
                else if (listcommande [0] == "mkdir" && listcommande.Count()==2)
                {
                        Console.WriteLine(fileCurrent.mkdir(listcommande[1]));
                }
                else if (listcommande[0] == "file" && listcommande.Count() == 1)
                {
                        Console.WriteLine(fileCurrent.isfile());
                }
                else if (listcommande [0] == "directory" && listcommande.Count()==1)
                {
                        Console.WriteLine(fileCurrent.isDirectory());
                }
                else if (listcommande[0] == "ls" && listcommande.Count() == 1)
                {
                        fileCurrent.ls();
                }
                else if (listcommande[0] == "search" && listcommande.Count() == 2)
                {
                    fileCurrent.search(listcommande[1]);
                    //if (fileCurrent.canRead())
                    //{
                    //    foreach (Fichier fichier in fileCurrent.search(listcommande[1]))
                    //    {
                    //        if (fileCurrent.canRead())
                    //        {
                    //            Console.WriteLine("Nom du fichier recherché: " + fichier.Nom + "\nChemin: " + fichier.getPath());
                    //        }
                    //        else
                    //        {
                    //            Console.WriteLine("Vous n\'avez pas les droits pour lire à partir de ce fichier (canRead => chmod 4/5/6/7)");
                    //        }
                    //    }
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Vous n\'avez pas les droits pour lire à partir de ce fichier (canRead => chmod 4/5/6/7)");
                    //}
                }
                else if (listcommande[0] == "rename" && listcommande.Count() == 3)
                {
                        Console.WriteLine(fileCurrent.renameTo(listcommande[1], listcommande[2]));
                }
                else if (listcommande[0] == "name" && listcommande.Count() == 1)
                {
                        Console.WriteLine(fileCurrent.getName());
                }
                else if (listcommande[0] == "path" && listcommande.Count() == 1)
                {
                    Console.WriteLine(fileCurrent.getPath());
                }
                else if (listcommande[0] == "cd" && listcommande.Count() == 2)
                {
                    fileCurrent = fileCurrent.cd(listcommande[1]);
                }
                else if (listcommande[0] == "chmod" && listcommande.Count() == 2)
                {
                    fileCurrent.chmod(listcommande[1]);
                }
                else if (listcommande[0] == "root" && listcommande.Count() == 1)
                {
                    Console.WriteLine("Fichier racine: "+fileCurrent.getRoot());
                }
                else
                {
                    Console.WriteLine("Saisie invalide ou commande non comprise, veuillez réessayer.");
                }
            }
        }
    }
}
