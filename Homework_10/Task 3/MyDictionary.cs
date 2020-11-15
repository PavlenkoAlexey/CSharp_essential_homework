using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    class MyDictionary<TKey, TValue>
    {
        private List<TKey> keys = new List<TKey>();
        private List<TValue> values = new List<TValue>();

        public int Count => values.Count; // получение общего кол-ва элементов
        public TValue this[TKey index] // получение эл-та по указанному индексу
        {
            get
            {
                for (int i = 0; i < keys.Count; i++)
                {
                    if (keys[i].Equals(index))
                        return values[i];
                }
                return default;
            }
        }

        public void AddNewPair(TKey key, TValue value) // добавление новой пары элементов
        {
            keys.Add(key);
            values.Add(value);
        }

    }
}
