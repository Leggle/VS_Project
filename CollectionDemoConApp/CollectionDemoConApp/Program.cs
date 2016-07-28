using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemoConApp
{
    public class Employee
    {
        private int _EmpId;
        public int EmpId
        {
            get { return _EmpId; }
            set { _EmpId = value; }
        }

        private string _EmpName;
        public string EmpName
        {
            get { return _EmpName; }
            set { _EmpName = value; }
        }

        public Employee(int id, string name)
        {
            EmpId = id;
            EmpName = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Employee> empRecords = new Dictionary<int, Employee>();
            for (int i=0; i<5; i++)
            {
                empRecords.Add(i, new Employee(i, "EmployeeNo. " + i));
            }

            foreach(int key in empRecords.Keys)
            {
                Console.WriteLine("{0}, {1}, {2}", key, empRecords[key].EmpName, empRecords[key].EmpId);
            }
            Console.ReadLine();
        }
    }
}
