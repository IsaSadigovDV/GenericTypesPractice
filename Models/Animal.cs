using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes.Models
{
    internal class Animal<T> where T : class, new()
    {
        List<T> list = new List<T>();

        public void Create(T t)
        {
            list.Add(t);
        }

        public void Remove(T t)
        {
            list.Remove(t);
        }

        public void Show(T t)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }

        internal void Create(object t)
        {
            throw new NotImplementedException();
        }
    }
}
