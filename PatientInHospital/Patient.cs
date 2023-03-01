using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInHospital
{
    internal class Patient
    {
        public string Name;
        public int Age;
        public GenderType Gender;
        public string Adress;
        
        public enum GenderType
        {
            Male = 0,
            Female = 1,
            Other = 2
        }

        public Patient(string name = "Ivanov Ivan", int age = 20, GenderType gender = GenderType.Male, string adress = "selo V.Perduncy" )
        {
            Name = name;
            Age = age;
            Gender = gender;
            Adress = adress;
            
        }

        public void PrintPatientInfo ()
        {
            Console.WriteLine($"Name: {Name}\nAge: {Age}\nGender: {Gender}\nAdress: {Adress}\n");
            Console.WriteLine("------------------------\n");
        }
    }
}
