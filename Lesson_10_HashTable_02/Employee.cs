using System;

namespace Lesson_10_HashTable_02
{
    class Employee
    {
        private int _id;
        private string _firstName { get; set; }
        private string _lastName { get; set; }
        private DateTime _birthdate { get; set; }

        public Employee()
        {

        }
        public Employee(int id, string name)
        {
            this._id = id;
            string[] s = name.Split(' ');
            _firstName = s[0];
            _lastName = s[1];
            Console.WriteLine("The new employee has been created!\n" + _lastName + ", " + _firstName);
        }
        public int GetID()
        {
            return this._id;
        }
        public string GetName()
        {
            return this._firstName + " " + this._lastName;
        }
    }
}