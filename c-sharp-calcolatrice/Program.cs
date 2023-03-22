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
            numeri.Add(nuovoNumero); // pushiamo il nuovo numero all'interno dell'array

            Console.WriteLine("Vuoi inserire un altro numero? (y/n)");
            domanda = Console.ReadLine();
        }

        Console.WriteLine("Che operazione vuoi fare? ('+' / '-' / '*' / '/' ");
        string operatore = Console.ReadLine();

        if(operatore == "+") {
            Console.WriteLine(Somma(numeri));
        }
        else if(operatore == "-")
        {
            Console.WriteLine(Sottrazione(numeri));
        }
        else if(operatore == "/")
        {
            Console.WriteLine(Divisione(numeri));
        }
        else
        {
            Console.WriteLine(Moltiplicazione(numeri));
        }

    }
    static int Somma(List<int> numeri)
    {
        int addizione = 0 ;
        foreach (int i in numeri)
        {
            addizione += i;
        }
        return addizione;
    }

    static int Sottrazione(List<int> numeri)
    {
        int sottrazione = numeri[0] ;
        for(int i = 1;i < numeri.Count; i++)
        {
            sottrazione -= numeri[i] ;
        }
        return sottrazione;
    }

    static int Divisione(List<int> numeri)
    {
        int divisione = numeri[0];
        for (int i = 1; i < numeri.Count; i++)
        {
            divisione /= numeri[i];
        }
        return divisione;
    }

    static int Moltiplicazione(List <int> numeri)
    {
        int moltiplicazione = numeri[0] ;
        for (int i = 1; i < numeri.Count; i++)
        {
            moltiplicazione *= numeri[i] ;
        }
        return moltiplicazione;
    }
}