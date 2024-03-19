class Program{
    static async Task Main(){
        string filePath = "../FileStreamCreate/file.txt";

        using(StreamReader reader = new(filePath)){
            Console.WriteLine("Read To End (Reader 1)");
            Console.WriteLine(await reader.ReadToEndAsync());
            
            //reread by line using the same reader
            Console.WriteLine("");
            Console.WriteLine("Read Line (Reader 1)");

            try{
                string line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    Console.WriteLine(line);
                }
            }catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }

        // read again by line using a new reader
        using(StreamReader reader = new(filePath)){
            Console.WriteLine("");
            Console.WriteLine("Read Line (Reader 2)");
            Console.WriteLine(await reader.ReadLineAsync());
            Console.WriteLine(await reader.ReadLineAsync());
        }
    }
}