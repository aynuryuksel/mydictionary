using System;
using System.Collections.Generic;
using System.Text;

namespace mydictionary
{
    class Mydictionary<Tkey,Tvalue>
    {
        Tkey[] tkey;
        Tvalue[] tvalue;

        Tkey[] temptkey;
        Tvalue[] temptvalue;
        public Mydictionary()
        {
            tkey = new Tkey[0];
            tvalue = new Tvalue[0];

        }

        public void Add(Tkey id, Tvalue val) {
            
            temptkey = new Tkey[tkey.Length+1];
            temptvalue = new Tvalue[tvalue.Length+1];
            temptkey = tkey;
            temptvalue = tvalue;

            for(int i = 0; i < temptkey.Length; i++)
            {
              
                tkey[i] = temptkey[i];
                tvalue[i] = temptvalue[i];
                tkey[tkey.Length - 1] = id;
                tvalue[tvalue.Length - 1] = val;
            }
            
            Console.WriteLine("Eklenen id=" + id  + "\nEklenen isim= " + val);
        }
    }
}
