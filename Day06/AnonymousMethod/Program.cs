class Program{
    static void Main(){
        Number num = new();
    
        Func<int, int> action = (int x) => x + 1;
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