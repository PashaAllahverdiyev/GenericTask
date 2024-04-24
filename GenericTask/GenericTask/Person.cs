namespace GenericTask
{
    public class Person
    {
        public int Id { get; set; }
        public static int IdCount { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }   
        public int Age { get; set; }
        public Person(string name,string surname,int age)
        {
            IdCount++;
            Id = IdCount;
            Name = name;
            SurName = surname;
            Age = age;
        }
    }
}
