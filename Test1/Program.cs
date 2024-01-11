using Test1;

Console.WriteLine("Enter FirstName");
var firstName=Console.ReadLine();
Console.WriteLine("Enter LasstName");
var lastName = Console.ReadLine();
var person=new Person(firstName,lastName);
Console.WriteLine(person.FullName());
