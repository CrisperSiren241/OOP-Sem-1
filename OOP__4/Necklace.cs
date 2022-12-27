using System;
using System.Collections;
using System.ComponentModel;
using System.Text.Json;

namespace OOP__4
{
    [Serializable]
    public class Necklace
    {
        object[] List = new object[3];

        public Necklace() { }

        public void Add(object elem)
        {
            if (List[0] == null)
            {
                List[0] = elem;
            }
            else
            {
                for(int i=List.Length; i < List.Length; i++)
                {
                    List[List.Length+1] = elem;
                }
            }
        }

        public void Remove(object elem, int position)
        {
            for(int i=position; i < List.Length; i++)
            {
                List[i] = List[i + 1];
            }
        }

        public void Print()
        {
            foreach(object elem in List)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
