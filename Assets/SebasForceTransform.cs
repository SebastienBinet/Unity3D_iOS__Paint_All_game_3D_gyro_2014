using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SebasForceTransform : MonoBehaviour {

	public float x,y,z;
	private float xx, yy, zz;
	public float xRot,yRot,zRot;
	private float xxRot, yyRot, zzRot;
	public Slider sliderHoriz, sliderVert, sliderAway;
	public Slider sliderRotX, sliderRotY, sliderRotZ;
	// Use this for initialization
	void Start () {
		xx = x = yy = y = zz = z = 0.00f;
		xxRot = xRot = yyRot = yRot = zzRot = zRot = 0.00f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void displaceBy(float deltaX, float deltaY, float deltaZ){
		Vector3 displacement = new Vector3 (deltaX, deltaY, deltaZ);
		Debug.Log ("displacement=" + displacement);
		transform.Translate (10 * displacement);
	}

	private void rotateBy(float deltaRotX, float deltaRotY, float deltaRotZ){
		Vector3 rotation = new Vector3 (deltaRotX, deltaRotY, deltaRotZ);
		Debug.Log ("rotation=" + rotation);
		transform.Rotate (30 * rotation);
	}

	public void SetX(){
		x = sliderHoriz.value;
		displaceBy (x - xx, 0, 0);
		xx = x;
	}
	public void SetY(){
		y = sliderVert.value;
		displaceBy (0, y - yy, 0);
		yy = y;
	}
	public void SetZ(){
		z = sliderAway.value;
		displaceBy (0, 0, z - zz);
		zz = z;
	}

	public void SetRotX(){
		xRot = sliderRotX.value;
		rotateBy (xRot - xxRot, 0, 0);
		xxRot = xRot;
	}
	public void SetRotY(){
		yRot = sliderRotY.value;
		rotateBy (0, yRot - yyRot, 0);
		yyRot = yRot;
	}
	public void SetRotZ(){
		zRot = sliderRotZ.value;
		rotateBy (0, 0, zRot - zzRot);
		zzRot = zRot;
	}

	
}
