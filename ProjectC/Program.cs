class Program{
    static void Main(){
        Employee emp1 = new Employee("Gracia", 1);
        emp1.email = "gracia@mail.com";

        Console.WriteLine(emp1.name);
        Console.WriteLine(emp1.email);
        Console.WriteLine(emp1.id);
    }
}

class Employee{
    public string name;
    public string email;
    public int id;

    // Constructor
    public Employee(string name, int id){
        this.name = name;
        this.id = id;
    }
}