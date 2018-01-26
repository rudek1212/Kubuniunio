using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            var sport = new List<Sportowiec>();
            sport.Add(new Biegacz("Adam",'Z',300));
            sport.Add(new Biegacz("Robert",'F',876));
            sport.Add(new Biegacz("Zdzisław",'J',234));
            sport.Add(new Biegacz("Roman",'W',534));

            foreach (var sportowiec in sport)
            {
                Console.WriteLine(sportowiec.Zawody(5));
            }
            foreach (var sportowiec in sport)
            {
                Console.WriteLine(sportowiec);
            }
            sport.Reverse();

            var zawodnik = new Zawodnik();
            zawodnik.UstawCzas(352);
            Console.WriteLine(zawodnik.Medal());
            Console.WriteLine(zawodnik.Miejsce("Jerozolima"));
            /////////////////////////////////////////////////////////////////////////////
            try
            {
                var liczba = Convert.ToInt32(Console.ReadLine());
                new Zawodnik().UstawCzas(liczba);
            }
            catch (Exception e)
            {
                Console.WriteLine("No jakis błąd wywaliło no znowu to samo ja nie wiem");
            }

            Zawody.ZawodyCreate(5423);

            var lista = new ArrayList();
            lista.Add('X');
            lista.Add(14);
            lista.Add("Zdzisław");
            lista.Add(new Zawodnik());
            lista.Add(new int[3] {3, 5, 21});
            lista.Add(new string[4] {"adam", "ewa", "roman", "seweryn"});

            for (int i = 0; i <= lista.Count-1; i++)
            {
                if(i%2==1)
                    Console.WriteLine(lista[i]);
            }
            var linked = new LinkedList<char>();
            linked.AddFirst('a');
            linked.AddLast('b');
            linked.AddLast('c');
            linked.AddLast('d');
            linked.AddLast('e');

            Console.ReadKey();
        }

    }

    abstract class Sportowiec
    {
        protected string imie;
        protected char klub;

        public abstract string Zawody(int liczba);
    }

    class Biegacz : Sportowiec
    {
        public int rekord;

        public Biegacz(string imie, char klub, int rekord)
        {
            this.imie = imie;
            this.klub = klub;
            this.rekord = rekord;
        }

        public override string Zawody(int liczba)
        {
            string tekst = new string('k', liczba);
            return tekst;
        }

        public override string ToString()
        {
            return "Biegacz " + imie + " Klub: " + klub + " Rekord: " + rekord;
        }

        public int ZwrocRekord()
        {
            return rekord;
        }
    }

    interface IOlimpiada
    {
        int Miejsce(string miejsce);
        bool Medal();
    }

    class Zawodnik : IOlimpiada
    {
        private int czas;

        public bool Medal()
        {
            if (czas % 2 == 0) return false;
            return true; 
        }

        public int Miejsce(string miejsce)
        {
            return miejsce.Length;
        }

        public void UstawCzas(int czas)
        {
            this.czas = czas;
        }
    }

    class Zawody
    {
        private int iloscZawodnikow;

        private Zawody(int ilosc)
        {
            iloscZawodnikow = ilosc;
        }

        public static Zawody ZawodyCreate(int ilosc)
        {
            return new Zawody(ilosc);
        }
    }
}
