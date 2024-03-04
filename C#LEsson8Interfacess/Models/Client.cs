
namespace C_LEsson8Interfacess.Models;
using C_LEsson8Interfacess.Models2;
using C_LEsson8Interfacess.MyInterfaces;
public class Client : Person, IE1, Ie2
{


    public Client(string name, string surname, string position,
          int age, int salary, string sex) : base(name, surname, position,
           age, salary, sex)
    {

    }

    public int credits=0;
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

    public List<string> organize = new List<string>();
    public string makemeet;


    public string this[int i]
    {
        get
        {
            return organize[i];
        }
        set
        {
            organize[i] = value;
        }

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
    public void MakeMEetting()
    {
        Console.WriteLine("Start at 14:00 ");

    }
    public void decs(int decsss)
    {
        Console.WriteLine(
            Salary - decsss * Salary / 100);
    }

}
