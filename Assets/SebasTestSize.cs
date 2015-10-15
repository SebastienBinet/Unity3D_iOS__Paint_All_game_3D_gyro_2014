using UnityEngine;
using System.Collections;

public class SebasTestSize : MonoBehaviour {

	public int mySpeed=10;
	public 		float horizAxis;
	public Vector3 myHorizVect;
	public GUIText textOutput;
	public float myTorque = 10;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		}

	// Update is called once per frame
	void FixedUpdate () {


		if(Input.GetKeyDown(KeyCode.U))
		{
			//Vector3 s=new Vector3( 10.0f, 15.0f, 21.0f);
			//gameObject.tr .position = new Vector3(100.0f, 200.0f, 300.0f);
			//Rigidbody.Destroy(gameObject);
			//rigidbody.AddForce (new Vector3(10.0f, 15.0f, 5.0f));
			Debug.Log ("U pressed!");
			rigidbody.AddForce (transform.up * 500.0f);
		}
		if(Input.GetKeyDown(KeyCode.Q))
		{
			rigidbody.AddForce (transform.up * 500.0f);
		}
		if(Input.GetKeyDown(KeyCode.W))
		{
			rigidbody.AddTorque( transform.up * 500.0f, ForceMode.Impulse);
		}
		if(Input.GetButtonDown("Vertical")
			|| Input.GetKeyDown(KeyCode.A))
		{
			transform.Translate (Vector3.up * mySpeed*Time.deltaTime);
		}
		if(Input.GetKeyDown(KeyCode.B))
		{
			transform.Translate (Vector3.down * mySpeed*Time.deltaTime);
		}

		horizAxis = Input.GetAxis("Horizontal");
		myHorizVect = new Vector3 (horizAxis * 10, 0.0f, 0);
		transform.Translate (myHorizVect * mySpeed*Time.deltaTime);
		//textOutput.text = "testtest, Vertical=" + horizAxis.ToString ("F2");



	}

	void OnMouseDown(){
		//Debug.Log ("<color=red><size=22>Clicked</size></color> on the object!", rigidbody);
		//rigidbody.AddTorque( transform.up * myTorque, ForceMode.Impulse);
		//GUIStyle myGuiStyle = new GUIStyle ();
		//myGuiStyle.richText = true;
		//GUILayout.Label ("<size=30>Some</size>",myGuiStyle);
	}
}
