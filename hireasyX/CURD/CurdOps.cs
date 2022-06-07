using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using hireasyX.Model;

namespace hireasyX.CURD
{
    public class CurdOps
    {
        public static IEnumerable<Register> getAllData()
        {
            List<Register> lr = new List<Register>();
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-KHL9E1P\\SQLEXPRESS;Initial Catalog=hireasy;Integrated Security=true"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_GETALLDATA", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                
                while(dr.Read())
                {
                    Register reg = new Register();
                    reg.NAME = dr[1].ToString();
                    reg.EMAILID = dr[2].ToString();
                    reg.PASSWORD = dr[3].ToString();
                    reg.DEPARTMENT = dr[4].ToString();
                    lr.Add(reg);
                }
                return lr;
            }

        }

        public static IEnumerable<Jobs> getJobData()
        {
            List<Jobs> rr = new List<Jobs>();
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-KHL9E1P\\SQLEXPRESS;Initial Catalog=hireasy;Integrated Security=true"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_GETALLJOBDATA", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Jobs jb = new Jobs();
                    jb.HE_JOBID = dr[0].ToString();
                    jb.USERID = dr[1].ToString();
                    jb.JOB_TITLE = dr[2].ToString();
                    jb.COMPANY_NAME = dr[3].ToString();
                    jb.LOCATION = dr[4].ToString();
                    jb.JOB_NATURE = dr[5].ToString();
                    jb.COMAPNY_WEBSITE = dr[6].ToString();
                    jb.COMAPNY_EMAIL = dr[7].ToString();
                    jb.JOB_CATEGORY = dr[8].ToString();
                    jb.JOB_DESC = dr[9].ToString();
                    jb.SALARY = dr[10].ToString();
                    jb.APPLY_LINK = dr[11].ToString();
                    rr.Add(jb);
                }
                return rr;
            }

        }


        public bool AddAdmin(Register reg)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-KHL9E1P\\SQLEXPRESS;Initial Catalog=hireasy;Integrated Security=true"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_INSERT_ADMIN_DATA", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NAME", reg.NAME);
                cmd.Parameters.AddWithValue("@EMAILID", reg.EMAILID);
                cmd.Parameters.AddWithValue("@PASSWORD", reg.PASSWORD);
                cmd.Parameters.AddWithValue("@DEPARTMENT", reg.DEPARTMENT);

                int x = cmd.ExecuteNonQuery();

                if(x>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool Login(Register register)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-KHL9E1P\\SQLEXPRESS;Initial Catalog=hireasy;Integrated Security=true"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_GETLOGIN", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Emailid", register.EMAILID);
                cmd.Parameters.AddWithValue("@Password", register.PASSWORD);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool AddJob(Jobs jobs)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-KHL9E1P\\SQLEXPRESS;Initial Catalog=hireasy;Integrated Security=true"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_POSTAJOB", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Userid", jobs.USERID);
                cmd.Parameters.AddWithValue("@Jobtitle", jobs.JOB_TITLE);
                cmd.Parameters.AddWithValue("@Compname", jobs.COMPANY_NAME);
                cmd.Parameters.AddWithValue("@Location", jobs.LOCATION);
                cmd.Parameters.AddWithValue("@Jobnature", jobs.JOB_NATURE);
                cmd.Parameters.AddWithValue("@Compweb", jobs.COMAPNY_WEBSITE);
                cmd.Parameters.AddWithValue("@Compemail", jobs.COMAPNY_EMAIL);
                cmd.Parameters.AddWithValue("@Jobct", jobs.JOB_CATEGORY);
                cmd.Parameters.AddWithValue("@Jobdesc", jobs.JOB_DESC);
                cmd.Parameters.AddWithValue("@Salary", jobs.SALARY);
                cmd.Parameters.AddWithValue("@ApplyLink", jobs.APPLY_LINK);

                int x = cmd.ExecuteNonQuery();

                if (x > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static Jobs GetDataByID(int heid)
        {
            Jobs jobs = new Jobs();
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-KHL9E1P\\SQLEXPRESS;Initial Catalog=hireasy;Integrated Security=true"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_GETJOBDATA_BYID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@heid", heid);
                SqlDataReader dr=cmd.ExecuteReader();

                if(dr.Read())
                {
                    jobs.HE_JOBID = dr["HE_JOBID"].ToString();
                    jobs.USERID = dr["USERID"].ToString();
                    jobs.JOB_TITLE = dr["JOB_TITLE"].ToString();
                    jobs.COMPANY_NAME = dr["COMPANY_NAME"].ToString();
                    jobs.LOCATION = dr["LOCATION"].ToString();
                    jobs.JOB_NATURE = dr["JOB_NATURE"].ToString();
                    jobs.COMAPNY_WEBSITE = dr["COMAPNY_WEBSITE"].ToString();
                    jobs.COMAPNY_EMAIL = dr["COMAPNY_EMAIL"].ToString();
                    jobs.JOB_CATEGORY = dr["JOB_CATEGORY"].ToString();
                    jobs.JOB_DESC = dr["JOB_DESC"].ToString();
                    jobs.SALARY = dr["SALARY"].ToString();
                    jobs.APPLY_LINK = dr["APPLY_LINK"].ToString();
                }

                return jobs;
            }
        }

    }
}
