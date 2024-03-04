
namespace C_LEsson8Interfacess.Models;
using C_LEsson8Interfacess.Models2;
using C_LEsson8Interfacess.MyInterfaces;

public class Manager:Person, Ie4, Ie5,IE1


{

    public string this[int i] { get { return Surname; } set { Surname = value; } }

    public bool Control
    {
        get
       ;
        set
        ;
    }


    public Manager(string name, string surname, string position,
          int age, int salary, string sex) : base(name, surname, position,
           age, salary, sex)
    {

    }

    public void organize()
    {
        Console.WriteLine("organize ");
    }
    public void Calculate()
    {
        Console.WriteLine("Salary is " + Salary);
    }

   public override void Show()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Surname: " + Surname);
        Console.WriteLine("Position: " + Position);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Salary: " + Salary);
        Console.WriteLine("Sex: " + Sex);
        Console.WriteLine("ID: " + Id); 
    }

}
