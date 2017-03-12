using System;
      
namespace OOP_001_commence_of_paradigm
{
    class User
    {
        public int Id { set; get; }                
        public string Name { set; get; }
        public string Email { set; get; }
        public DateTime BirthDay { set; get; }

        /// <summary>
        /// Returns string representation of the User:
        /// property values splited by semicolumn.
        /// </summary>
        /// <returns>String in format Id;Name;Email;Birthday</returns>
        public override string ToString()
        {
            return Id + ";" + Name + ";" + Email + ";" + BirthDay;
        }
    }
}
