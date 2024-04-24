namespace GenericTask
{
    public class Employee:Person
    {
        public double Salary { get; set; }
        public Employee(string name, string surname, int age,double salary):base(name,surname,age)
        {
            Salary = salary;
        }
    }
}
