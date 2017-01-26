using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DinamikusLista
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream("adat.txt", FileMode.Open);
            StreamReader Be = new StreamReader(file);

            List<int> tomb = new List<int>();

            while (!Be.EndOfStream)
            {
                int szam = Convert.ToInt32(Be.ReadLine());
                tomb.Add(szam);
            }

            Be.Close();
            file.Close();

            int osszeg = 0;
            //for (int i = 0; i < tomb.Count; i++)
            //{
            //    Console.WriteLine(tomb[i]);
            //    osszeg = osszeg + tomb[i];
            //}
            foreach (int sz in tomb)
            {
                Console.WriteLine(sz);
                osszeg = osszeg + sz;
            }

            Console.WriteLine("Az elemek száma: {0}",tomb.Count);
            Console.WriteLine("Az elemek összege: {0}",osszeg);

            Console.ReadLine();
        }
    }
}
