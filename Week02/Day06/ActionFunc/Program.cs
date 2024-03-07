
class Program{
    static void Main(){
        Number num = new();
        
        //Action => delegate with no return (void)
        //Action action = num.AddOne;

        //Func => delegate with return
        Func<int, int> action = num.AddOne;
        // var action = num.AddOne; 
        int y = action.Invoke(5);
        Console.WriteLine(y);
    }
}

class Number{
    public int AddOne(int x){
        x += 1;
        return x;
    }
}