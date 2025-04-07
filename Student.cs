using System;

namespace StudentManagementApp.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int HouseNo { get; set; }
        public string BrgyName { get; set; }
        public string Municipality { get; set; }
        public string Province { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Birthdate { get; set; }
        public int Age { get; set; }
        public string StudContactNo { get; set; }
        public string EmailAddress { get; set; }
        public string GuardianFirstName { get; set; }
        public string GuardianLastName { get; set; }
        public string Hobbies { get; set; }
        public string Nickname { get; set; }
        public int CourseId { get; set; }
        public int YearId { get; set; }
    }
}