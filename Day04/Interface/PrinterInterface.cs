public interface IPrinter {
	void Print();
	void Scan();
	void Fax();
}
public interface IWireless {
	void Connect();
	void Disconnect();
}
public interface IBluetooth {
	void BTConnect();
	void BTDisconnect();
}
public interface IPrinterEpson : IPrinter, IWireless, IBluetooth;
public class PrinterEpson60Juta :IPrinterEpson {
public void Print() {
		Console.WriteLine("PrinterEpson Print");
	}
	public void Scan() {
		Console.WriteLine("PrinterEpson Scan");
	}
	public void Fax() {
		Console.WriteLine("PrinterEpson Fax");
	}
	public void Connect() {
		Console.WriteLine("PrinterEpson Connect");
	}
	public void Disconnect() {
		Console.WriteLine("PrinterEpson Disconnect");
	}
	public void BTConnect() {
		Console.WriteLine("PrinterEpson BTConnect");
	}
	public void BTDisconnect() {
		Console.WriteLine("PrinterEpson BTDisconnect");
	}
}
public class PrinterEpson : IPrinterEpson {
	public void Print() {
		Console.WriteLine("PrinterEpson Print");
	}
	public void Scan() {
		Console.WriteLine("PrinterEpson Scan");
	}
	public void Fax() {
		Console.WriteLine("PrinterEpson Fax");
	}
	public void Connect() {
		Console.WriteLine("PrinterEpson Connect");
	}
	public void Disconnect() {
		Console.WriteLine("PrinterEpson Disconnect");
	}
	public void BTConnect() {
		Console.WriteLine("PrinterEpson BTConnect");
	}
	public void BTDisconnect() {
		Console.WriteLine("PrinterEpson BTDisconnect");
	}
}

class Speaker : IBluetooth {
	public void BTConnect() {}
	public void BTDisconnect() {}
}
class EpsonWarehouse {
	private IPrinterEpson[] printer;
	public void AddPrinter(IPrinterEpson epson) {
		
	}	
}

class BluetoothDeviceWarehouse {
	private IBluetooth[] bluetooths;
	public void AddDevice(IBluetooth bluetooth) {
	
	}
}

class WirelessDeviceWarehouse {
	private IWireless[] wireless;
	public void AddDevice(IWireless wireless) {
	
	}
}



