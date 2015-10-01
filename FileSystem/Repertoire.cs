using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    public class Repertoire : Fichier
    {

        List<Fichier> fichieR = new List<Fichier>();

        public Repertoire(String Nom, Repertoire parent): base (Nom, parent)
        {
            Permission = 4;
        }
        public override bool mkdir(string Nom)
        {
            bool exist = false;

            for (int i = 0; i < fichieR.Count() && exist == false; i++)
            {
                exist = Nom == fichieR[i].Nom;
            }
            if (this.canWrite() && exist == false)
            {
                fichieR.Add(new Repertoire(Nom, this));
                return true;
            }
            return false;
            //Console.WriteLine("Vous n\'avez pas les droits pour créer un répertoire ici (canWrite => chmod 2/3/6/7)");
            
        }
        public override List<Fichier> ls()
        {
            if (this.canRead() && this.fichieR != null)
            {
                    foreach (Fichier item in this.fichieR)
                    {
                        Console.WriteLine(item.Nom + " (" + item.GetType() + ") " + item.Permission);
                    }
                    return null;
            }
            else
            {
                //Console.WriteLine("Vous n\'avez pas les droits pour lire (canRead => chmod 4/5/6/7)");
                return null;
            }
        }
        public override bool createNewFile(string Nom)
        {
            bool exist = false;

            for (int i = 0; i < fichieR.Count() && exist == false; i++)
            {
                exist = Nom == fichieR[i].Nom;
            }
            if (this.canWrite() && exist == false)
            {
                fichieR.Add(new Fichier(Nom, this));
                return true;
            }
            return false;
            //Console.WriteLine("Vous n\'avez pas les droits pour créer un fichier ici (canWrite => chmod 2/3/6/7) ou le fichier existe déjà)");
        }
        public override bool renameTo(string Nom, string NewNom)
        {
            bool exist = false;
            int j = 0;
            for (int i = 0; i < fichieR.Count() && exist == false; i++)
            {
                exist = Nom == fichieR[i].Nom;
                if (exist == true)
                {
                    j = i;
                }
            }
            if (this.canWrite() && exist == true)
            {
                bool exist2 = false;
                for (int k = 0; k < fichieR.Count() && exist2 == false; k++)
                {
                    exist2 = NewNom == fichieR[k].Nom;
                }
                if (exist2 == false)
                {
                    
                    fichieR[j].Nom = NewNom;
                    return true; 
                }
            }
            //Console.WriteLine("Vous n\'avez par les droits pour écrire (canWrite => chmod 2/3/6/7");
            return false;
        }

        public override bool delete(string Nom)
        {
            bool exist = false;
            int j =  0;
            for (int i = 0; i < fichieR.Count() && exist == false; i++)
            {
                exist = Nom == fichieR[i].Nom;
                if (exist == true)
                {
                    j = i;
                }
            }
            if (this.canWrite() && exist == true)
            {
                this.fichieR.Remove(fichieR[j]);
                return true;
            }
            else
            {
                return false;
            }
            //Console.WriteLine("Vous n\'avez pas les droits pour supprimer ici (canWrite => chmod 2/3/6/7)");
        }
        public override bool isfile()
        {
            return false;
            //if (this.canRead())
            //{
            //    return false;
            //}
            //else
            //{
            //    return ??; Console.WriteLine("Vous n\'avez pas les droits pour savoir si c'est un fichier (canRead => chmod 4/5/6/7)");
            //}
            //
        }

        public override bool isDirectory()
        {
            return true;
            //if (this.canRead())
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;  Console.WriteLine("Vous n\'avez pas les droits pour savoir si c'est un fichier (canRead => chmod 4/5/6/7)");x   
            //}
        }
        public override Fichier cd(string Nom)
        {
            if (this.canRead())
            {
                //On créé un fichier qui deviendra le nouveau fichier courant
                //On initialise au fichier courant pour éviter le renvoie d'un fichier courant null quand on fait un cd sur un fichier/répertorie qui n'existe pas.
                Fichier newFileCurrent = this;
                bool change = false;
                for (int i = 0; change == false && i < fichieR.Count; i++)
                {
                    if (fichieR[i].Nom == Nom && fichieR[i].canRead() && change == false)
                    {
                        newFileCurrent = fichieR[i];
                        change = true;
                    }
                }
                return newFileCurrent;
            }
            else
            {
                //Console.WriteLine("Vous n\'avez pas les droits pour rentrer dans un fichier à partir de celui-ci (canRead => chmod 4/5/6/7)");
                return null;
            }
        }
        public override List<Fichier> search(string name)
        {
            if (this.canRead())
            {
                foreach (Fichier fichier in this.fichieR)
                {
                        List<Fichier> fichiersearch = new List<Fichier>();
                        for (int i = 0; i < fichieR.Count(); i++)
                        {
                            if (fichieR[i].Nom == name)
                            {
                                fichiersearch.Add(fichieR[i]);
                            }
                            //Si c'est un répertoire, on rappel la fonction pour rechercher dans les fichiers de celui-ci.
                            if (fichieR[i].isDirectory() == true)
                            {
                                fichiersearch.AddRange(fichieR[i].search(name));
                            }
                        }
                        //Console.WriteLine("Nom du fichier recherché: " + fichier.Nom + "\nChemin: " + fichier.getPath());
                        return fichiersearch;
                }
                //Console.WriteLine("Vous n\'avez pas les droits pour lire à partir de ce fichier (canRead => chmod 4/5/6/7)");
                return null;
            }
            else
            {
                //Console.WriteLine("Vous n\'avez pas les droits pour lire à partir de ce fichier (canRead => chmod 4/5/6/7)");
                return null;
            }
            //List<Fichier> fichiersearch = new List<Fichier>();
            //for (int i = 0; i < fichier.Count(); i++)
            //{
            //    if (fichier[i].Nom == name)
            //    {
            //        fichiersearch.Add(fichier[i]);
            //    }
            //    //Si c'est un répertoire, on rappel la fonction pour rechercher dans les fichiers de celui-ci.
            //    if (fichier[i].isDirectory() == true)
            //    {
            //        fichiersearch.AddRange(fichier[i].search(name));
            //    }
            //}
            //return fichiersearch;
        }
    }
}
