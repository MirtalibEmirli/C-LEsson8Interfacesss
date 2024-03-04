

using System.Xml.Linq;

namespace C_LEsson8Interfacess.Models2;
using C_LEsson8Interfacess.MyInterfaces;

public class Operation
{

    public Guid Id;
    Operation()
    {
        Id = Guid.NewGuid();
    }
    DateTime dt = DateTime.Now; 

    public void PrName()
    {
        Console.WriteLine("GET cash ");
    }
  public void Time()
    {
        Console.WriteLine(dt);
    }

}
