using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text;

namespace ASKPayroll
{
    public class EmployeeService : IEmployeeService
    {
        public string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        /// <summary>
        /// GetEmployee - fetch requested employee record
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Employee GetEmployee(int id)
        {
            Employee employee = null;

            SqlCommand cmd = new SqlCommand("spGetEmployee");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", id);
            DataTable dt = SQLGetData(cmd);
            foreach (DataRow reader in dt.Rows)
            {
                employee = new Employee
                {
                    EmployeeId = Convert.ToInt32(reader["EmployeeId"].ToString()),
                    LastName = reader["LastName"].ToString(),
                    FirstName = reader["FirstName"].ToString(),
                    MiddleIntiial = reader["MiddleIntiial"].ToString(),
                    Addess1 = reader["Addess1"].ToString(),
                    Address2 = reader["Address2"].ToString(),
                    GeographyKey = Convert.ToInt32(reader["GeographyKey"].ToString()),
                    HomePhone = reader["HomePhone"].ToString(),
                    MobilePhone = reader["MobilePhone"].ToString(),
                    BusEmail = reader["BusEmail"].ToString(),
                    PersEmail = reader["PersEmail"].ToString(),
                    EmployeeType = Convert.ToInt32(reader["EmployeeType"].ToString()),
                    SSN = reader["SSN"].ToString(),
                    HourlyRate = Convert.ToDecimal(reader["HourlyRate"].ToString()),
                    AnnualSalary = Convert.ToDecimal(reader["AnnualSalary"].ToString()),
                    WeeklySalary = Convert.ToDecimal(reader["WeeklySalary"].ToString()),
                    StartDate = Convert.ToDateTime(reader["StartDate"].ToString()),
                    EndDate = Convert.ToDateTime(reader["EndDate"].ToString())
                };
            }
            return employee;
        }

        public void SaveEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// GetEmployeeList - Get a list of employees by name and id
        /// </summary>
        /// <returns></returns>
        public List<EmployeeList> GetEmployeeList()
        {
            DataTable dt = new DataTable();
            List<EmployeeList> list = new List<EmployeeList>();
            SqlCommand cmd = new SqlCommand("spGetEmployeeList");
            cmd.CommandType = CommandType.StoredProcedure;
            dt = SQLGetData(cmd);

            //  convert the datatable to a list
            foreach (DataRow dr in dt.Rows)
            {
                EmployeeList e = new EmployeeList();
                e.EmployeeId = Convert.ToInt32(dr[0].ToString());
                e.Name = dr[1].ToString();
                list.Add(e);
            }

            //  clear the temporary datatable
            dt = null;
            //  return the list
            return list;
        }

        /// <summary>
        /// GetGeographies - get the list of all geography locations
        /// </summary>
        /// <returns></returns>
        public List<Geography> GetGeographies()
        {
            DataTable dt = new DataTable();
            List<Geography> list = new List<Geography>();
            SqlCommand cmd = new SqlCommand("spGetGeographyList");
            cmd.CommandType = CommandType.StoredProcedure;
            dt = SQLGetData(cmd);

            //  convert the datatable to a list
            foreach (DataRow dr in dt.Rows)
            {
                Geography e = new Geography();
                e.GeographyKey = Convert.ToInt32(dr[0].ToString());
                e.City = dr[1].ToString();
                e.State = dr[2].ToString();
                e.PostalCode = dr[3].ToString();
                e.County = dr[4].ToString();
                e.Country = dr[5].ToString();
                list.Add(e);
            }

            //  clear the temporary datatable
            dt = null;
            //  return the list
            return list;

        }

        public void SaveGeography(Geography geography)
        {
            throw new NotImplementedException();
        }

        public PayPeriods GetPeriod(DateTime WorkDate)
        {
            throw new NotImplementedException();
        }

        public void AddPeriods()
        {
            throw new NotImplementedException();
        }

        public void CreateTimeLog(int PeriodId)
        {
            throw new NotImplementedException();
        }

        public List<TimeLog> GetTimeLog(int PeriodId)
        {
            throw new NotImplementedException();
        }

        public void SaveTimeLog(List<TimeLog> timelog)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// GetEmployeeTypes - Returns list of employee types for drop down list
        /// </summary>
        /// <returns></returns>
        public List<EmployeeType> GetEmployeeTypes()
        {
            DataTable dt = new DataTable();
            List<EmployeeType> list = new List<EmployeeType>();
            SqlCommand cmd = new SqlCommand("spGetEmployeeTypes");
            cmd.CommandType = CommandType.StoredProcedure;
            dt = SQLGetData(cmd);

            //  convert the datatable to a list
            foreach (DataRow dr in dt.Rows)
            {
                EmployeeType e = new EmployeeType();
                e.EmployeeTypeId = Convert.ToInt32(dr[0].ToString());
                e.EmployeeTypeName = dr[1].ToString();
                list.Add(e);
            }

            //  clear the temporary datatable
            dt = null;
            //  return the list
            return list;
        }

        /// <summary>
        /// SaveEmployeeType - Save new employee type
        /// </summary>
        /// <param name="employeeTypeName"></param>
        public void SaveEmployeeType(string employeeTypeName)
        {
            SqlCommand cmd = new SqlCommand("spSaveEmployeeType");
            cmd.Parameters.AddWithValue("@TypeName", employeeTypeName);
            SQLRunCommand(cmd);
        }

        /// <summary>
        /// GetEmployeeStatus - returns a list of employee status'
        /// </summary>
        /// <returns></returns>
        public List<EmployeeStatus> GetEmployeeStatus()
        {
            DataTable dt = new DataTable();
            List<EmployeeStatus> list = new List<EmployeeStatus>();
            SqlCommand cmd = new SqlCommand("spGetEmployeeStatus");
            cmd.CommandType = CommandType.StoredProcedure;
            dt = SQLGetData(cmd);

            //  convert the datatable to a list
            foreach (DataRow dr in dt.Rows)
            {
                EmployeeStatus e = new EmployeeStatus();
                e.StatusId = Convert.ToInt32(dr[0].ToString());
                e.Status = dr[1].ToString();
                list.Add(e);
            }

            //  clear the temporary datatable
            dt = null;
            //  return the list
            return list;
        }

        /// <summary>
        /// SaveEmployeeStatus - creates a new EmployeeStatus record
        /// </summary>
        /// <param name="status"></param>
        public void SaveEmployeeStatus(string status)
        {
            SqlCommand cmd = new SqlCommand("spSaveEmployeeStatus");
            cmd.Parameters.AddWithValue("@TypeName", status);
            SQLRunCommand(cmd);
        }

        /// <summary>
        /// SQLGetData - Fetch SQL data into a datatable
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public DataTable SQLGetData(SqlCommand cmd)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(cs))
            {
                SqlDataAdapter ds = new SqlDataAdapter(cmd);
                ds.Fill(dt);
            }
            return dt;
        }

        /// <summary>
        /// SQLRunCommand - execute a SQL command or stored procedure
        /// </summary>
        /// <param name="cmd"></param>
        public void SQLRunCommand(SqlCommand cmd)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Parts> GetParts()
        {
            throw new NotImplementedException();
        }

        public Parts GetPart(int Id)
        {
            throw new NotImplementedException();
        }

        public void SavePart(Parts part)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomerList()
        {
            throw new NotImplementedException();
        }

        public void SaveCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
