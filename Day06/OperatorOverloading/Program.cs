class Program 
{
	static void Main() 
	{
		Car car = new Car(2000);
		Car car2 = new Car(3000);
		Car car3 = new Car(4000);
		Car result = car + car2 + car3 + new Car(5000);
		Console.WriteLine(result.price);
	}
}
class Car 
{
	public int price;
	public Car(int price) 
	{
		this.price = price;
	}
	//Operator Overloading +
	//static method
	//return Value => class
	//Parameter
	//symbol : / * + - == % < > ++ -- !=
	public static Car operator +(Car a, Car b) 
	{
		return new Car(a.price + b.price);
	}
	public static Car operator -(Car a, Car b) 
	{
		return new Car(a.price - b.price);
	}
}