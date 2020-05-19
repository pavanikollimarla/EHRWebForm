using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebGrease.Css.Ast.Selectors;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace EHRWebForm
{
    public partial class Contact : Page
    {
        DataTable dt = new DataTable();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public void GetAll_Click(object sender, EventArgs e)
        {
            //string fname = FnText.Text;
            //string Mail = Emtext.Text;
            //string result = string.Format("U r name is " + fname + " and U r email is " + Mail);
            //Lit.Text = result;
            GridView1.DataSource = new Doctor().GetAllDoctors();
            GridView1.DataBind();
        }

        public void GetFN_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = new Doctor().GetDoctorByEmail(Emtext.Text);
            GridView1.DataBind();
        }
        public void GetDoctorAsList()
        {
            List<Doctor2> doctor2List = new List<Doctor2>();
        }

    }
}