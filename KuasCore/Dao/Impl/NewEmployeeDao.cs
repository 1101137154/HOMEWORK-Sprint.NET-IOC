
using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace KuasCore.Dao.Impl
{
    class NewEmployeeDao : GenericDao<Employee>, IEmployeeDao
    {

        List<Employee> employees = new List<Employee>();

        override protected IRowMapper<Employee> GetRowMapper()
        {
            return new EmployeeRowMapper();
        }

        public IList<Employee> GetAllEmployees()
        {


            Employee aa = new Employee();
            aa.Name = "AA";
            aa.Id = "0011";
            aa.Age = 33;
            employees.Add(aa);

            Employee bb = new Employee();
            bb.Name = "BBBBB";
            bb.Id = "002";
            bb.Age = 25;
            employees.Add(bb);

            Employee cc = new Employee();
            cc.Name = "CC";
            cc.Id = "0022";
            cc.Age = 22;
            employees.Add(cc);

            return employees;
        }

        public Employee GetEmployeeById(string id)
        {
            Employee employee = employees.Find(x => x.Id.Equals(id));

            if (employee == null)
            {
                employee = new Employee();
                employee.Name = "Empty Employee";
                employee.Id = "0";
                employee.Age = 0;
            }
            /*
            if(id.Equals("002")){
                Employee cc = new Employee();
                cc.Name = "CC";
                cc.Id = "001";
                cc.Age = 33;
            }*/

            return employee;
        }
    }
}
