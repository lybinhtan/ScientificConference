using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScientificConference.DTO
{
    class AudienceDTO
    {
        private int id;
        private string name;
        private DateTime birthDay;
        private string address;
        private string phoneNumber;
        private string topic;
        private string email;
        private int check;
        private string country;

        public AudienceDTO(int id, string name, DateTime birthday, string address, string phonenumber, string topic, string email, int check, string country)
        {
            this.Id = id; this.Name = name; this.BirthDay = birthday;
            this.Address = address; this.PhoneNumber = phonenumber;
            this.Topic = topic; this.Email = email; this.Check = check;
            this.Country = country;
        }

        public AudienceDTO(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["Name"].ToString();
            this.BirthDay = (DateTime)row["BirthDay"];
            this.Address = row["Address"].ToString();
            this.PhoneNumber = row["PhoneNumber"].ToString();
            this.Topic = row["Topic"].ToString();
            this.Email = row["Email"].ToString();
            this.Check = (int)row["Checkk"];
            this.Country = row["Country"].ToString();
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Topic { get => topic; set => topic = value; }
        public string Email { get => email; set => email = value; }
        public int Check { get => check; set => check = value; }
        public string Country { get => country; set => country = value; }
    }
}
