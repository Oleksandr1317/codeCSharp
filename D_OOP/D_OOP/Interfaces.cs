using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    public interface IBaseCollectrion
    {
        void Add(object obj);
        void Remove(object obj);


    }
    public static class BaseCollectionExtencion
    {
        public static void AddRange(this IBaseCollectrion collection, IEnumerable<object> objects) // для создания метода-расширения
        // IEnumerable - позволяет по инстанциям делать foreach (может быть предан как лист,так стек и т.д)
        {
            foreach (var item in objects)
            {
                collection.Add(item);
            }
        }
    }

    public class BaseList : IBaseCollectrion
    {
        private object[] items;
        private int count = 0;
        public BaseList(int InicialCapacity)
        {
            items = new object[InicialCapacity];
        }
        
        public void Add(object obj)
        {
            items[count] = obj;
            count++;
        }

        public void Remove(object obj)
        {
            items[count] = null;
            count--;
        }
    }
}