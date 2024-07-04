using System.Xml.Serialization;

namespace Person
{
    public struct person
    {
        public  string Name { get; set; }
        public int Age { get; set; }

        public person(string name , int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public override string ToString()
        {
            return $"Your Name Is {Name} And Your Age Is {Age}";
        }
    }
}
