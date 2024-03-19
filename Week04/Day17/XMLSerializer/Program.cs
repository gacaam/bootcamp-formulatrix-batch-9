namespace XMLSerialize;
using System.Xml.Serialization;

class Program{
    static void Main(){
        // create ship instances
        Ship battleship = new(ShipType.battleship, [1,2,3]);
        Ship cruiser = new(ShipType.cruiser, [6,7]);

        Ship[] ships = new Ship[] {battleship, cruiser};

        //serialize
        XmlSerializer serializer = new(typeof(Ship[]));
        using(StreamWriter sw = new("ships.xml")){
            serializer.Serialize(sw, ships);
        }
    }
}

public class Ship{
    public ShipType Type {get; set;}
    public List<int> position;
    public Ship(){

    }
    public Ship(ShipType type, List<int> pos){
        Type = type;
        position = pos;
    }
}

public enum ShipType{
    battleship,
    cruiser,
    carrier
}

