using UnityEngine;
using System.Collections;

public class SebasToggleLight : MonoBehaviour {
	public Light myLight;

	// Use this for initialization
	void Start () {
		myLight = GetComponent<Light> (); 
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyUp (KeyCode.Space)) {
			myLight.enabled=!myLight.enabled;
				}
		if (Input.GetKeyUp (KeyCode.B)) {
			myLight.color =Color.cyan;
		}
	}
}
