using System;

namespace OOP_001_commence_of_paradigm
{
    class User
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public DateTime BirthDay { set; get; }

        public override Boolean Equals(Object o)
        {
            if (this == o) return true;
            if (o == null || this.GetType() != o.GetType()) return false;

            User user = (User)o;

            if (Id != user.Id) return false;
            if (Name != null ? !Name.Equals(user.Name) : user.Name != null) return false;
            if (Email != null ? !Email.Equals(user.Email) : user.Email != null) return false;
            return BirthDay != null ? BirthDay.Equals(user.BirthDay) : user.BirthDay == null;
        }

        public override int GetHashCode()
        {
            int result = Id;
            result = 31 * result + (Name != null ? Name.GetHashCode() : 0);
            result = 31 * result + (Email != null ? Email.GetHashCode() : 0);
            result = 31 * result + (BirthDay != null ? BirthDay.GetHashCode() : 0);
            return result;
        }
        
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
