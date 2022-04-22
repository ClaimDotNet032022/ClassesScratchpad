// See https://aka.ms/new-console-template for more information

// 3


int n = 3;
// { 0, 0, 0 }
int[] arr = new int[3];

Dog rex = new Dog("Red", "Rex", 24);
//rex.Color = "Red";
Console.WriteLine(rex.Name);
//rex.Name = "Rex";
//rex.HeightInches = 24;

Dog spot = new Dog("Brown", "Spot", 18);
spot.Name = "Spot";
spot.HeightInches = 18;

Console.WriteLine("Rex's color is: " + rex.Color);
Console.WriteLine("Spot's color is: " + spot.Color);

Console.WriteLine("Rex, speak!");
rex.Speak();
rex.Sit();
rex.Stand();

spot.Stand();
Dog.DoSomethingStatic(spot);


Console.WriteLine(rex.IsSitting);
Console.WriteLine(spot.IsSitting);

Dog newDog = rex + spot;
Console.WriteLine(newDog.Name);

int i = 2;
int j = 3;
ChangeIntValue(ref i);
ChangeIntValue(ref j);
j = CreateOutInt(out i);
Console.WriteLine(i);

ChangeDogName(rex);
Console.WriteLine(rex.Name);



Console.WriteLine(Dog.Population);
Dog fido = new Dog("White", "Fido", 6);
Console.WriteLine(Dog.Population);



Cat cat = new Cat();
Cat otherCat = new Cat("Heathcliffe");
Cat thirdCat = new Cat();
Cat[] allTheCats = new Cat[300];

for(int catNumber = 0; catNumber < allTheCats.Length; catNumber++)
{
    if (catNumber % 2 == 0)
    {
        allTheCats[catNumber] = new Cat($"Cat number {catNumber}");
    }
    else
    {
        allTheCats[catNumber] = new Cat();
    }
}


static void ChangeIntValue(ref int n)
{
    n = 32;
}

static int CreateOutInt(out int n)
{
    n = 27;
    return 42;
}

static void ChangeDogName(Dog dog)
{
    dog.Name = "Changed!";
}




