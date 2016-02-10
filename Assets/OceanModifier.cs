using UnityEngine;
using System.Collections;

public class OceanModifier : MonoBehaviour {

	float eegReading;

	//normal
	float normalOceanScale = 3.0f;
	float normalWaveSpeed = 0.7f;

	//max
	float maxWaveSpeed = 3.0f;
	float maxOceanScale = 12.0f;
	float maxVol = 1.5f;

	//current
	float oceanScale;//1-10
	float waveSpeed; //0-3
	float windPower = 1.0f;//0-1
	float normalVol = 0.2f;

	float vol = 1.0f;

	float incrementN = 3.0f;

	public Ocean myOcean;

	// Use this for initialization
	void Start () {
		oceanScale = normalOceanScale;
		waveSpeed = normalWaveSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		eegReading = GameObject.Find("osc").GetComponent<oscReceive>().inputData;



		oceanScale = (map(eegReading,0,100,normalOceanScale,maxOceanScale) - oceanScale) * 0.1f + oceanScale;

		waveSpeed = map(eegReading,0,100,normalWaveSpeed,maxWaveSpeed);

		if(oceanScale>maxOceanScale)oceanScale = maxOceanScale;
		if(waveSpeed>maxWaveSpeed)waveSpeed = maxWaveSpeed;
		if(vol>maxVol)vol = maxVol;


		myOcean.scale = oceanScale;
		AudioListener.volume = vol;

	}

	float map(float value, 
		float istart, 
		float istop, 
		float ostart, 
		float ostop) {
		return ostart + (ostop - ostart) * ((value - istart) / (istop - istart));
	}


}
