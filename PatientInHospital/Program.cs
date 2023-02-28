using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PatientInHospital
{
    internal class Program
    {
        public static List<Patient> MakeListFromInfo(string[] arrayNames, int[]arrayAges, Patient.Gender[]arrayGender, string[]arrayAdress)
        {
            List<Patient> patients = new List<Patient>();

            for (int i = 0; i < arrayNames.Length; i++)
            {
                patients.Add(new Patient(arrayNames[i], arrayAges[i], arrayGender[i], arrayAdress[i]));
            }

            return patients;
        }
        //Хотите спросить "накой хера тут метод для наполнения листа и эти сраные массивы? Да потому что могу ¯\_(ツ)_/¯
        static void Main(string[] args)
        {
            string[] namesArray = { "John Pindoss", "Vera Pavlovich", "Delphi Basicov" };
            int[] agesArray = { 25, 41, 37 };
            string[] adressesArray = { "GodBlessAmerica street", "Goose-crystal city", "Silicon Valley" };
            Patient.Gender[] gendersArray = { Patient.Gender.Male, Patient.Gender.Female, Patient.Gender.Other };

            List<Patient> patientsList = MakeListFromInfo(namesArray, agesArray, gendersArray, adressesArray);

            patientsList.Add(new Patient());

            foreach (var patient in patientsList)
            {
                patient.PrintPatientInfo();
            }
            
        }
    }
}
