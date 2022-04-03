using System;

namespace kik
{
    class Program
    {
        static int wysokosc = 30;
        static int szerokosc = 30;
        public static string a = "1", b= "2", c= "3", d="4", e="5", f="6", g="7", h="8", i="9";
        public static void Klik(string l, ref string a, ref string b, ref string c, ref string d, ref string e, ref string f, ref string g, ref string h, ref string i)
        {
            Console.WriteLine("Jakie pole wybierasz?");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    if (!a.Equals("1"))
                    {
                        Console.WriteLine("Zajęte!");
                    }
                    else
                    {
                        Console.SetCursorPosition(5, 5);
                        Console.Write(l);
                        Console.SetCursorPosition(0, 35);
                        a = l;
                    }
                    break;
                case 2:
                    if (!b.Equals("2"))
                    {
                        Console.WriteLine("Zajęte!");
                    }
                    else
                    {
                        Console.SetCursorPosition(15, 5);
                        Console.Write(l);
                        Console.SetCursorPosition(0, 35);
                        b = l;
                    }
                    break;
                case 3:
                    if (!c.Equals("3"))
                    {
                        Console.WriteLine("Zajęte!");
                    }
                    else
                    {
                        Console.SetCursorPosition(25, 5);
                        Console.Write(l);
                        Console.SetCursorPosition(0, 35);
                        c = l;
                    }
                    break;
                case 4:
                    if (!d.Equals("4"))
                    {
                        Console.WriteLine("Zajęte!");
                    }
                    else
                    {
                        Console.SetCursorPosition(5, 15);
                        Console.Write(l);
                        Console.SetCursorPosition(0, 35);
                        d = l;
                    }
                    break;
                case 5:
                    if (!e.Equals("5"))
                    {
                        Console.WriteLine("Zajęte!");
                    }
                    else
                    {
                        Console.SetCursorPosition(15, 15);
                        Console.Write(l);
                        Console.SetCursorPosition(0, 35);
                        e = l;
                    }
                    break;
                case 6:
                    if (!f.Equals("6"))
                    {
                        Console.WriteLine("Zajęte!");
                    }
                    else
                    {
                        Console.SetCursorPosition(25, 15);
                        Console.Write(l);
                        Console.SetCursorPosition(0, 35);
                        f = l;
                    }
                    break;
                case 7:
                    if (!g.Equals("7"))
                    {
                        Console.WriteLine("Zajęte!");
                    }
                    else
                    {
                        Console.SetCursorPosition(5, 25);
                        Console.Write(l);
                        Console.SetCursorPosition(0, 35);
                        g = l;
                    }
                    break;
                case 8:
                    if (!h.Equals("8"))
                    {
                        Console.WriteLine("Zajęte!");
                    }
                    else
                    {
                        Console.SetCursorPosition(15, 25);
                        Console.Write(l);
                        Console.SetCursorPosition(0, 35);
                        h = l;
                    }
                    break;
                case 9:
                    if (!i.Equals("9"))
                    {
                        Console.WriteLine("Zajęte!");
                    }
                    else
                    {
                        Console.SetCursorPosition(25, 25);
                        Console.Write(l);
                        Console.SetCursorPosition(0, 35);
                        i = l;
                    }
                    break;
                default:
                    Console.WriteLine("Podaj poprawną liczbę!");
                    break;
            }
        }
        static public void Plansza()
        {
            Console.Clear();
            Console.SetCursorPosition(5, 5);
            Console.Write(a);
            for (int i = 1; i <= (szerokosc + 2); i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write("-");
            }
            Console.SetCursorPosition(15, 5);
            Console.Write(b);
            Console.SetCursorPosition(15, 5);
            for (int i = 1; i <= (szerokosc + 2); i++)
            {
                Console.SetCursorPosition(i, 10);
                Console.Write("-");
            }
            Console.SetCursorPosition(25, 5);
            Console.Write(c);
            for (int i = 1; i <= (szerokosc + 2); i++)
            {
                Console.SetCursorPosition(i, 20);
                Console.Write("-");
            }
            Console.SetCursorPosition(5, 15);
            Console.Write(d);

            Console.SetCursorPosition(15, 15);
            Console.Write(e);
            for (int i = 1; i <= (wysokosc + 1); i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("|");
            }
            Console.SetCursorPosition(25, 15);
            Console.Write(f);
            for (int i = 1; i <= (wysokosc + 1); i++)
            {
                Console.SetCursorPosition(10, i);
                Console.Write("|");
            }
            Console.SetCursorPosition(5, 25);
            Console.Write(g);
            for (int i = 1; i <= (wysokosc + 1); i++)
            {
                Console.SetCursorPosition(20, i);
                Console.Write("|");
            }
            Console.SetCursorPosition(15, 25);
            Console.Write(h);
            for (int i = 1; i <= (wysokosc + 1); i++)
            {
                Console.SetCursorPosition((szerokosc + 2), i);
                Console.Write("|");
            }
            Console.SetCursorPosition(25, 25);
            Console.Write(i);
            for (int i = 1; i <= (szerokosc + 2); i++)
            {
                Console.SetCursorPosition(i, (wysokosc + 2));
                Console.WriteLine("-");
            }
        }

        static public bool logika()
        {
            if (a.Equals(b) && b.Equals(c) || c.Equals(f) && f.Equals(i) || a.Equals(d) && d.Equals(g) || g.Equals(h) && h.Equals(i) || a.Equals(e) && e.Equals(i) || c.Equals(e) && e.Equals(g) || b.Equals(e) && e.Equals(h) || d.Equals(e) && e.Equals(f))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static void Main(string[] args)
        {
            while (logika() == true) { 
              Plansza();
                logika();
            Klik("X", ref a, ref b, ref c, ref d, ref e, ref f, ref g, ref h, ref i);
            Klik("O", ref a, ref b, ref c, ref d, ref e, ref f, ref g, ref h, ref i);
            Console.ReadKey();
        }
            Console.WriteLine("Koniec");
        }
    }
}
