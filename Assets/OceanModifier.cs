using UnityEngine;
using System.Collections;

public class OceanModifier : MonoBehaviour {

	public float oceanScale = 0.0f;//1-10
	public float waveSpeed = 0.6f; //0-3
	public float windPower = 0.5f;//0-1

	public Ocean myOcean;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		myOcean.scale = oceanScale;
//		myOcean.wa
		myOcean.speed = waveSpeed;
		myOcean.humidity = windPower;
	}
}
