using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInHospital
{
    internal class Patient
    {
        public string name;
        public int age;
        public Gender gender;
        public string adress;
        
        public enum Gender
        {
            Male = 0,
            Female = 1,
            Other = 2
        }

        public Patient(string name = "Ivanov Ivan", int age = 20, Gender gender = Gender.Male, string adress = "selo V.Perduncy" )
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.adress = adress;
            
        }

        public void PrintPatientInfo ()
        {
            Console.WriteLine($"Name: {name}\nAge: {age}\nGender: {gender}\nAdress: {adress}\n");
            Console.WriteLine("------------------------\n");
        }
    }
}
