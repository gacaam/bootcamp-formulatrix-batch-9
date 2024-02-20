class Program{
    static void Main(){
        Employee emp1 = new Employee("Gracia", "gracia@mail.com", 1);

        Employee emp2 = new Employee("Dion", 2);
        emp2.email = "dion@mail.com";

        Employee emp3 = new Employee();

        Console.WriteLine(emp1.name);
        Console.WriteLine(emp1.email);
        Console.WriteLine(emp1.id);

        Console.WriteLine(emp2.name);
        Console.WriteLine(emp2.email);
        Console.WriteLine(emp2.id);

        Console.WriteLine(emp3.name);
        Console.WriteLine(emp3.email);
        Console.WriteLine(emp3.id);
    }
}
class Employee{
    public string name;
    public string email;
    public int id;

    // Constructor
    public Employee(string name, string email, int id){
        this.name = name;
        this.email = email;
        this.id = id;
    }
    
    public Employee(string name, int id){
        this.name = name;
        this.id = id;
    }

    // public Employee(){}

    //Parameterless Constructor
    public Employee() 
	{
		id = 0;
		name = "default";
		email = "default@mail.com";
	}

    
}