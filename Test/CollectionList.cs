using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class CollectionList
    {
        private string employee;
        private string post;
        private int age;
        private decimal salary;

        public CollectionList(string employee, string post, int age, decimal salary)
        {
            this.employee = employee;
            this.post = post;
            this.age = age;
            this.salary = salary;
        }

        public string Name
        {
            get { return employee; }
            set { employee = value; }
        }

        public string Post
        {
            get { return post; }
            set { post = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
