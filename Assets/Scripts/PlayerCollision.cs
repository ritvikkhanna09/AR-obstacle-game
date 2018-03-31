using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;

	void OnCollisionEnter(Collision collisionInfo){
		Debug.Log (collisionInfo.collider.name);
		if (collisionInfo.collider.tag == "Obstacle"){
			movement.enabled= false;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
