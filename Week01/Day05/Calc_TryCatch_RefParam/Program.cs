using System.Numerics;
class Program{
	static void Main(){
        bool a;
        Calc<int>.TryAdd(2, 3 ,out a);
        Calc<float>.TryAdd(0.4f, 3 ,out a);
        Calc<int>.TryAdd(1.3, 2, out a);
    }
}

public class Calc<T>where T : INumber<T>{
	public static T result;
	public static bool TryAdd(object n1, object n2, out bool returnVal){
		returnVal = false;
		try{
			result = (T) n1 + (T) n2;
			Console.WriteLine($"{n1} + {n2} = {result}");
			
			returnVal = true;
		}
		catch(Exception e){
			Console.WriteLine(e.Message);
		}
		Console.WriteLine($"Return value: {returnVal}\n");
		return returnVal;
	}
}




