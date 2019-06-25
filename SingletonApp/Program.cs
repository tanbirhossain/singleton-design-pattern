namespace SingletonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton employee = Singleton.GetInstance;
            employee.PrintDetails("from employee");


            Singleton student = Singleton.GetInstance;
            student.PrintDetails("from student");
            Singleton employee1 = Singleton.GetInstance;
            employee1.PrintDetails("from employee");


            Singleton student1 = Singleton.GetInstance;
            student1.PrintDetails("from student");
        }
    }
}
