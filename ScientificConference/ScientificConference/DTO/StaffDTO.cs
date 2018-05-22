using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScientificConference.DTO
{
    class StaffDTO
    {
        private int id;
        private string userName;
        private string passWord;
        private string name;
        private DateTime birthDay;
        private string address;
        private string phoneNumber;
        private string nationalId;
        private DateTime dateIn;
        private string email;
        private int level;
        
        public StaffDTO(int id, string username, string password, string name, DateTime birthday, string address, string phonenumer, string nationalid, DateTime datein, string email, int level)
        {
            this.Id = id; this.UserName = username;
            this.PassWord = password; this.Name = name;
            this.BirthDay = birthday; this.Address = address;
            this.PhoneNumber = phonenumer; this.NationalId = nationalid;
            this.DateIn = datein; this.Email = email; this.Level = level;
        }
        public StaffDTO(DataRow row)
        {
            this.Id = (int)row["id"];
            this.UserName = row["UserName"].ToString();
            this.PassWord = row["PassWord"].ToString();
            this.Name = row["Name"].ToString();
            this.BirthDay = (DateTime)row["BirthDay"];
            this.Address = row["Address"].ToString();
            this.PhoneNumber = row["PhoneNumber"].ToString();
            this.NationalId = row["NationalId"].ToString();
            this.DateIn = (DateTime)row["DateIn"];
            this.Email = row["Email"].ToString();
            this.Level = (int)row["Level"];
        }
        public int Id { get => id; set => id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string Name { get => name; set => name = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string NationalId { get => nationalId; set => nationalId = value; }
        public DateTime DateIn { get => dateIn; set => dateIn = value; }
        public int Level { get => level; set => level = value; }
        public string Email { get => email; set => email = value; }
    }
}
