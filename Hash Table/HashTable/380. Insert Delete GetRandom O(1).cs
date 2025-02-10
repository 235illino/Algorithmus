using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/insert-delete-getrandom-o1/
namespace HashTable
{
    public class RandomizedSet
    {
        private Dictionary<int, int> dic;
        private List<int> list;
        private int count;

        public RandomizedSet()
        {
            dic = new();
            list = new();
            count = 0;
        }

        public bool Insert(int val)
        {
            if (dic.ContainsKey(val))
                return false;

            dic.Add(val, list.Count);
            list.Add(val);

            return true;
        }

        public bool Remove(int val)
        {
            if (!dic.TryGetValue(val, out int value)) return false;

            if (value != list.Count - 1)
                list[value] = list[^1];

            dic[list[^1]] = value;
            list.RemoveAt(list.Count - 1);
            dic.Remove(val);
            return true;
        }

        public int GetRandom()
        {
            return list[new Random().Next(list.Count)];
        }
    }
}
