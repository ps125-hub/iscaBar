using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace iscaBar.Helpers
{
    public class Collection
    {
        public static int SearchById<T>(IEnumerable<T> coleccio,T element)
        {
            int pos = 0;
            bool hayMas;
            IEnumerator<T> item=coleccio.GetEnumerator();
            while(hayMas = item.MoveNext())
            {
                T current = (T)item.Current;
                if (element.Equals(current)) break;
                pos++;
            }
            if (hayMas)
            {
                return pos;
            }
            else
            {
                return -1;
            }


        }
    }
}
