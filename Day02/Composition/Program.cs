namespace Vehicle;
class Program 
{
	static void Main() 
	{
		Engine engine = new Engine(8, 400, "rotary");
		Tire tire = new Tire("toyo", 17);
		Car car = new Car(engine, "red", "toyota", 8, tire);

        Console.WriteLine(car.engine.engineCylinder);
        Console.WriteLine(car.colour);
        Console.WriteLine(car.brand);
	}
}
