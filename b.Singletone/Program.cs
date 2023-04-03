using b.Singletone;


Singletone singletone1 = Singletone.GetInstance("Foo");
Singletone singletone2 = Singletone.GetInstance("Bar");
Console.WriteLine(singletone1.Name);
Console.WriteLine(singletone2.Name);

/////////////////////////////////////////////////////////////////////////

CarDeveloper developer = new GazolineCarDeveloper("Mercedes");
developer.Create();
developer = new ElectriCarDeveloper("BMW");
developer.Create();
////////////////////////////////////////////////////////////////////////////


ComputerDeveloper computerDeveloper = new LaptopDeveloper("port", "motherBoard");
computerDeveloper.Create();
computerDeveloper = new PCDeveloper("HDD", "port USB");
computerDeveloper.Create();
computerDeveloper = new GigaComputerDeveloper("USB port", "motherBoard");
computerDeveloper.Create();
computerDeveloper = new CompactDeveloper("motherBoard", "HDD");
computerDeveloper.Create();