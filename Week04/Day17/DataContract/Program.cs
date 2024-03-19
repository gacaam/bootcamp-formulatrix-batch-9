
namespace DataContractt;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

class Program{
    static void Main(){
        // create ship instances
        Ship battleship = new(ShipType.battleship, [1,2,3]);
        Ship cruiser = new(ShipType.cruiser, [6,7]);
        Ship carrier = new(ShipType.cruiser, [10,12,13,14], true);

        Ship[] ships = new Ship[] {battleship, cruiser, carrier};

        //serialize
        DataContractSerializer serializer = new(typeof(Ship[]));
        using(FileStream fs = new("ships.json", FileMode.Create)){
            serializer.WriteObject(fs, ships);
        }
    }
}

[DataContract]
public class Ship{
    [DataMember]
    public ShipType Type {get; set;}
    [DataMember]
    private List<int> _position;
    public bool isSunk;
    public Ship(ShipType type, List<int> pos, bool sunkBool){
        Type = type;
        _position = pos;
        isSunk = sunkBool;
    }
    public Ship(ShipType type, List<int> pos){
        Type = type;
        _position = pos;
    }
    public List<int> GetPosition(){
        return _position;
    }
}

public enum ShipType{
    battleship,
    cruiser,
    carrier
}

