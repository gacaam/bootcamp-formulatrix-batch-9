using System.Text;
using CreateFile;
class Program{
    static void Main(){
        // open and read existing file
        FileStream file = new("../FileStreamCreate/file.txt", FileMode.Open, FileAccess.Read);
        using(file){
            Read(file);
        }

        // try to read filestream with write access
        FileStream file2 = new("../FileStreamCreate/file.txt", FileMode.Open, FileAccess.Write);
        using(file2){
            try{
                Read(file2);
            }catch(Exception e){
                Console.WriteLine("");
                Console.WriteLine(e.Message);
            }
        }
    }

    public static void Read(FileStream file){
        byte[] buffer = new byte[file.Length];
        file.Read(buffer, 0, buffer.Length);
        string result = Encoding.UTF8.GetString(buffer);
        Console.WriteLine(result);
    }
}