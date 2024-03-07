class Program {
    static void Main() {
        try{
            Task task = Task.Run(() => ExceptionMaker());
            Task task2 = Task.Run(() => FormatExceptionMaker());
            Task.WaitAll(task, task2);

            // ExceptionMaker();
            // FormatExceptionMaker();
        }
        catch (Exception e){
            Console.WriteLine(e.Message);
        }
    }
    static void ExceptionMaker(){
        throw new FormatException("Exception thrown from ExceptionMaker"); 
    }

    static void FormatExceptionMaker(){
        string a = "3a";
        int b = int.Parse(a);
    }

}