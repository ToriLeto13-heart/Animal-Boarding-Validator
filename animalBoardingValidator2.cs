// Set up variables
int maxLarge = 5;
int maxMed = 10;
int maxSmall = 50;
string animalName;
string animalSize;
string carnivore;
string carnivoreString;
int animalNumber;
int floor = 0;
bool rejected = false;

// Introduction
Console.WriteLine("--Animal Boarding System--");

// Ask for animal information
// NAME

Console.Write("Enter animal name: ");
animalName = Console.ReadLine();

// SIZE

Console.Write("Enter animal size (small/medium/large): ");
animalSize = Console.ReadLine().ToLower();

// CARNIVORE

Console.Write("Is this animal a carnivore? (yes/no): ");
carnivore = Console.ReadLine().ToLower();

// NUMBER

Console.Write("How many are boarding? ");
animalNumber = Convert.ToInt32(Console.ReadLine());

// List decision

Console.WriteLine("--Boarding Decision--");
Console.WriteLine("Animal: " + animalName);
switch(animalSize)
{
    case "small":
        if (animalNumber <= maxSmall) {
            Console.WriteLine("Status: APPROVED");
            Console.WriteLine("Floor Assignment: Floor 3");
        } else {
            rejected = true;
            Console.WriteLine("Status: REJECTED");
            Console.WriteLine("Reason: Maximum " + maxSmall + " small animals allowed. You requested " + animalNumber + ".");
        }
        break;
    case "medium":
        if (animalNumber <= maxMed) {
            Console.WriteLine("Status: APPROVED");
            Console.WriteLine("Floor Assignment: Floor 2");
        } else {
            rejected = true;
            Console.WriteLine("Status: REJECTED");
            Console.WriteLine("Reason: Maximum " + maxMed + " medium animals allowed. You requested " + animalNumber + ".");
        }
        break;
    case "large":
        if (animalNumber <= maxLarge) {
            Console.WriteLine("Status: APPROVED");
            Console.WriteLine("Floor Assignment: Floor 1");
        } else {
            rejected = true;
            Console.WriteLine("Status: REJECTED");
            Console.WriteLine("Reason: Maximum " + maxLarge + " large animals allowed. You requested " + animalNumber + ".");
        }
        break;
    default:
        rejected = true;
        Console.WriteLine("Status: REJECTED");
        Console.WriteLine("Reason: Unknown size.");
        break;
}
if (!rejected) {
    switch(carnivore) 
    {
        case "yes":
            Console.WriteLine("WARNING: Carnivore - requires seperate housing from prey animals");
            break;
        case "no":
            break;
        default:
            Console.WriteLine("WARNING: Could not validate whether animal is a carnivore");
            break;
    }
}
