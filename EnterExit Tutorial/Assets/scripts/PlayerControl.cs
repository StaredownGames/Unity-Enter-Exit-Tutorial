using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
	public float speed = 5;
	public float turnSpeed = 40;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		float axisH = Input.GetAxis("Horizontal");	
		float axisV = Input.GetAxis("Vertical");

		transform.Translate(Vector3.forward * axisV * speed * Time.deltaTime);
		transform.Rotate(Vector3.up * axisH * turnSpeed * Time.deltaTime);
	}
}
