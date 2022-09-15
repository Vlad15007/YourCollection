using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<Stolbec> list = new MyList<Stolbec>();

            foreach (var item in list)
            {
                item.Id = 123;
            }
        }
    }

    class Stolbec
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class MyList<Type> 
    {

        Type[] massiv = new Type[0];

        public MyList()
        {
                
        }

        public MyList<Type> GetEnumerator()
        {
            return this;
        }

        int position = -1;
        public bool MoveNext()
        {
            if( position < massiv.Length)
            {
                position++;
                return true;
            }
            position = -1;
            return false;
        }

        public Type Current
        {
            get
            {
                return massiv[position];
            }
        }
    }
}
