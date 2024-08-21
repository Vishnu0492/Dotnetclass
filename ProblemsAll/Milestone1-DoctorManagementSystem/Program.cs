//Doctor Management System - Used for clinical information


using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Numerics;
using System.Diagnostics.Metrics;


namespace DoctorManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoctorManager docsystem = new DoctorManager();
            bool exit = false;
            while (!exit)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("\n Doctor Management System");
                    Console.WriteLine("1. Add Doctor information");
                    Console.WriteLine("2. Display all Doctors");
                    Console.WriteLine("3. Exit");
                    Console.Write("Enter your choice: ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            // Call the method to add a new doctor
                            docsystem.AddDoctor();
                            break;
                        case "2":
                            // Call the method to display the doctor details
                            docsystem.DisplayDoctor();
                            break;
                        case "3":
                            // Exit the application
                            exit = true;

                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                }
            }
        }
    }

    public class Doctor
    {
        public string RegistrationNo { get; set; }
        public string DoctorName { get; set; }
        public string City { get; set; }
        public string AreaOfSpecialization { get; set; }
        public string ClinicAddress { get; set; }
        public string ClinicTimings { get; set; }
        public string ContactNo { get; set; }
    }
    class DoctorManager
    {
        private List<Doctor> doctors = new List<Doctor>();
        //Adding All the relevent details of Available doctors
        public void AddDoctor()
        {

            Doctor doctor = new Doctor();
            doctor.RegistrationNo = GetValidatedInput("Enter registration no of 7 digits:  ", @"^\d{7}$");
            doctor.DoctorName = GetValidatedInput("Enter Doctor Name (Alphabets only):  ", @"^[a-zA-Z\s]+$");
            doctor.City = GetValidatedInput("Enter City Name:  ", @"^[a-zA-Z\s]+$");
            doctor.AreaOfSpecialization = GetValidatedInput("Enter Area of specilization (Alphabets only):  ", @"^[a-zA-Z\s]+$");
            doctor.ClinicAddress = GetValidatedInput("Enter Clinic address (Alphabets only):  ", @".+");
            doctor.ClinicTimings = GetValidatedInput("Enter Clinic timing:  ", @".+");
            doctor.ContactNo = GetValidatedInput("Enter contact number (Numeric only, must have 10 digits):  ", @"^\d{10}$");
            doctors.Add(doctor);
            Console.WriteLine("Doctor information added successfully!");
            Console.ReadKey();
        }
        //Display the details of all the listed doctors
        public void DisplayDoctor()
        {
            Console.Clear();
            if (doctors.Count == 0)
            {

                Console.WriteLine("No doctor information available");
            }
            else
            {
                foreach (Doctor doctor in doctors)
                {

                    Console.WriteLine($"Doctor Registration number: {doctor.RegistrationNo}");
                    Console.WriteLine($"Doctor Name: {doctor.DoctorName}");
                    Console.WriteLine($"Doctor's City: {doctor.City}");
                    Console.WriteLine($"Areas of specilization: {doctor.AreaOfSpecialization}");
                    Console.WriteLine($"Address: {doctor.ClinicAddress}");
                    Console.WriteLine($"Clinic Timing: {doctor.ClinicTimings}");
                    Console.WriteLine($"Contact Number: {doctor.ContactNo}");
                    Console.WriteLine("_", 40);
                }


            }
            Console.ReadKey();
        }
        //regex to validate the input details
        private string GetValidatedInput(string prompt, string pattern)
        {
            string input;
            Regex regex = new Regex(pattern);
            while (true)
            {
                Console.Write(prompt);
                input = Console.ReadLine();
                if (regex.IsMatch(input))
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again!");
                }
            }
        }
    }

}
    

