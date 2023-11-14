using School.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Classes.Abstract
{
    internal abstract class Human : IHuman
    {
        protected int _id;
        protected string _fullName;
        protected string _address;
        protected string _phone;
        public int Id { get { return _id; } }
        public string FullName { get { return _fullName; } }
        public string Address { get { return _address; } }
        public string Phone { get { return _phone; } }
        public Human(int id, string fullName, string address)
        {
            _id = id;
            _fullName = fullName;
            _address = address;
            _phone = "+380" + GetPhone();
        }
        public override string ToString()
        {
            return $"{_fullName}\n" +
                   $"{_phone}\n";
        }
        string GetPhone()
        {
            Random random = new Random();
            string result = "";

            for (int i = 0; i < 9; i++)
            {
                result += random.Next(0, 10); // Generates a random digit from 0 to 9
            }
            return result;
        }
    }
}
