using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WindowsFormsApp9
{
   public class Anket
    {
        public Anket(string filename, string name, string surname, string fatherName,
            string country, string city, string phonenumber, DateTime birthDate, string gender)
        {
            Filename = filename;
            Name = name;
            Surname = surname;
            FatherName = fatherName;
            Country = country;
            City = city;
            Phonenumber = phonenumber;
            BirthDate = birthDate;
            Gender = gender;
        }
        public string Filename { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Phonenumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }

    }
}
