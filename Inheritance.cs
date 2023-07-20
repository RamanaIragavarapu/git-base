using System;
namespace Inheritance
{
    public class InherBase
    {
        public void student()
        {
            Console.WriteLine("student class");
        }
    }
    public class Inherchild1:InherBase
    {
        public void Teacher()
        {
        Console.WriteLine("teacher class");
    }
    }
    public class Inherchild2:Inherchild1
    {
        public void Principal()
        {
        Console.WriteLine("principal class");
        }
    }
class Program
{
    public static void Main(string[] args)
        {
            Inherchild2 I2 = new Inherchild2();
            I2.Teacher();
            I2.student();
            I2.Principal();
        }
    }
}
