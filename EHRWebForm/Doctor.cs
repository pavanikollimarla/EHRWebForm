using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebGrease.Css.Ast.Selectors;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace EHRWebForm
{      
    public class Doctor
    {

        public DataTable GetAllDoctors()
        {
            return CreateDataTable();
             
        }
        public DataTable GetDoctorByFirstname(string name)
        {
            DataTable dt = CreateDataTable();
            DataView dv = dt.DefaultView;
            dv.RowFilter = "FirstName Like '%" + name + "%'";
            return dt;
        }
        public DataTable GetDoctorByEmail(string mail)
        {
            DataTable dt = CreateDataTable();
            DataView dv = dt.DefaultView;
            dv.RowFilter = "Email Like '%" + mail + "%'";
            return dt;
        }
        private DataTable CreateDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Rows.Add("Ram", "ram@gmail.com");
            dt.Rows.Add("pavani", "Pavani@gmail.com");
            dt.Rows.Add("thulasi", "PJ@gmail.com");
            dt.Rows.Add("Ravi", "Ravi@gmail.com");
            dt.Rows.Add("Pavani", "Pavani@gmail.com");
            dt.Rows.Add("krish", "Ravi@gmail.com");
            return dt;
        }
        
    }
}