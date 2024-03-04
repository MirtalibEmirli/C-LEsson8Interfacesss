using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LEsson8Interfacess.Models2;

using C_LEsson8Interfacess.Models;
using C_LEsson8Interfacess.MyInterfaces;
using System.Runtime.ConstrainedExecution;

public class Bank:IE1, Ie8
{
    private int profit; 
    public string Name { get { return name; } set { name = value; } }

    public List<Worker> Workeers { get; set; } = new List<Worker>();    
    public List<Client> Clients { get; set; } = new List<Client>();
    public List<Manager> Managers { get; set; } = new List<Manager>();
    public List<Ceo1> Ceos { get; set; } = new List<Ceo1>();


    private string name;
    public Bank(string name)
    {
        this.name = name;
       
    }
    
    public int Profit{ get { return profit; } set { profit = value; } }



    List<Person> mwc = new List<Person>();
    public string this[int i] { get { return mwc[i].Name; } set { mwc[i].Name = value; } }
    private bool control = false;
    public bool Control
    {
        get
        { return( Profit > 1000); }
        set
        {
            control = value;
        }
    }



    public int CalculateProfit() {

        int a = 0;

        for (int i = 0; i < mwc.Count; i++)
        {
            a += mwc[i].Salary;
        }
        profit += a;
        return profit;
    
    }
    public void ShowClientCredit(string name) {
        for (int i = 0; i < mwc.Count; i++)
        {
            if (mwc[i].Name == name) {

                Console.WriteLine($"{name} 's credit is {mwc[i].Salary} ");
            }
        }

    }
    public void PayCredit(Client client, int money) {

        Console.WriteLine(client.Name + "is pay " + money);
    }

    public void ShowalClients()
    {
        foreach (var item in Clients)
        {
            item.Show();
            Console.WriteLine();
            Console.WriteLine("credit" + item.credits);
        }

    }

}
