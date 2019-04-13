using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ASKPayroll
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeService" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeService
    {
        //  employee table contracts
        [OperationContract]
        Employee GetEmployee(int id);

        [OperationContract]
        void SaveEmployee(Employee employee);

        [OperationContract]
        List<EmployeeList> GetEmployeeList();

        //  geography table contracts
        [OperationContract]
        List<Geography> GetGeographies();

        [OperationContract]
        void SaveGeography(Geography geography);

        //  pay periods contracts
        [OperationContract]
        PayPeriods GetPeriod(DateTime WorkDate);

        [OperationContract]
        void AddPeriods();

        //  timelog contracts
        [OperationContract]
        void CreateTimeLog(int PeriodId);

        [OperationContract]
        List<TimeLog> GetTimeLog(int PeriodId);

        [OperationContract]
        void SaveTimeLog(List<TimeLog> timelog);

        /// <summary>
        /// Employee Type Contracts
        /// </summary>
        /// <param name="timelog"></param>
        [OperationContract]
        List<EmployeeType> GetEmployeeTypes();

        [OperationContract]
        void SaveEmployeeType(string employeeTypeName);

        /// <summary>
        /// Employee Status Contracts
        /// </summary>
        /// <param name="timelog"></param>
        [OperationContract]
        List<EmployeeStatus> GetEmployeeStatus();

        /// <summary>
        /// SaveEmployeeStatus - save a new record to the Employee Status table
        /// </summary>
        /// <param name="status"></param>
        [OperationContract]
        void SaveEmployeeStatus(string status);

        /// <summary>
        /// GetParts    -   returns a list of Parts available
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Parts> GetParts();

        /// <summary>
        /// GetPart     -   returns the record for the selected Part
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [OperationContract]
        Parts GetPart(int Id);

        /// <summary>
        /// SavePart    -   add a new part to the Parts Table
        /// </summary>
        /// <param name="part"></param>
        [OperationContract]
        void SavePart(Parts part);

        [OperationContract]
        Customer GetCustomer(int id);

        [OperationContract]
        List<Customer> GetCustomerList();

        [OperationContract]
        void SaveCustomer(Customer customer);

    }
}
