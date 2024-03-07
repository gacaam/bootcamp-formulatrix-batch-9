class Program{
    static void Main(){
        Bird bird = new();
        bird.MakeSound();
        bird.Move();
   
        Cat cat = new();
        cat.Breathe();
        cat.MakeSound();
        cat.Move();
    }
}

