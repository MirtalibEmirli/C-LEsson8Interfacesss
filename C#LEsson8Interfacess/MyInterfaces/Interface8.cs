using C_LEsson8Interfacess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LEsson8Interfacess.MyInterfaces;

public interface Ie8
{

    int CalculateProfit();
    void ShowClientCredit(string name);
    void PayCredit(Client client, int money);


}
