private var UDPHost : String = "127.0.0.1";
private var listenerPort : int = 2000;
private var broadcastPort : int = 57131;
private var oscHandler : Osc;

private var eventName : String = "";
private var eventData : String = "";
public var counter : int = 0;


public function Start () {

	var udp : UDPPacketIO = GetComponent("UDPPacketIO");
	udp.init(UDPHost, broadcastPort, listenerPort);
	oscHandler = GetComponent("Osc");
	oscHandler.init(udp);
			
	//oscHandler.SetAddressHandler("/eventTest", updateText);
	oscHandler.SetAddressHandler("/breathdata", counterTest);

}


function Update () {
	Debug.Log("osc: "+counter);
}


public function counterTest(oscMessage : OscMessage) : void
{	
	//Debug.Log("Running 1");
	Osc.OscMessageToString(oscMessage);
	counter = oscMessage.Values[0];
} 

public function getReading() : int {
	return counter;
}