using System;

class Program
{
    static void Main(string[] args)
    {   
        List<int> numeri = new List<int>(); //conserviamo i numeri inseriti dall'user

        Console.WriteLine("Inserisci il primo numero");
        int x = Convert.ToInt32(Console.ReadLine());
        
        numeri.Add(x); //aggiungiamo x all'array

        Console.WriteLine("Inserisci il secondo numero");
        int y = Convert.ToInt32(Console.ReadLine());

        numeri.Add(y);//aggiungiamo y all'array
        Console.WriteLine("Vuoi inserire un altro numero? (y/n)");

        string domanda = Console.ReadLine(); //chiediamo all'user se vuole inserire altri numeri


        while (domanda == "y")
        {
            Console.WriteLine("Inserisci altro numero");
            int nuovoNumero = Convert.ToInt32(Console.ReadLine());
            numeri.Add(nuovoNumero);
            Console.WriteLine("Vuoi inserire un altro numero? (y/n)");
            domanda = Console.ReadLine();
        }

 

    }
}