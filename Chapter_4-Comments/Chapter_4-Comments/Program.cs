
String thingSubject, //User inputs subject from text box
       thingDescribed, //User inputs subject adjective from text box
       thing3 = "of Doom", 
       thing4 = "3000"; 

Console.WriteLine("What kind of thing are we talking about?"); 
thingSubject = Console.ReadLine(); //Obtain noun from user
Console.WriteLine("How would you describe the thing? Big? Azure? Tattered?");
thingDescribed = Console.ReadLine(); //Obtain adjective from user

// Assemble user input
Console.WriteLine("You must be talking about the " + thingSubject + " " + thingDescribed + " " + thing3 + " " + thing4 + "!");