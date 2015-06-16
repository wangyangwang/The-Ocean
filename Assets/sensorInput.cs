using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Uniduino;

public class sensorInput : MonoBehaviour {
	
	
	private static sensorInput singleton = null;
	
	public static sensorInput getSingleton(){
		return singleton;
	}
	
	public Arduino arduino;
	
	//pins
	public int breathSensorPin = 0;

	//rawValues
	public float rawHeartBeatValue = 0.0f; 
	public float rawBreathingValue = 0.0f;
	public float buttonInput = 0.0f;
	
	
	void Start () {
		singleton = this;
		arduino = Arduino.global;
		arduino.Setup(ConfigurePins);
	}
	
	void ConfigurePins( )
	{
		arduino.pinMode(0, PinMode.ANALOG);
		arduino.reportAnalog(0,1); //report status
	}
	
	// Update is called once per frame
	void Update () {
		rawBreathingValue = arduino.analogRead(breathSensorPin);
	}
}
