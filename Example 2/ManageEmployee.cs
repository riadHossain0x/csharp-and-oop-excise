using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Example_2
{
    public class ManageEmployee
    {
        private List<IEmployee> _employees;

        public IReadOnlyCollection<IEmployee> Employees
        {
            get
            {
                return new ReadOnlyCollection<IEmployee>(_employees);
            }
        }

        public ManageEmployee()
        {
            _employees = new List<IEmployee>();
        }

        public IEmployee this[int index]
        {
            get 
            {
                return _employees[index];
            }
        }

        public IEmployee this[string name]
        {
            get
            {
                return _employees.Where(x => x.Name == name).FirstOrDefault();
            }
        }

        public void Add(IEmployee employee)
        {
            _employees.Add(employee);
        }
        
        public void Remove(IEmployee employee)
        {
            _employees.Remove(employee);
        }
    }
}
