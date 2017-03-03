using System;
      
namespace OOP_001_commence_of_paradigm
{
    class User
    {
        public DateTime BirthDay { set; get; }
        public int Id { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }

        public override string ToString()
        {
            return "{Id: " + Id + ", Name: " + Name + ", Email: " + Email + ", Birthday: " + BirthDay + "}";
        }
    }
}
