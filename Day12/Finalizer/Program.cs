using System.Diagnostics;

class Program{
    static void Main(){
        // Console.WriteLine(GC.GetGeneration());
        for(int i=0; i<50; i++){
            InstanceCreator();
        }
        GC.Collect();
        // GC.GetGeneration(InstanceCreator());
    }
    static void InstanceCreator(){
        Human human = new();
    }
}

class Human{
    ~Human(){
        Console.WriteLine("Finalizer called");
    }
}