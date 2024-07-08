// See https://aka.ms/new-console-template for more information
using System;
using System.Linq.Expressions;

/*void Identite(int age,int departement,int ageProchain,string prenom ,string nom,string nationalite)
{

    
    Console.WriteLine($"Bonjour je m'appelle " + prenom + "" +nom + " je suis " + nationalite + "\n j'ai " + age + " ans. J'habite dans le departument du "
        + departement + ", l'an prochain j'aurai " + ageProchain);

}

Identite(20, 59, (20+1), "fatima","borgh","française");*/



//je lance un fonction calculator afin de creer
    static void Calculator(string[]args) 
//calculator le nom de ma fonction, (string[]args) ici j'indique les parametres
//qui sera un tableau de chaine de caractère)
{
    string valeur;
    //je declare une variable à laquelle je n'affecte pas de valeur ici

    /* l'idée ici est de creer un switch case dans la fonction  */  

    do
    {
        
        Console.WriteLine("entrez un nombre: ");
        int nbrUn = int.Parse(Console.ReadLine());

        Console.WriteLine("Entrez un autre nombre");
        int nbrDeux = int.Parse(Console.ReadLine());

        Console.WriteLine("Entrez symboles ( +, -, /, *) :");
        string symbole = Console.ReadLine();

        int resultat;
        switch (symbole)
           
        {
            case "+":

                resultat = nbrUn + nbrDeux;
                Console.WriteLine("Addition" + resultat);

                break;

            case "-":
                 
                resultat = nbrUn - nbrDeux;
                Console.WriteLine("Soustraction" + resultat);

                break;

            case "*":

                resultat = nbrDeux * nbrUn;
                Console.WriteLine("Multiplication" + resultat);
                break;


            case "/":

                resultat = nbrUn / nbrDeux;
                Console.WriteLine("Division" + resultat);
                break;

            default:
                Console.WriteLine("mauvaise rentrée");
                break;
        }
        Console.ReadLine();

        
    }

        
}




 
