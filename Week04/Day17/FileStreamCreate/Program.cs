using System.Runtime.CompilerServices;
using System.Text;
namespace CreateFile;

class Program{
    static void Main(){

        // create file
        FileStream file = new("file.txt", FileMode.Create, FileAccess.Write);
        string loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
        using(file){
            Text.Write(file, loremIpsum);
        }

        // append
        string loremIpsum2 = "\nNunc condimentum, turpis a placerat venenatis, turpis purus elementum elit, nec aliquam enim diam a eros.";
        FileStream file2 = new("file.txt", FileMode.Append, FileAccess.Write);
        try{
            using(file2){
                Text.Write(file2, loremIpsum2);
            }
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }
    }
}

public class Text{
    public static void Write(FileStream file, string text){
        byte[] textBytes = new byte[text.Length];
        textBytes = Encoding.UTF8.GetBytes(text);
        file.Write(textBytes, 0, text.Length);
    }
}