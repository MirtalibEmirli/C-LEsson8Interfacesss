using C_LEsson8Interfacess.MyInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LEsson8Interfacess.Models;

public class Ceo1:Person, IE1
{

    public Ceo1(string name, string surname, string position,
     int age, int salary, string sex) : base(name, surname, position,
      age, salary, sex)
    { }


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
    List<string> Mettings = new List<string>();
    public string this[int i] { get { return Mettings[i]; } set { Mettings[i] = value; } }

    public bool Control
    {
        get
       ;
        set
        ;
    }

}
