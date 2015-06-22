using UnityEngine;
using System.Collections;

public class OceanModifier : MonoBehaviour {


	float normalOceanScale = 5.0f;
	float normalWaveSpeed = 0.5f;

	float maxWaveSpeed = 3.0f;
	float maxOceanScale = 15.0f;

	float oceanScale;//1-10
	float waveSpeed; //0-3
	float windPower = 1.0f;//0-1


	float incrementN = 2.0f;


	public Ocean myOcean;

	// Use this for initialization
	void Start () {
		oceanScale = normalOceanScale;
		waveSpeed = normalWaveSpeed;
	}
	
	// Update is called once per frame
	void Update () {


		if(BreathDataProcesser.getSingleton().isInhalingTest){
			oceanScale += incrementN*Time.deltaTime;
			waveSpeed += incrementN*Time.deltaTime/500;
		}else{
			if(oceanScale > normalOceanScale){
				oceanScale -= incrementN*Time.deltaTime;
			}
			if(waveSpeed > normalWaveSpeed){
				waveSpeed -= incrementN*Time.deltaTime/1000;
			}
		}

		if(oceanScale>maxOceanScale)oceanScale=maxOceanScale;
		if(waveSpeed>maxWaveSpeed)waveSpeed=maxWaveSpeed;

		modifyOcean();

	}



	public void modifyOcean(){
		myOcean.scale = oceanScale;
		myOcean.speed = waveSpeed;
//		myOcean.humidity = windPower;
	}
}
