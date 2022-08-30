internal class Person
{
    string name;
    int age;
    string country;

    public Person(string name="no name", int age=0,string country="") {
        this.name = name;
        this.age = age;
        this.country = country;
    }
    public string getName()
    {
        return name;
    }
    public int getAge()
    {
        return age;
    }
    public string getCountry()
    {
        return country;
    }
}