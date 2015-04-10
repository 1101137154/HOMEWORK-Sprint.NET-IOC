
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


        override protected IRowMapper<Employee> GetRowMapper()
        {
            return new EmployeeRowMapper();
        }

        public IList<Employee> GetAllEmployees()
        {

            List<Employee> employees = new List<Employee>();

            Employee aa = new Employee();
            aa.Name = "AA";
            aa.Id = "001";
            aa.Age = 33;
            employees.Add(aa);

            Employee bb = new Employee();
            aa.Name = "BB";
            aa.Id = "002";
            aa.Age = 25;
            employees.Add(bb);

            return employees;
        }

        public Employee GetEmployeeById(string id)
        {
            //Employee employee = employees.Find(x => x.Id.Contains(id));

            Employee cc = new Employee();
            cc.Name = "CC";
            cc.Id = "001";
            cc.Age = 33;

            return cc;
        }
    }
}
