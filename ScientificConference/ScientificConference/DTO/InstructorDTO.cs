using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScientificConference.DTO
{
    class InstructorDTO
    {
        private int id;
        private string name;
        private DateTime birthDay;
        private string address;
        private string phoneNumber;
        private string email;
        private string topic;
        private string country;
        private DateTime registrationDate;
        private int fee;
        private int check;
        private int point;
        
        public InstructorDTO(int id, string name, DateTime birthday, string address, string number, string email, string topic, string country, DateTime registrationDate, int fee, int checkk, int point)
        {
            this.Id = id; this.Name = name;
            this.BirthDay = birthday; this.Address = address;
            this.PhoneNumber = number; this.Email = email; this.Topic = topic;
            this.Country = country; this.RegistrationDate = registrationDate;
            this.Fee = fee; this.check = checkk; this.Point = point;
        }
        public InstructorDTO(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["Name"].ToString();
            this.BirthDay = (DateTime)row["BirthDay"];
            this.Address = row["Address"].ToString();
            this.PhoneNumber = row["PhoneNumber"].ToString();
            this.Email = row["Email"].ToString();
            this.Topic = row["Topic"].ToString();
            this.Country = row["Country"].ToString();
            this.RegistrationDate = (DateTime)row["RegistrationDate"];
            this.fee = (int)row["Fee"];
            this.Check = (int)row["Checkk"];
            this.Point = (int)row["Point"];
            
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Topic { get => topic; set => topic = value; }
        public string Country { get => country; set => country = value; }
        public DateTime RegistrationDate { get => registrationDate; set => registrationDate = value; }
        public int Fee { get => fee; set => fee = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int Check { get => check; set => check = value; }
        public int Point { get => point; set => point = value; }
    }
}
