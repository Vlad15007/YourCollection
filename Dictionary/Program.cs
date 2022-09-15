using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MegaDuctuionary<int, string> myDick = new MegaDuctuionary<int, string>(
                    new KeyValuePair<int, string>(11, "Привет"),
                    new KeyValuePair<int, string>(12, "Пока"));



            foreach (var item in myDick)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

    class MegaDuctuionary<Key, Value>
    {
        KeyValuePair<Key, Value>[] massiv;

        public MegaDuctuionary(params KeyValuePair<Key, Value>[] znachenia)
        {
            massiv = znachenia;

        }

        public MegaDuctuionary<Key, Value> GetEnumerator()
        {
            return this;
        }

        public KeyValuePair<Key, Value> Current
        {
            get 
            { 
                return massiv[position]; 
            }
        }


        int position = -1;
        public bool MoveNext()
        {
            if (position < massiv.Length - 1)
            {
                position++;
                return true;
            }
            position = -1;
            return false;
        }
    }
}
