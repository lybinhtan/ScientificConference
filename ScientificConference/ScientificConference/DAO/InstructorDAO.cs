using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScientificConference.DAO
{
    class InstructorDAO
    {
        private static InstructorDAO instance;

        internal static InstructorDAO Instance { get { if (instance == null) instance = new InstructorDAO(); return InstructorDAO.instance; } private set => instance = value; }

        public void AddInstructor(string name, DateTime birthday, string address, string phonenumber, string email, string topic, string country, DateTime registrationdate, int fee, int check)
        {
            string query = "insert into Instructor(Name, BirthDay, Address, PhoneNumber, Email, Topic, Country, RegistrationDate, Fee, Checkk) values(N'"+name+"', '"+birthday+"', N'"+address+"', N'"+phonenumber+"', N'"+email+"', N'"+topic+"', N'"+country+"', '"+registrationdate+"', "+fee+", "+check+")";
            DataProvider.Instance.Execute_Non_Query(query);
        }

        public DataTable GetAllData()
        {
            string query = "select Name, BirthDay, Address, PhoneNumber, Email, Topic, Country, RegistrationDate, Fee, Status, Point from Instructor, CheckJoin where Instructor.checkk = CheckJoin.val";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable FindData(string name)
        {
            DataTable data = new DataTable();
            string query = "select Name, BirthDay, Address, PhoneNumber, Email, Topic, Country, RegistrationDate, Fee, Status, Point from Instructor, CheckJoin where Instructor.checkk = CheckJoin.val and Name = '" + name + "'";
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public void DeleteData(string name, string phonenumber)
        {
            string query = "delete from Instructor where Name = '"+name+"'and PhoneNumber ='"+phonenumber+"'";
            DataProvider.Instance.Execute_Non_Query(query);
        }
        public bool CheckExist(string name,string phonenumber)
        {
            string query = "select * from Instructor where Name = '" + name + "' and PhoneNumber = '" + phonenumber + "'";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            if(data.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }
    }
}
