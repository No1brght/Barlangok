using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http.Headers;

namespace Barlangok
{
    class Barlang
    {
        private int Hossz = 0;
        private int Melyseg = 0;
        public int azon { get; private set; }
        public string Nev { get; private set; }
        public string Telepules { get; private set; }
        public string Vedettseg { get; private set; }
        public int hossz
        {
            get { return Hossz; }
            set { if (value >= Hossz) Hossz = value; }
        }

        public int melyseg
        {
            get { return Melyseg; }
            set { if (value >= Melyseg) Melyseg = value; }
        }

        public Barlang(string sor)
        {
            try
            {
                string[] s = sor.Split(';');
                azon = int.Parse(s[0]);
                Nev = s[1];
                Telepules = s[4];
                Vedettseg = s[5];
                Hossz = int.Parse(s[2]);
                Melyseg = int.Parse(s[3]);
            }
            catch (Exception) 
            { 
                hossz = 0;
            }
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Barlang> barlangok = new List<Barlang>();

            StreamReader sr = new StreamReader("barlangok.txt", Encoding.UTF8);

            while (sr.EndOfStream)
            {
                Barlang tmp = new Barlang(sr.ReadLine());
        
                    if (tmp.hossz != 0)
                    {
                        barlangok.Add(tmp);
                    }
            }

            Console.ReadKey();
        }
    }
}
