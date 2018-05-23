using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScientificConference.DAO
{
    class AudienceDAO
    {
        private static AudienceDAO instance;

        internal static AudienceDAO Instance { get { if (instance == null) instance = new AudienceDAO(); return AudienceDAO.instance; }  private set => instance = value; }

        public DataTable GetAllData()
        {
            DataTable data = new DataTable();
            string query = "select Name, BirthDay, Address, PhoneNumber, Topic, Email, Status, Country, Fee from Audience as D, CheckJoin as CJ where D.Checkk = CJ.val";
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable FindData(string name)
        {
            DataTable data = new DataTable();
            string query = "select Name, BirthDay, Address, PhoneNumber, Topic, Email, Status, Country, Fee from Audience as D, CheckJoin as CJ where D.Checkk = CJ.val and Name ='" + name + "'";
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public void AddAudience(string name, DateTime birthday, string address, string phone, string topic, string email, int check, string country, int fee)
        {
            string query = "insert into Audience(Name, BirthDay,Address, PhoneNumber, Topic, Email,Checkk, Country, Fee) values(N'" + name + "','" + birthday + "', N'" + address + "', N'" + phone + "', N'"+topic+"', N'"+email+"', "+check+", N'"+country+"', "+fee+")";
            DataProvider.Instance.Execute_Non_Query(query);
        }

        public void DeleteData(string name, string phonenumber)
        {
            string query = "delete from Audience where Name = '" + name + "'and PhoneNumber ='" + phonenumber + "'";
            DataProvider.Instance.Execute_Non_Query(query);
        }
        public bool CheckExist(string name, string phonenumber)
        {
            string query = "select * from Audience where Name = '" + name + "' and PhoneNumber = '" + phonenumber + "'";
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
