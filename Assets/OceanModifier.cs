using UnityEngine;
using System.Collections;

public class OceanModifier : MonoBehaviour {

	public float oceanScale = 0.0f;
	public Ocean myOcean;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		myOcean.scale = oceanScale;
	}
}
