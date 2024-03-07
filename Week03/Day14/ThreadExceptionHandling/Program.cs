class Program {
    static void Main() {
        Thread thread = new(() => ExceptionMaker());
        thread.Start();
        thread.Join();
    }
    static void ExceptionMaker() {
        try{
            throw new FormatException("Exception thrown from ExceptionMaker"); 
        }
        catch (Exception e){
            Console.WriteLine(e.Message);
        }   
    }
}