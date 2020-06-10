using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LinqExample
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private string id;
        private int salary;
        private int winningCount;
        private EnumPlayerType enumPlayerType;
       
        public Person(string firstName, string lastName, int age, EnumPlayerType enumPlayer)
        {
            this.id = Guid.NewGuid().ToString();
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.EnumPlayerType = enumPlayer;
            this.WinningCount = 0;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public string Id { get => id; set => id = value; }
        public int Salary { get => salary; set => salary = value; }
        public int WinningCount { get => winningCount; set => winningCount = value; }
        public EnumPlayerType EnumPlayerType { get => enumPlayerType; set => enumPlayerType = value; }


        public override string ToString()
        {
            //return String.Format("first name {0} last name {1} enum player type {2} winning count {3}", firstName, lastName, enumPlayerType.ToString(), winningCount);
            return $"first name {firstName} last name {lastName} enum player type {enumPlayerType.ToString()} winning count {winningCount}";
        }
    }
}
