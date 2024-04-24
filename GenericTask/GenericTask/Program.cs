using GenericTask;

internal class Program
{
    static void Main(string[] args)
    {
        first:
        CustomCollection<Employee> collection = new CustomCollection<Employee>();
        Console.WriteLine("1-Add Employee");
        Console.WriteLine("2-Id-ye gore");
        Console.WriteLine("3-All Employee");
        Console.WriteLine("0-Stop");
        second:
        Console.WriteLine("Choose Number");
        string numChoose = Console.ReadLine();
        bool check = int.TryParse(numChoose, out int process);
        if (!check) goto second;
        switch (process)
        {
            case 1:
                if (!AddEmployee()) goto first;
                else Console.WriteLine("Emeliyyat sona catdi");
                break;
            case 2:
            IdHead:
                Console.WriteLine("Id daxil edin: ");
                string inputId = Console.ReadLine();
                bool checking = int.TryParse(inputId, out int id);
                if (!checking) goto IdHead;
                collection.GetById(id);
                Console.WriteLine("Davam etmek isteyirsiniz? beli ve ya xeyr");
                string yesOrNo = Console.ReadLine();
                if (yesOrNo.ToLower() == "beli")
                    goto first;
                else Console.WriteLine("Emeliyyat sona catdi");
                break;
            case 3:
                GetAllEmployee();
                Console.WriteLine("Davam etmek isteyirsiniz? beli ve ya xeyr");
                string choose = Console.ReadLine();
                if (choose.ToLower() == "beli")
                    goto first;
                else Console.WriteLine("Emeliyyat sona catdi");
                break;
            case 0:
                Console.WriteLine("Emeliyyat sona catdi");
                break;
        }
        bool AddEmployee()
        {
            bool checking = false;
            Console.WriteLine("Add Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Add Surname: ");
            string surname = Console.ReadLine();
            head:
            Console.WriteLine("Add Age: ");
            string input = Console.ReadLine();
            bool check = int.TryParse(input, out int age);
            if (!check) goto head;
            salaryHead:
            Console.WriteLine("Add Salary: ");
            string inputSalary = Console.ReadLine();
            bool checkSalary = double.TryParse(inputSalary, out double salary);
            if (!checkSalary) goto salaryHead;
            Employee employee = new(name, surname, age, salary);
            CustomCollection<Employee> collection = new();
            collection.Add(employee);
            Console.WriteLine("Employee is added");
            Console.WriteLine(employee.Id + " " + employee.Name + " " + employee.SurName + " " + employee.Salary);
            Console.WriteLine("Davam etmek isteyirsiniz? beli ve ya xeyr");
            string yesOrNo = Console.ReadLine();
            if (yesOrNo.ToLower() != "beli")
            {
                checking = true;
            }
            return checking;
        }
        void GetAllEmployee()
          {
              Console.WriteLine("  Iscilerin   melumatlari  ");
              foreach (var item in collection.GetAll())
                  {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.SurName     + " " + item.Age + " " + item.Salary);
            }
            }
}
}

class CustomCollection<T>where T : Person
{
    private T[] _arr;
    public CustomCollection()
    {
        _arr = new T[0];
    }
    public void Add(T value)
    {
        
         Array.Resize(ref _arr, _arr.Length+1);
        _arr[_arr.Length-1]= value;
    }
    public void GetById(int id)
    {
        foreach (T item in _arr)
        {
            if (item.Id == id)
            {
                Console.WriteLine($"{item.Id}: {item.Name}: {item.SurName}: {item.Age}:");
            }
            else
            {
                Console.WriteLine("Emloyee doesn't have");
            }
            if (_arr.Length == 0)
            {
                Console.WriteLine("Emloyee doesn't have");
            }
            
        }
    }
    public T[]   GetAll()
    {
        return _arr;
    }
}
