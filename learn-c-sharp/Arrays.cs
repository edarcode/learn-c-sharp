internal class Arrays
{
    public static void createArray()
    {
        Person edarcode = new Person("edarcode",26,"Colombia");
        Person edwin = new Person("edwin", 26, "Colombia");
        Person manz = new Person("manz", 35, "España");

        Person[] allPersons = {edarcode, edwin, manz};
 
       foreach (Person person in allPersons)
       {
           Console.WriteLine(person.getName());
       }
       
    }
}