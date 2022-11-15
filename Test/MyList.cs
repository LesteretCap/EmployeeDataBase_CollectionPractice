using System;
using System.Collections;
using System.Collections.Generic;

namespace Test
{
    internal class MyList : IEnumerable, IEnumerator
    {
        CollectionList[] collection = null;

        public MyList()
        {
            collection = new CollectionList[4];
            collection[0] = new CollectionList("Kamil", "Team Lead", 26, 500000);
            collection[1] = new CollectionList("Renat", "Middle", 26, 200000);
            collection[2] = new CollectionList("Bulat", "Junior", 26, 60000);
            collection[3] = new CollectionList("Kirill", "Intern", 26, 10000);
        }

        private int position = -1;

        public object Current { get => collection[position]; }

        public bool MoveNext()
        {
            if (position < collection.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public string this[int index]
        {
            get 
            {
                if (index <= 0)
                {
                    index = 1;
                }
                else if(index >= collection.Length)
                {
                    index = collection.Length;
                }

                index--;
                return $"Name: {collection[index].Name}, Post: {collection[index].Post}, Age: {collection[index].Age}, Salary: {collection[index].Salary}."; 
            }
        }

        public void AddEmployee(string name, string post, int age, decimal salary)
        {
            Array.Resize(ref collection, collection.Length + 1);

            collection[collection.Length - 1] = new CollectionList(name, post, age, salary);
        }

        public void GetLength()
        {
            Console.WriteLine("Number of employees: {0}", collection.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }
    }
}
