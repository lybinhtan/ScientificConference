using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScientificConference.DAO
{
    class GuestDAO
    {
        private static GuestDAO instance;

        internal static GuestDAO Instance { get { if (instance == null) instance = new GuestDAO(); return GuestDAO.instance; } private set => instance = value; }

        public DataTable GetAllData()
        {
            DataTable data = new DataTable();
            string query = "select Name, BirthDay, Address, PhoneNumber, Topic, Email, Status, Country from Guest as G, CheckJoin as CJ where G.Checkk = CJ.val";
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        } 
        public DataTable FindData(string name)
        {
            DataTable data = new DataTable();
            string query = "select Name, BirthDay, Address, PhoneNumber, Topic, Email, Status, Country from Guest as G, CheckJoin as CJ where G.Checkk = CJ.val and Name ='" +name+"'";
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public void AddGuest(string name, DateTime birthday, string address, string phonenumber, string topic, string email, int check, string country)
        {
            string query = "insert into Guest(Name, BirthDay, Address, PhoneNumber, Topic, Email, Checkk, Country) values(N'"+name+"', '"+birthday+"', N'"+address+"', N'"+phonenumber+"', N'"+topic+"', N'"+email+"', "+check+", N'"+country+"')";
            DataProvider.Instance.Execute_Non_Query(query);
        }

        public void DeleteData(string name, string phonenumber)
        {
            string query = "delete from Guest where Name = '" + name + "'and PhoneNumber ='" + phonenumber + "'";
            DataProvider.Instance.Execute_Non_Query(query);
        }
        public bool CheckExist(string name, string phonenumber)
        {
            string query = "select * from Guest where Name = '" + name + "' and PhoneNumber = '" + phonenumber + "'";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }
    }
}
