using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    public class Fichier
    {
        public String Nom;
        public int Permission;
        public Repertoire Parent;

        public Fichier(String Nom, Repertoire Parent)
        {
            this.Nom = Nom;
            this.Parent = Parent;
            Permission = 4;
        }

        public bool canWrite()
        {
            return (Permission & 2) > 0;
        }
        public bool canExecute()
        {
            return (Permission & 1) > 0;
        }
        public bool canRead()
        {
            return (Permission & 4) > 0;
        }
        public virtual bool createNewFile(string Nom)
        {
            return false;
        }
        public virtual bool mkdir(string Nom)
        {
            return false;
        }
        public virtual bool delete(string Nom)
        {
            return false;
        }
        public virtual List<Fichier> ls()
        {
            Console.WriteLine("Vous êtes dans le fichier: " + this.Nom + "\nIl n'y a pas de fichier(s) dans un fichier");
            return null;
        }
        public string getName()
        {
            if (this.canRead())
            {
                return this.Nom;
            }
            else
            {
                //Console.WriteLine("Vous n\'avez pas les droits pour lire à partir de ce fichier (canRead => chmod 4/5/6/7)");
                return null;
            }
        }
        public virtual bool renameTo(string Nom, string newNom)
        {
            return false;
        }
        public virtual bool isfile()
        {
            return true;
            //if (this.canRead())
            //{
            //    return true;
            //}
            //else
            //{
            //    return null??;  Console.WriteLine("Vous n\'avez pas les droits pour savoir si c'est un fichier (canRead => chmod 4/5/6/7)");x   
            //}
        }
        public virtual bool isDirectory()
        {
            return false;
            //if (this.canRead())
            //{
            //    return false;
            //}
            //else
            //{
            //    return null??; Console.WriteLine("Vous n\'avez pas les droits pour savoir si c'est un fichier (canRead => chmod 4/5/6/7)");
            //}
        }
        public string getPath()
        {
            string path = this.Nom;
            //on donne le parent initial du fichier
            Repertoire Parents = Parent;
            while (Parents != null)
            {
                path = Parents.Nom + "\\" + path;
                Parents = Parents.Parent;
            }
            //on reprend le parent initial du fichier
            //Parent = Parents;
            return path;
        }
        public string getRoot()
        {
            if (this.canRead() && this.Parent != null)
            {
                string root = "Vous êtes déjà dans un fichier racine";
                //on créé un parent temporaire (qui sera réutilisé à chaque appel de fonction et réinitialisé au parent du fichier courant
                Repertoire Parent2 = Parent;
                while (Parent2.Nom != "C:")
                {
                    root = Parent2.Nom;
                    Parent2 = Parent2.Parent;
                }
                return root;
            }
            else
            {
                //Console.WriteLine("Vous n\'avez pas les droits pour connaître le fichier root (canRead => chmod 4/5/6/7)");
                return null;
            }
            
        }
        public Fichier getParent()
        {
            if (this.canRead())
            {
                return Parent;
            }
            else
            {
                return null;
                //Console.WriteLine("Vous n\'avez pas les droits pour avoir le parent (canRead => chmod 4/5/6/7)");
            }
        }

        public virtual Fichier cd(string Nom)
        {
            return this;
        }
        public bool chmod(string Permission)
        {
            int newPermission;
            bool result = Int32.TryParse(Permission, out newPermission);
            if (1 <= newPermission && newPermission <= 7 && result == true)
            {
                this.Permission = int.Parse(Permission);
                return true;
            }
            //Console.WriteLine("Veuillez entrer un chiffre entre 1 et 7");
            return false;
        }
        public virtual List<Fichier> search(string Nom)
        {
            return null;
        }

    }
}
