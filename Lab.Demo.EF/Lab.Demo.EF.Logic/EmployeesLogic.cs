using Lab.Demo.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.Logic
{
    public class EmployeesLogic : BaseLogic, IABMLogic<Employees>
    {
        public List<Employees> GetAll()
        {
            return context.Employees.ToList();
        }

        public void Add(Employees newValue)
        {
            context.Employees.Add(newValue);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var empleadoAEliminar = context.Employees.Find(id);
            context.Employees.Remove(empleadoAEliminar);
            context.SaveChanges();
        }

        public void Update(Employees value)
        {
            var employeeUpdate = context.Employees.Find(value.EmployeeID);

            employeeUpdate.LastName = value.LastName;
            employeeUpdate.FirstName = value.FirstName;

            context.SaveChanges();
        }
    }
}