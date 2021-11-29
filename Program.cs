using System;


namespace CSharpPractise
{

    public class Employee {
        public string name,department;
        private int age;
        public bool working = false;

        public Employee(string name,string dept,int age) {
            this.name = name;
            this.department = dept;
            this.age = age;
        }

        public void work() {
            this.working = true;
            Console.WriteLine(this.name + " is working");
        }

        public void showEmployee() {
            Console.WriteLine(this.name + " from " + this.department + " is " + this.getAge() + " years old");
        }

        public void changeDept(string dept) {
            string prevDept = this.department;
            this.department = dept;
            Console.WriteLine(this.name + "'s department changed from " + prevDept + " to " + this.department);
        }

        public int getAge() {
            return this.age;
        }
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Saqib","Backend",24);
            Employee emp2 = new Employee("Raiyan","Accounting",21);

            emp1.showEmployee();
            emp1.work();
            emp1.changeDept("UX/UI");
            Console.WriteLine(emp1.name + " is "+ emp1.getAge() + " years old");

            emp2.showEmployee();
            emp2.work();
            emp2.changeDept("Finance");
        }
    }
}
