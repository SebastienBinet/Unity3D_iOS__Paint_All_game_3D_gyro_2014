using UnityEngine;
using System.Collections;

public class SebasCameraLookAt : MonoBehaviour {

	public Transform myTarget;
	public int speedLeft = 2;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (myTarget);
		transform.Translate(Vector3.left * Time.deltaTime * speedLeft);
	}
}
