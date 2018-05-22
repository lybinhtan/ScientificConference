using ScientificConference.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScientificConference.DAO
{
    class StaffDAO
    {
        private static StaffDAO instance;

        internal static StaffDAO Instance { get { if (instance == null) instance = new StaffDAO(); return StaffDAO.instance; } private set => instance = value; }
        
        public int GetStaff(string userName, string passWord)
        {
            string query = "select * from Staff where UserName ='" + userName +"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count != 0)
            {
                StaffDTO staff = new StaffDTO(data.Rows[0]);
                if(passWord == staff.PassWord)
                {
                    return staff.Level;
                }

            }
            return 0;
        }
    }
}
