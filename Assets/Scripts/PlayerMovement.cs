using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody Rb;
	public float ForwardForce = 2000f;
	public float SideWaysForce = 500f;
	
	// Use this for initialization
	void Start () { 

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Rb.AddForce (0, 0, ForwardForce * Time.deltaTime);
		float temp=Input.acceleration.x;	
//		Debug.Log (temp);
//		translate by x axis
		transform.Translate(temp,0,0);

		//rotating by y axis
//		transform.Rotate(0,temp*10,0);

//		if(Input.GetKey("d")){
//			Rb.AddForce(SideWaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
//		}
//		if(Input.GetKey("a")){
//			Rb.AddForce(-SideWaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
//		}
	}
}
