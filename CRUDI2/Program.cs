using CRUDI2.Entities;
using CRUDI2.Services;
using System.Xml.Linq;

Console.WriteLine("CODE CLEAN");

bool OpenMainMenu = true;
bool OpenSecundaryMenu = true;

BaseCrudServices<Person> Person = new BaseCrudServices<Person>();
Person NewPerson = new Person();

OpcionMenu();

void OpcionMenu()
{
    bool Exit = true;

    while (Exit)
    {
        Console.WriteLine("Please select one of the available menus");
        Console.WriteLine("OPTION 1 - CRUD MENU");
        Console.WriteLine("OPTION 2 - Another Implementation");
        Console.WriteLine("OPTION 3 - Exit");
        int OpcionMenu = int.Parse(Console.ReadLine());

        switch (OpcionMenu)
        {
            case 1:
                ShowMainMenu();
                break;
            case 2:
                ShowSecondaryMenu();
                break;
            case 3:
                Exit = false;
                break;
            default:
                Console.WriteLine("Please insert a valid number");
                Console.Clear();
                break;
       }
        
    }
}

void ShowMainMenu()
{
    while (OpenMainMenu)
    {
        MainMenu();
    }
}

void ShowSecondaryMenu()
{
    while (OpenSecundaryMenu)
    {
        
        SecundaryMenu();
    }
}

void MainMenu()
{
    
    Console.WriteLine("MENU CRUD");
    Console.WriteLine("1 |Create Person");
    Console.WriteLine("2 |Show People");
    Console.WriteLine("3 |Update People");
    Console.WriteLine("4 |Delete people");
    Console.WriteLine("5 |Back to Main Menu");
    Console.WriteLine("Select one of the options");
    int option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.Clear();
            CreatePerson();
            break;
        case 2:
            Console.Clear();
            ShowPerson();
            break;
        case 3:
            Console.Clear();
            UpdatePerson();
           break;
        case 4:
            Console.Clear();
            DeletePerson();
            break;
        case 5:
            OpenMainMenu = false;
            break;
        default:
            Console.WriteLine("Opcion no valida");
            Console.WriteLine("Saliendo del sistema");
            break;
    }
}

void CreatePerson()
{
    Person NewPerson = new Person();
    int ThisStatus = 1;

    Console.WriteLine("CREATE...");
    Console.WriteLine("Please enter the person's information");

    Console.WriteLine("Name:");
    string Name = Console.ReadLine();

    Console.WriteLine("LastName");
    string LastName = Console.ReadLine();

    Console.WriteLine("Age");
    int Age = int.Parse(Console.ReadLine());

    Console.WriteLine("Status Civilian");
    var ActualStatus = int.Parse(Console.ReadLine());

    NewPerson.Name = Name;
    NewPerson.LastName = LastName;
    NewPerson.Age = Age;


    if (ActualStatus == ThisStatus)
    {
        NewPerson.StatusCivilian = Status.Married;
    }
    else
    {
        NewPerson.StatusCivilian = Status.Single;
    }

    Person.Create(NewPerson);

    Console.WriteLine("Person Created Successfully!");
}

void ShowPerson()
{
    Console.WriteLine("PEOPLE:");

    foreach (var item in Person.Get())
    {
        Console.WriteLine("ID: " + item.Id);
        Console.WriteLine("NAME AND LASTNAME " + item.Name + " " + item.LastName);
        Console.WriteLine("AGE: " + item.Age);
        Console.WriteLine("STATUS CIVILIAN " + item.StatusCivilian);
    }
}

void UpdatePerson()
{
    Console.WriteLine("UPDATE");
    
}

void DeletePerson()
{
    Console.WriteLine("DELETE");
    int id = int.Parse(Console.ReadLine());

    Person.Delete(id);
    ShowPerson();
}



void SecundaryMenu()
{
    Console.WriteLine("SECONDARY MENU");
    Console.WriteLine("1 |ANIMALS");
    Console.WriteLine("2 |OPERATION BASIC");
    Console.WriteLine("3 |OPERATION FIGURE");
    Console.WriteLine("4 |EXIT");
    Console.WriteLine("Select one of the options");
    int option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.Clear();
            Animals();
            break;
        case 2:
            Console.Clear();
            OperationsBasic();
            break;
        case 3:
            Console.Clear();
            OperationFigure();
            break;
        case 4:
            Console.WriteLine("EXIT");
            OpenSecundaryMenu = false;
            break;
        default:
            Console.WriteLine("Invalid option");
            Console.WriteLine("Logging out of the system");
            break;
    }
}


static void Animals()
{

    Console.WriteLine("ANIMALS");
    Console.WriteLine("ANIMAL NAME");
    var NameAnimal = Console.ReadLine();
    Console.WriteLine("ANIMAL SPACE");
    var AnimalSpecies = Console.ReadLine();
    Console.WriteLine("ANIMAL BASE EAT");
    var AnimalBaseEat = Console.ReadLine();

    ServicesAnimals AnimalsActions = new ServicesAnimals(NameAnimal, AnimalSpecies, AnimalBaseEat);

    AnimalsActions.AnimalEat(AnimalSpecies);
    AnimalsActions.AnimalEat(AnimalSpecies, AnimalBaseEat);
    AnimalsActions.AnimalRun(NameAnimal);
}

static void OperationsBasic()
{
    Console.WriteLine("Enter the first number");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the second number");
    int num2 = int.Parse(Console.ReadLine());

    OpetarionBasic.Sum(ref num1, ref num2);
    OpetarionBasic.Subtraction(ref num1, ref num2);
    OpetarionBasic.Divide(ref num1, ref num2);
    OpetarionBasic.Miltiply(ref num1, ref num2);
}

void OperationFigure()
{
    Console.WriteLine("Enter the first number");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the second number");
    int num2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the third number");
    int num3 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the second number");
    int hypotenuse = int.Parse(Console.ReadLine());

    Scalenno scalenno = new Scalenno();

    Console.WriteLine("PERIMETER = "+scalenno.Perimeter(num1, num2, num3));
    Console.WriteLine(" AREA WITH HYPOTENUSE:");
    Console.WriteLine(scalenno.CalculateAreaWithHypotenuse(num1, hypotenuse));

}