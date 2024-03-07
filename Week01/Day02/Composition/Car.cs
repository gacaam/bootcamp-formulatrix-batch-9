namespace Vehicle;
class Car 
{
	//Engine
	public Engine engine;

    //Tire
	public Tire tire;

	//Car
	public string colour;
	public string brand;
	public int capacity;
	
	//Constructor
	public Car(
		Engine engine, 
		string colour, 
		string brand, 
		int capacity, 
		Tire tire
		) 
	{
		this.engine = engine;
		this.brand = brand;
		this.colour = colour;
		this.capacity = capacity;
		this.tire = tire;
	}
	
}
