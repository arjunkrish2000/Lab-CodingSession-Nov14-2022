using Lab_Questions_NOV_14;

string[] arr = new string[10];

int choice;

var names = new Name();

char flag = 'y';

Console.WriteLine("1.Ascending sort 2. Descending Sort 3.Search 4.Split 5.duplicates 6.Length of each names");
Console.Write("Enter the choice : ");
choice = int.Parse(Console.ReadLine());
while (flag == 'y')
{

switch (choice)
{
	case 1:
        names.ASort();
        break;
    case 2:
        names.RSort();
        break;
    case 3:
        names.search();
        break;
    case 4:
        names.Split();
        break;
    case 5:
        names.duplicates();
        break;
    case 6:
        names.FindLength();
        break;

    default:
        Console.WriteLine("Invalid choice");
		break;
}

Console.WriteLine("Do you want to continue(y/n)?");
flag = char.Parse(Console.ReadLine());
}


//.....................

using Lab_Questions_NOV_14;

var flight = new Flight();

flight.Enter();
flight.Check();

