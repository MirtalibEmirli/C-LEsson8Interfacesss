using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LEsson8Interfacess.MyInterfaces;

public interface Ie3
{

    void StartTime(DateTime a)
    {
        Console.WriteLine($"Start at {a.Hour}"); 
    }
    void EndTime(DateTime a);
     
}
