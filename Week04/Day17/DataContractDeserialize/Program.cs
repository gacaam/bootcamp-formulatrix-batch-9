using DataContractt;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

class Program{
    static void Main(){
        Ship[] result;
        DataContractSerializer serializer = new(typeof(Ship[]));

        using(FileStream fs = new("../DataContract/ships.json", FileMode.Open)){
            result = (Ship[])serializer.ReadObject(fs);
        }

        // Console.WriteLine(result.GetPosition);
        // Console.WriteLine(result.Type);
        // Console.WriteLine(result.isSunk);
    }
}
