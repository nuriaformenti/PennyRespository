using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour {

	public float velocity;
	void Start () {
		Debug.Log ("Inici moviment del núvol");
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (velocity*Time.deltaTime, 0.0f, 0.0f);
	}
}
