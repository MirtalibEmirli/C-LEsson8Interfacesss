
namespace C_LEsson8Interfacess.Models2;
using C_LEsson8Interfacess;
using C_LEsson8Interfacess.Models;
using C_LEsson8Interfacess.Models2;
using C_LEsson8Interfacess.MyInterfaces;
using C_LEsson8Interfacess.MyInterfaces;

public class Credit : Ie7


{
    public Guid Id;

    string name;
    public Credit(Client a)
    {
        name = a.Name;
        Id = Guid.NewGuid();


    }
    public void CalculatePercent(float percent)
    {
        Console.WriteLine(Amount*percent/100 - Amount +"Azn");

    }
    private int _payment ;
    public int Payment { get { return _payment; } set {
            _payment = value;

        } }
    public int Amount { get; set; }

    public void Clientname()
    {
        Console.WriteLine(name);
    }

}