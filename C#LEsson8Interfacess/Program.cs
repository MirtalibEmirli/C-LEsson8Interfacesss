// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
string fgh = "A";
Console.WriteLine(Environment.GetLogicalDrives().ToString);
Console.WriteLine(Environment.UserName);
Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.Startup));
*/

/*
 *
 //class abstrack beele olsada onin obyekti yaranir arxada
B a = new B();



abstract class A
{
   protected A() { Console.WriteLine("A"); }
}


class B : A
{
   public B():base()
    
    { Console.WriteLine("B"); }
}*/



/*
 clas i bir interfaceden toreddikde interface daxilinde olan bir methodu implement edmemisikse
onu o vaxt isdifade ede bilerikki clasin obyektin interfacein adi altnda saxluyrq
yox eger isdeyrkse isledek o zaman onu yaZmalyq
interfacede property yazma olar bu zaman o propertynin private deyiseni implement eden class daxilinde yerlesr
full property ise yaratmaq olmaz
daxilinde deyisen yaratmaq olmaz yalniz static ve const yaratmaq olar, inexer yaratmaq oolar
Static constructor ve method isledmek olur amma classda implement edmesek catmaq olmur onlara


eyni anda 2 interface den torenen bir classda eyer her iki interfeysden gelen eyni adli fuksya varsa
bu vaxt problem olmmur cunki onsuzda intery=feys deyrki bala ged ozn yazda

amma isdeyrikni Step1 de o klasin obyektn saxlyanda iminni step1 e gore islesn ve ayri bir is gorsun onda 
void Step1.Doo(){} bele yazriq ve bi public olmur cunki ancaq Step1 in uzerinden muraciet gelende islyer
amma Doo() ozu de public void Doo() {} olaraq qalir ve umimui olur Step2 ucunde ehyni formada ayri yazruq

 
 An interface can contain declarations of methods, properties, indexers, and events.
However, it cannot contain fields, automatically implemented properties



Note: You do not have to use the override keyword when implementing an interface.


Note: Like abstract classes, interfaces cannot be used to create objects


Note: Interfaces can contain properties and methods, but not fields.

 
Notes on Interfaces:
Like abstract classes, interfaces cannot be used to create objects (in the example above, it is not possible to create an "IAnimal" object in the Program class)
Interface methods do not have a body - the body is provided by the "implement" class
On implementation of an interface, you must override all of its methods
Interfaces can contain properties and methods, but not fields/variables
Interface members are by default abstract and public
An interface cannot contain a constructor (as it cannot be used to create objects)
Why And When To Use Interfaces?
1) To achieve security - hide certain details and only show the important details of an object (interface).

2) C# does not support "multiple inheritance" (a class can only inherit from one base class). 
However, it can be achieved with interfaces, because the class can implement multiple interfaces.
 
 
 
B b = new B();
b.
interface IA
{
    static string a = "AA";
}

class B : IA
{

}

static memberrlere catmaq olmur implement eddikde bele

 
 
 
 
 Static virtual/abstract interface members (from C# 11) enable static polymorphism,
an advanced feature that we will discuss in Chapter 4. Static virtual interface mem‐
bers are marked with static abstract or static virtual:
interface ITypeDescribable
{
 static abstract string Description { get; }
 static virtual string Category => null;
}
An implementing class or struct must implement static abstract members, and can
optionally implement static virtual members:
class CustomerTest : ITypeDescribable
{
 public static string Description => "Customer tests"; // Mandatory
 public static string Category => "Unit testing"; // Optional
}
 
 */
interface ITypeDescribable
{
    static abstract string Description { get; }
    static virtual string Category => null;
}

class CustomerTest : ITypeDescribable
{
    public static string Description => "Customer tests"; // Mandatory
    public static string Category => "Unit testing"; // Optional
}

