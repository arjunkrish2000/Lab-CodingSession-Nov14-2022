//using Lab_Questions_NOV_14;

//string[] arr = new string[10];

//int choice;

//var names = new Name();

//char flag = 'y';


//while (flag == 'y')
//{
//Console.WriteLine("1.Ascending sort 2. Descending Sort 3.Search 4.Split 5.duplicates 6.Length of each names");
//Console.Write("Enter the choice : ");
//choice = int.Parse(Console.ReadLine());

//switch (choice)
//{
//	case 1:
//        names.ASort();
//        break;
//    case 2:
//        names.RSort();
//        break;
//    case 3:
//        names.search();
//        break;
//    case 4:
//        names.Split();
//        break;
//    case 5:
//        names.duplicates();
//        break;
//    case 6:
//        names.FindLength();
//        break;

//    default:
//        Console.WriteLine("Invalid choice");
//		break;
//}

//Console.WriteLine("Do you want to continue(y/n)?");
//flag = char.Parse(Console.ReadLine());
//}


//.....................

//using Lab_Questions_NOV_14;

//var flight = new Flight();

//flight.Enter();
//flight.Check();

//.......................................

//using Lab_Questions_NOV_14;

//var fare = new Fares();

//int choice;

//fare.EnterData();

//char flag = 'y';


//while (flag == 'y')
//{
//    Console.WriteLine("1.Ascending sort 2. Descending Sort 3.Search 4.Minimum and Maximum value 5.duplicates");
//    Console.Write("Enter the choice : ");
//    choice = int.Parse(Console.ReadLine());

//    switch (choice)
//    {
//        case 1:
//            fare.Asort();
//            break;
//        case 2:
//            fare.Dsort();
//            break;
//        case 3:
//            fare.SearchFare();
//            break;
//        case 4:
//            fare.minmaxval();
//            break;
//        case 5:
//            fare.duplicate();
//            break;


//        default:
//            Console.WriteLine("Invalid choice");
//            break;
//    }

//    Console.WriteLine("Do you want to continue(y/n)?");
//    flag = char.Parse(Console.ReadLine());
//}

//...............................................................

//using Lab_Questions_NOV_14;

//var DOB = new DateOfBirth();

//char flag = 'y';


//while (flag == 'y')
//{

//    DOB.Evaluate();
//    Console.WriteLine();
//    Console.WriteLine("Do you want to continue(y/n)?");
//    flag = char.Parse(Console.ReadLine());
//    Console.WriteLine();
//}

//.....................................


using Lab_Questions_NOV_14;

var flight = new FlightfareEOD();

flight.Assign();
