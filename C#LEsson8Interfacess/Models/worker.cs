

namespace C_LEsson8Interfacess.Models;
using C_LEsson8Interfacess.Models2;
using C_LEsson8Interfacess.MyInterfaces;
using C_LEsson8Interfacess.MyInterfaces;
public class Worker :Person,Ie3, IE1
{



    public Worker(string name, string surname, string position,
          int age, int salary, string sex) : base(name, surname, position,
           age, salary, sex)
    {

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
    public   void EndTime(DateTime a)
    {
        Console.WriteLine($"End at {a.Hour}:{ a.Minute}");
    }

    private bool _control;
    public bool Control
    {
        get
        {
            return _control;
        }
        set
        {
            _control = value;
        }
    }

    public List<string> Operators= new List<string>();
    public string makemeet;


    public string this[int i]
    {
        get
        {
            return Operators[i];
        }
        set
        {
            Operators[i] = value;
        }

    }

}
